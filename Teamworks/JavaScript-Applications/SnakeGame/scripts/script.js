var snakeGame = (function () {
    'use strict';
    // Controls
    $(function() {
        $(document).keydown(function (ev) {
            switch (ev.keyCode) {
                case 13: //enter
                    setInterval(startGame, 100);
                    break;
                case 65: //a
                    snake.turnLeft();
                    break;
                case 37: //left arrow
                    snake.turnLeft();
                    break;
                case 82: // r
                    restartGame();
                    break;
                case 87: // up arrow
                    snake.turnUp();
                    break;
                case 38: // up arrow
                    snake.turnUp();
                    break;
                case 68: // d
                    snake.turnRight();
                    break;
                case 39: // right arrow
                    snake.turnRight();
                    break;
                case 83: // s
                    snake.turnDown();
                    break;
                case 40: // down arrow
                    snake.turnDown();
                    break;
                case 32: //space
                    setInterval(startGame, 100);
                    break;
            }
        });
    });

    // Class Queue
    function Queue() {
        var that = this;
        that.arr = [];
    }

    Queue.prototype = {
        constructor: Queue,

        enqueue: function (elem) {
            this.arr.push(elem);
        },

        dequeue: function () {
            var retValue = this.arr[0];
            var newArr = new Array(this.arr.length - 1);
            for (var i = 0; i < newArr.length; i++) {
                newArr[i] = this.arr[i + 1];
            }

            this.arr = newArr;
            return retValue;
        },

        getFirstElem: function () {
            return this.arr[0];
        },

        getLastElem: function () {
            return this.arr[this.arr.length - 1];
        },

        elementAt: function (index) {
            return this.arr[index];
        },

        length: function () {
            return this.arr.length;
        }
    }

    function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++ ) {
        color += letters[Math.round(Math.random() * 15)];
    }
    return color;
    }

    function restartGame() {
        document.location.reload(false);
    }
   
    // Class Snake
    function Snake(x, y) {
        var bodyLength = 4;
        var that = this;
        that.snakeBody = new Queue();
        for (var i = 0; i < bodyLength; i++) {
            that.snakeBody.enqueue(new Coords(x + i, y));
        }

        that.currentDirection = new Coords(1, 0);
        that.head = that.snakeBody.getLastElem();
    }

    Snake.prototype = {
        constructor: Snake,

        getHead: function () {
            return this.head;
        },

        getNextHead: function () {
            var nextHead =
				new Coords(
					parseInt(this.head.x + this.currentDirection.x) / 10,
					parseInt(this.head.y + this.currentDirection.y) / 10
				);

            return nextHead;
        },

        move: function () {
            var nextHead = this.getNextHead();
            this.snakeBody.enqueue(nextHead);
            this.snakeBody.dequeue();

            this.head = nextHead;
        },

        turnLeft: function () {
            if (this.currentDirection.x !== 1 && this.currentDirection.y !== 0) {
                var leftDirection = new Coords(-1, 0);
                this.currentDirection = leftDirection;
            }
        },

        turnRight: function () {
            if (this.currentDirection.x !== -1 && this.currentDirection.y !== 0) {
                var rightDirection = new Coords(1, 0);
                this.currentDirection = rightDirection;
            }
        },

        turnUp: function () {
            if (this.currentDirection.x !== 0 && this.currentDirection !== 1) {
                var upDirection = new Coords(0, -1);
                this.currentDirection = upDirection;
            }
        },

        turnDown: function () {
            if (this.currentDirection.x !== 0 && this.curentDirection !== -1) {
                var downDirection = new Coords(0, 1);
                this.currentDirection = downDirection;
            }
        }
    }
    
    // Class Food
    function Food(width, height, obstacles) {
        var minWidth = 15;
        var maxWidth = width - 15;
        var minHeight = 15;
        var maxHeight = height - 15;

        var x = parseInt((Math.random() * (maxWidth - minWidth) + minWidth) / 10);
        var y = parseInt((Math.random() * (maxHeight - minHeight) + minHeight) / 10);
        var insideAnObstacle = true;
        while (insideAnObstacle) {
            insideAnObstacle = false;
            for (var obstacle in obstacles) {
                var obst = obstacles[obstacle];
                if 	   (x >= (obst.x-10) &&
                        x <= (obst.x + obst.width) &&
                        y >= (obst.y-10) &&
                        y <= (obst.y + (obst.height)-5)) {
                    insideAnObstacle = true;
					console.log("true");
                    x = parseInt((Math.random() * (maxWidth - minWidth)
								+ minWidth) / 10);
                    y = parseInt((Math.random() * (maxHeight - minHeight) 
								+ minHeight) / 10);
                }
            }
        }

        this.coords = new Coords(x, y);
    }

    // Coords
    function Coords(x, y) {
        var that = this;
        that.x = x * 10;
        that.y = y * 10;
    }

    function Obstacle(x, y, width, height) {
        var that = this;
        that.x = x;
        that.y = y;
        that.width = width;
        that.height = height;
    }

    function Level() {
        var that = this;
        that.obstacles = [];
    }
    Level.prototype = {
        draw: function (ctx) {
            for (var obstacle in this.obstacles) {
                var obst = this.obstacles[obstacle];
                ctx.strokeStyle = "cyan";
                ctx.fillStyle = "purple";
                ctx.fillRect(obst.x, obst.y, obst.width, obst.height);
                ctx.strokeRect(obst.x, obst.y, obst.width, obst.height);
            }
        },
        addObstacle: function (obstacle) {
            this.obstacles.push(obstacle);
        }
    }

    function drawField() {
        var canvas = document.getElementsByTagName("canvas")[0];
        var width = canvas.width;
        var height = canvas.height;
        var ctx = canvas.getContext("2d");

        ctx.save();

        ctx.fillStyle = "#598EDE";
        ctx.fillRect(0, 0, width, height);

        ctx.fillStyle = "black";
        ctx.strokeStyle = "cyan";

        // Draws the upper and lower borders
        for (var i = 0; i < width; i += 10) {
            ctx.fillRect(i, 0, 10, 10);
            ctx.strokeRect(i, 0, 10, 10);

            ctx.fillRect(i, height - 10, 10, 10);
            ctx.strokeRect(i, height - 10, 10, 10);
        }

        // Draws the left and right borders
        for (var i = 0; i < height; i += 10) {
            ctx.fillRect(0, i, 10, 10);
            ctx.strokeRect(0, i, 10, 10);

            ctx.fillRect(width - 10, i, 10, 10);
            ctx.strokeRect(width - 10, i, 10, 10);
        }

        // for different levels
        level.draw(ctx);

        ctx.restore();
    }

    function drawFood(food) {
        var canvas = document.getElementsByTagName("canvas")[0];
        var ctx = canvas.getContext("2d");
        ctx.save();

        ctx.fillStyle = getRandomColor();
        ctx.strokeStyle = "#000";
        ctx.fillRect(food.coords.x, food.coords.y, 12, 12);
        ctx.strokeRect(food.coords.x, food.coords.y, 12, 12);

        ctx.restore();
    }

    function drawSnake(ctx, snake) {
        var canvas = document.getElementsByTagName("canvas")[0];
        var ctx = canvas.getContext("2d");
        ctx.save();

        ctx.fillStyle = "#f00";
        ctx.strokeStyle = "cyan";       
        var snakeBody = snake.snakeBody;
        for (var i = 0; i < snakeBody.length() ; i++) {
            var snakeElem = snakeBody.elementAt(i);
            ctx.fillRect(snakeElem.x, snakeElem.y, 15, 15);
            ctx.strokeRect(snakeElem.x, snakeElem.y, 15, 15);
        }

        ctx.restore();
    }

    function run(ctx, snake, width, height) {
 
        var nextHead = snake.getNextHead();
        var snakeBody = snake.snakeBody;

        // check for collision with itself
        for (var i = 0; i < snakeBody.length() ; i++) {
            var elem = snakeBody.elementAt(i);
            if (elem.x === nextHead.x && elem.y === nextHead.y) {
                saveScore(score);
                restartGame();
            }
        }

        // check for collision with side walls
        if (nextHead.x <= 0 ||
				nextHead.x >= width - 10 ||
				nextHead.y <= 0 ||
				nextHead.y >= height-20) {
            saveScore(score);
            restartGame();

        }
        // chech for collision with game level walls
        for (var obstacle in level.obstacles) {
            var obst = level.obstacles[obstacle];
            if (nextHead.x >= obst.x-10 &&
                    nextHead.x <= obst.x + obst.width &&
                    nextHead.y >= obst.y-15  &&
                    nextHead.y <= obst.y + obst.height -10) {
                saveScore(score);
                restartGame();
            }
        }

        // check for collision with food
        for (var i = 0; i < snakeBody.length() ; i++) {
            var elem = snakeBody.elementAt(i);
            if (elem.x === food.coords.x && elem.y === food.coords.y) {
                var snakeNextHead = snake.getNextHead();
                snake.snakeBody.enqueue(snakeNextHead);
                snake.head = snakeNextHead;
                food = new Food(width, height, level.obstacles);
                setScore(score + 100);
                scoreDiv.innerHTML = "Score: " + score;
                break;
            }
        }

        snake.move();
        drawField();
        drawFood(food);
        drawSnake(ctx, snake);
        ctx.fillStyle = "cyan";
        ctx.font = "20px Georgia";
        ctx.fillText("Score: " + score, width - 110, 30);

    }

    function saveScore(score) {
        var name = prompt("GAME OVER!\nEnter nickname:");
         if (localStorage[name]) {
         	if (localStorage[name] < score) {
        		localStorage[name] = score;
        	}
         }
         else {
        localStorage[name] = score;
        }
    }

    function startGame() {
        run(ctx, snake, width, height);
    }

    var canvas = document.getElementsByTagName("canvas")[0];
    var width = canvas.width;
    var height = canvas.height;
    var ctx = canvas.getContext("2d");

    var level = new Level();
    var previousObstacle = new Obstacle(100, 60, 25, 200);
    level.addObstacle(new Obstacle(100, 
	60, 25, 200));

	var snake = new Snake (1,1);
    var food = new Food(width, height, level.obstacles);
    var score = 0;

    function setScore(value) {
       score = value;
        if (score % 100 == 0 && previousObstacle.x + 70 < canvas.width) {
            previousObstacle.x += 100;
            level.addObstacle(new Obstacle(previousObstacle.x, previousObstacle.y, 25, 200));
            drawField(ctx, width, height);
        }
    }

    drawField(ctx, width, height);
    drawSnake(ctx, snake);
    var scoreDiv = $("#rank-list").html("Score" + score);

    return {
        Queue: Queue,
        Snake: Snake,
        Food: Food,
        Coords: Coords,
        Obstacle: Obstacle,
        Level: Level
    }
}());

var ranklist = (function () {

	function clearScore() {
		localStorage.clear();
		var rankList = document.getElementById("#rank-list")
	}

	(function loadTopFiveScores() {
		function Pair(key, value) {
			this.key = key;
			this.value = value;
		}

		var allScores = [];
		for (var prop in localStorage) {
			allScores.push(new Pair(prop, localStorage[prop]));
		}

		// sort the scores
		for (var i = 0; i < allScores.length - 1; i++) {
			var maxScoreIndex = i;
			for (var j = i + 1; j < allScores.length; j++) {
				if (parseInt(allScores[j].value) > parseInt(allScores[maxScoreIndex].value)) {
					maxScoreIndex = j;
				}
			}

			var temp = allScores[i];
			allScores[i] = allScores[maxScoreIndex];
			allScores[maxScoreIndex] = temp;
		}

		// load the top five scores
		var rankList = document.getElementById("rank-list");
		var length;
		if (allScores.length < 5) {
			length = allScores.length;
		}
		else {
			length = 5;
		}

		for (var i = 0; i < length; i++) {
			var div = document.createElement("div");
			div.innerHTML = allScores[i].key + ": " + allScores[i].value;
			rankList.appendChild(div);
		}
	})();
}());

// TABS
  $(function() {
    $( "#tabs" ).tabs();
  });