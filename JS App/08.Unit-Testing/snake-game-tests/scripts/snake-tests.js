module("SnakePiece.init");

test("should set correct values",   
  function(){
    var position = {x: 150, y: 150}, size = 15, speed = 5, dir = 0;
    var piece = new snakeGame.SnakePiece(position, size, speed, dir);
    equal(piece.position, position);
    equal(piece.size, 15);
    equal(piece.speed, speed);
    equal(piece.direction, dir);
  });

module("SnakePiece.move");

test("When direction is 0, decrease x",
  function(){
    var position = {x: 150, y: 150}, size = 15, speed = 5, dir = 0;
    var piece = new snakeGame.SnakePiece(position, size, speed, dir);
    piece.move();
    position.x - speed;
    deepEqual(piece.position, position);
  });

test("When  direction is 1, decrease update y",
  function(){
    var position = {x: 150, y: 150}, size = 15, speed = 5, dir = 0;
    var piece = new snakeGame.SnakePiece(position, size, speed, dir);
    piece.move();
    position.y - speed;
    deepEqual(piece.position, position);
  });

test("When  direction is 2, increase x",
  function(){
    var position = {x: 150, y: 150}, size = 15, speed = 5, dir = 0;
    var piece = new snakeGame.SnakePiece(position, size, speed, dir);
    piece.move();
    position.x + speed;
    deepEqual(piece.position, position);
  });

test("When  direction is 3, should increase x",
  function(){
    var position = {x: 150, y: 150}, size = 15, speed = 5, dir = 0;
    var piece = new snakeGame.SnakePiece(position, size, speed, dir);
    piece.move();
    position.y + speed;
    deepEqual(piece.position, position);
  });


module("Snake.init");

test("When snake is initialized, should set the correct values", function() {
  var position = {
    x: 150,
    y: 150
  };
  var speed = 15;
  var direction = 0;
  var snake = new snakeGame.Snake(position, speed, direction);

  equal(position, snake.position, "Position is set");
  equal(speed, snake.speed, "Speed is set");
  equal(direction, snake.direction, "Direction is set");
});

test("When snake is initialized, should contain 5 SnakePieces", function() {
  var position = {
    x: 150,
    y: 150
  };
  var speed = 15;
  var direction = 0;
  var snake = new snakeGame.Snake(position, speed, direction);

  ok(snake.pieces,"SnakePieces are created");
  equal(snake.pieces.length, 5,"Five SnakePieces are created");
  ok(snake.head, "HeadSnakePiece is created");
});


module("Snake.Consume");
test("When object is Food, should grow", function() {
  var snake = new snakeGame.Snake({
    x: 150,
    y: 150
  }, 15, 0);
  var size = snake.size;
  snake.consume(new snakeGame.Food());
  var actual = snake.size;
  var expected = size + 1;
  equal(actual, expected);
});

test("When object is SnakePiece, should die", function() {
  var snake = new snakeGame.Snake({
    x: 150,
    y: 150
  }, 15, 0);

  var isDead = false;

  snake.addDieHandler(function() {
    isDead = true;
  });

  snake.consume(new snakeGame.SnakePiece());
  ok(isDead, "The snake is dead");
});

test("When object is Obstacle, should die", function() {
  var snake = new snakeGame.Snake({
    x: 150,
    y: 150
  }, 15, 0);

  var isDead = false;

  snake.addDieHandler(function() {
    isDead = true;
  });

  snake.consume(new snakeGame.Obstacle());
  ok(isDead, "The snake is dead");
});

module("Snake.grow");
test("When the snake grow, the pieces should be more", function () {
    var snake = new snakeGame.Snake({
        x: 150,
        y: 150
    }, 15, 0);
    var oldSnakeLength = snake.pieces.length;
    snake.grow();
    var newSnakeLength = snake.pieces.length;
    equal(oldSnakeLength + 1, newSnakeLength, "The snake has more pieces");
});

/// region: MovingGameObject

module("MovingGameObject.init (constructor)");
// no testStart function for reason to test for a while different parameters in every tests
test("Testing constructor correct initialization - zero test", function () {
    var position = { x: 0, y: 0 },
        size = 1,
        fcolor = "#000000",
        scolor = "#000000",
        speed = 1,
        direction = 0;

    var testMovingGameObject = new snakeGame.MovingGameObject(
        position,
        size,
        fcolor,
        scolor,
        speed,
        direction);

    equal(testMovingGameObject.position, position, "Checking position");
    equal(testMovingGameObject.size, size, "Checking size");
    equal(testMovingGameObject.fcolor, fcolor, "Checking fcolor");
    equal(testMovingGameObject.scolor, scolor, "Checking scolor");
    equal(testMovingGameObject.speed, speed, "Checking speed");
    equal(testMovingGameObject.direction, direction, "Checking directions");
});

test("Testing constructor correct initialization - middle test", function () {
    var position = { x: 150, y: 150 },
        size = 10,
        fcolor = "#FF0000",
        scolor = "#FF0000",
        speed = 50,
        direction = 2;

    var testMovingGameObject = new snakeGame.MovingGameObject(
        position,
        size,
        fcolor,
        scolor,
        speed,
        direction);

    equal(testMovingGameObject.position, position, "Checking position");
    equal(testMovingGameObject.size, size, "Checking size");
    equal(testMovingGameObject.fcolor, fcolor, "Checking fcolor");
    equal(testMovingGameObject.scolor, scolor, "Checking scolor");
    equal(testMovingGameObject.speed, speed, "Checking speed");
    equal(testMovingGameObject.direction, direction, "Checking directions");
});

test("Testing constructor correct initialization - upper test", function () {
    var position = { x: 300, y: 300 },
        size = 20,
        fcolor = "#AFBZA8",
        scolor = "#AFBZA8",
        speed = 100,
        direction = 3;

    var testMovingGameObject = new snakeGame.MovingGameObject(
        position,
        size,
        fcolor,
        scolor,
        speed,
        direction);

    equal(testMovingGameObject.position, position, "Checking position");
    equal(testMovingGameObject.size, size, "Checking size");
    equal(testMovingGameObject.fcolor, fcolor, "Checking fcolor");
    equal(testMovingGameObject.scolor, scolor, "Checking scolor");
    equal(testMovingGameObject.speed, speed, "Checking speed");
    equal(testMovingGameObject.direction, direction, "Checking directions");
});

module("MovingGameObject.move");

test("Move negative X  -->  (directions [0])  --> X: -1, Y: 0 ", function () {
    var position = { x: 0, y: 0 },
        size = 5,
        fcolor = "#000000",
        scolor = "#000000",
        speed = 1,
        direction = 0;

    var testMovingGameObject = new snakeGame.MovingGameObject(
        position,
        size,
        fcolor,
        scolor,
        speed,
        direction);

    var expectedPosition = { x: position.x - speed, y: position.y };
    testMovingGameObject.move();

    equal(testMovingGameObject.position.x, expectedPosition.x, "After move - checking position by X");
    equal(testMovingGameObject.position.y, expectedPosition.y, "After move - checking position by Y");
    deepEqual(testMovingGameObject.position, expectedPosition, "After move - checking position");
});

test("Move negative Y  -->  (directions [1])  --> X: 0, Y: -1 ", function () {
    var position = { x: 0, y: 0 },
        size = 5,
        fcolor = "#000000",
        scolor = "#000000",
        speed = 1,
        direction = 1;

    var testMovingGameObject = new snakeGame.MovingGameObject(
        position,
        size,
        fcolor,
        scolor,
        speed,
        direction);

    var expectedPosition = { x: position.x, y: position.y - speed };
    testMovingGameObject.move();

    equal(testMovingGameObject.position.x, expectedPosition.x, "After move - checking position by X");
    equal(testMovingGameObject.position.y, expectedPosition.y, "After move - checking position by Y");
    deepEqual(testMovingGameObject.position, expectedPosition, "After move - checking position");
});

test("Move positive X  -->  (directions [2])  --> X: +1, Y: 0 ", function () {
    var position = { x: 50, y: 40 },
        size = 5,
        fcolor = "#000000",
        scolor = "#000000",
        speed = 1,
        direction = 2;

    var testMovingGameObject = new snakeGame.MovingGameObject(
        position,
        size,
        fcolor,
        scolor,
        speed,
        direction);

    var expectedPosition = { x: position.x + speed, y: position.y };
    testMovingGameObject.move();

    equal(testMovingGameObject.position.x, expectedPosition.x, "After move - checking position by X");
    equal(testMovingGameObject.position.y, expectedPosition.y, "After move - checking position by Y");
    deepEqual(testMovingGameObject.position, expectedPosition, "After move - checking position");
});

test("Move positive Y  -->  (directions [3])  --> X: 0, Y: +1 ", function () {
    var position = { x: 120, y: 120 },
        size = 5,
        fcolor = "#000000",
        scolor = "#000000",
        speed = 1,
        direction = 3;

    var testMovingGameObject = new snakeGame.MovingGameObject(
        position,
        size,
        fcolor,
        scolor,
        speed,
        direction);

    var expectedPosition = { x: position.x, y: position.y + speed };
    testMovingGameObject.move();

    equal(testMovingGameObject.position.x, expectedPosition.x, "After move - checking position by X");
    equal(testMovingGameObject.position.y, expectedPosition.y, "After move - checking position by Y");
    deepEqual(testMovingGameObject.position, expectedPosition, "After move - checking position");
});

test("Move negative X  -->  (directions [0])  --> X: -1, Y: 0 with speed 10 ", function () {
    var position = { x: 20, y: 20 },
        size = 5,
        fcolor = "#000000",
        scolor = "#000000",
        speed = 10,
        direction = 0;

    var testMovingGameObject = new snakeGame.MovingGameObject(
        position,
        size,
        fcolor,
        scolor,
        speed,
        direction);

    var expectedPosition = { x: position.x - speed, y: position.y };
    testMovingGameObject.move();

    equal(testMovingGameObject.position.x, expectedPosition.x, "After move - checking position by X");
    equal(testMovingGameObject.position.y, expectedPosition.y, "After move - checking position by Y");
    deepEqual(testMovingGameObject.position, expectedPosition, "After move - checking position");
});

test("Move negative Y  -->  (directions [1])  --> X: 0, Y: -1 with speed 10 ", function () {
    var position = { x: 100, y: 100 },
        size = 5,
        fcolor = "#000000",
        scolor = "#000000",
        speed = 10,
        direction = 1;

    var testMovingGameObject = new snakeGame.MovingGameObject(
        position,
        size,
        fcolor,
        scolor,
        speed,
        direction);

    var expectedPosition = { x: position.x, y: position.y - speed };
    testMovingGameObject.move();

    equal(testMovingGameObject.position.x, expectedPosition.x, "After move - checking position by X");
    equal(testMovingGameObject.position.y, expectedPosition.y, "After move - checking position by Y");
    deepEqual(testMovingGameObject.position, expectedPosition, "After move - checking position");
});


(function () {
    module("MovingGameObject.changeDirection");

    QUnit.testStart(function () {
        var position = { x: 100, y: 100 }, size = 5, fcolor = "#000000", scolor = "#000000", speed = 10, direction = 0;

        objectForDirectionTests = new snakeGame.MovingGameObject(position, size, fcolor, scolor, speed, direction);
    });

    var objectForDirectionTests;

    test("Direction 0 ( X: -1, Y: 0 ): change direction to 0 (no change)!", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 0;
        var startDirection = testMovingGameObject.direction;
        var newDirection = 0;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, startDirection, "After change direction - no change was made");
    });

    test("Direction 0 ( X: -1, Y: 0 ): change direction to 1", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 0;
        var newDirection = 1;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, newDirection, "Direction was changed from 0 to 1");
    });

    test("Direction 0 ( X: -1, Y: 0 ): change direction to 2 (no change)!", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 0;
        var startDirection = testMovingGameObject.direction;
        var newDirection = 2;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, startDirection, "After change direction - no change was made");
    });

    test("Direction 0 ( X: -1, Y: 0 ): change direction to 3", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 0;
        var newDirection = 3;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, newDirection, "Direction was changed from 0 to 3");
    });

    test("Direction 0 ( X: -1, Y: 0 ): change direction to 1, 2, 3 and 0 (full rotation to right)", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 0;
        var startDirection = testMovingGameObject.direction;

        testMovingGameObject.changeDirection(1);
        equal(testMovingGameObject.direction, 1, "Direction was changed from 0 to 1");
        testMovingGameObject.changeDirection(2);
        equal(testMovingGameObject.direction, 2, "Direction was changed from 1 to 2");
        testMovingGameObject.changeDirection(3);
        equal(testMovingGameObject.direction, 3, "Direction was changed from 2 to 3");
        testMovingGameObject.changeDirection(0);

        equal(testMovingGameObject.direction, startDirection, "After full rotation to right - direction was again the same - 0");
    });

    test("Direction 0 ( X: -1, Y: 0 ): change direction to 3, 2, 1 and 0 (full rotation to left)", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 0;
        var startDirection = testMovingGameObject.direction;

        testMovingGameObject.changeDirection(3);
        equal(testMovingGameObject.direction, 3, "Direction was changed from 0 to 3");
        testMovingGameObject.changeDirection(2);
        equal(testMovingGameObject.direction, 2, "Direction was changed from 3 to 2");
        testMovingGameObject.changeDirection(1);
        equal(testMovingGameObject.direction, 1, "Direction was changed from 2 to 1");
        testMovingGameObject.changeDirection(0);

        equal(testMovingGameObject.direction, startDirection, "After full rotation to left - direction was again the same - 0");
    });

    test("Direction 1 ( X: 0, Y: -1 ): change direction to 0", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 1;
        var newDirection = 0;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, newDirection, "Direction was changed from 1 to 0");
    });

    test("Direction 1 ( X: 0, Y: -1 ): change direction to 1 (no change)!", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 1;
        var startDirection = testMovingGameObject.direction;
        var newDirection = 1;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, startDirection, "After change direction - no change was made");
    });

    test("Direction 1 ( X: 0, Y: -1 ): change direction to 2", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 1;
        var newDirection = 2;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, newDirection, "Direction was changed from 1 to 2");
    });

    test("Direction 1 ( X: 0, Y: -1 ): change direction to 3 (no change)!", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 1;
        var startDirection = testMovingGameObject.direction;
        var newDirection = 3;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, startDirection, "After change direction - no change was made");
    });

    test("Direction 1 ( X: 0, Y: -1 ): change direction to 2, 3, 0 and 1 (full rotation to right)", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 1;
        var startDirection = testMovingGameObject.direction;

        testMovingGameObject.changeDirection(2);
        equal(testMovingGameObject.direction, 2, "Direction was changed from 1 to 2");
        testMovingGameObject.changeDirection(3);
        equal(testMovingGameObject.direction, 3, "Direction was changed from 2 to 3");
        testMovingGameObject.changeDirection(0);
        equal(testMovingGameObject.direction, 0, "Direction was changed from 3 to 0");
        testMovingGameObject.changeDirection(1);

        equal(testMovingGameObject.direction, startDirection, "After full rotation to right - direction was again the same - 1");
    });

    test("Direction 1 ( X: 0, Y: -1 ): change direction to 0, 3, 2 and 1 (full rotation to left)", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 1;
        var startDirection = testMovingGameObject.direction;

        testMovingGameObject.changeDirection(0);
        equal(testMovingGameObject.direction, 0, "Direction was changed from 1 to 0");
        testMovingGameObject.changeDirection(3);
        equal(testMovingGameObject.direction, 3, "Direction was changed from 0 to 3");
        testMovingGameObject.changeDirection(2);
        equal(testMovingGameObject.direction, 2, "Direction was changed from 3 to 2");
        testMovingGameObject.changeDirection(1);

        equal(testMovingGameObject.direction, startDirection, "After full rotation to left - direction was again the same - 1");
    });

    test("Direction 2 ( X: 1, Y: 0 ): change direction to 0 (no change)!", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 2;
        var startDirection = testMovingGameObject.direction;
        var newDirection = 0;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, startDirection, "After change direction - no change was made");
    });

    test("Direction 2 ( X: 1, Y: 0 ): change direction to 1", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 2;
        var newDirection = 1;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, newDirection, "Direction was changed from 2 to 1");
    });

    test("Direction 2 ( X: 1, Y: 0 ): change direction to 2 (no change)!", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 2;
        var startDirection = testMovingGameObject.direction;
        var newDirection = 2;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, startDirection, "After change direction - no change was made");
    });

    test("Direction 2 ( X: 1, Y: 0 ): change direction to 3", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 2;
        var newDirection = 3;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, newDirection, "Direction was changed from 2 to 3");
    });

    test("Direction 2 ( X: 1, Y: 0 ): change direction to 3, 0, 1 and 2 (full rotation to right)", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 2;
        var startDirection = testMovingGameObject.direction;

        testMovingGameObject.changeDirection(3);
        equal(testMovingGameObject.direction, 3, "Direction was changed from 2 to 3");
        testMovingGameObject.changeDirection(0);
        equal(testMovingGameObject.direction, 0, "Direction was changed from 3 to 0");
        testMovingGameObject.changeDirection(1);
        equal(testMovingGameObject.direction, 1, "Direction was changed from 0 to 1");
        testMovingGameObject.changeDirection(2);

        equal(testMovingGameObject.direction, startDirection, "After full rotation to right - direction was again the same - 2");
    });

    test("Direction 2 ( X: 1, Y: 0 ): change direction to 1, 0, 3 and 2 (full rotation to left)", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 2;
        var startDirection = testMovingGameObject.direction;

        testMovingGameObject.changeDirection(1);
        equal(testMovingGameObject.direction, 1, "Direction was changed from 2 to 1");
        testMovingGameObject.changeDirection(0);
        equal(testMovingGameObject.direction, 0, "Direction was changed from 1 to 0");
        testMovingGameObject.changeDirection(3);
        equal(testMovingGameObject.direction, 3, "Direction was changed from 0 to 3");
        testMovingGameObject.changeDirection(2);

        equal(testMovingGameObject.direction, startDirection, "After full rotation to left - direction was again the same - 2");
    });

    test("Direction 3 ( X: 0, Y: 1 ): change direction to 0", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 3;
        var newDirection = 0;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, newDirection, "Direction was changed from 3 to 0");
    });

    test("Direction 3 ( X: 0, Y: 1 ): change direction to 1 (no change)!", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 3;
        var startDirection = testMovingGameObject.direction;
        var newDirection = 1;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, startDirection, "After change direction - no change was made");
    });

    test("Direction 3 ( X: 0, Y: 1 ): change direction to 2", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 3;
        var newDirection = 2;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, newDirection, "Direction was changed from 3 to 2");
    });

    test("Direction 3 ( X: 0, Y: 1 ): change direction to 3 (no change)!", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 3;
        var startDirection = testMovingGameObject.direction;
        var newDirection = 3;

        testMovingGameObject.changeDirection(newDirection);

        equal(testMovingGameObject.direction, startDirection, "After change direction - no change was made");
    });

    test("Direction 3 ( X: 0, Y: 1 ): change direction to 0, 1, 2 and 3 (full rotation to right)", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 3;
        var startDirection = testMovingGameObject.direction;

        testMovingGameObject.changeDirection(0);
        equal(testMovingGameObject.direction, 0, "Direction was changed from 3 to 0");
        testMovingGameObject.changeDirection(1);
        equal(testMovingGameObject.direction, 1, "Direction was changed from 0 to 1");
        testMovingGameObject.changeDirection(2);
        equal(testMovingGameObject.direction, 2, "Direction was changed from 1 to 2");
        testMovingGameObject.changeDirection(3);

        equal(testMovingGameObject.direction, startDirection, "After full rotation to right - direction was again the same - 3");
    });

    test("Direction 3 ( X: 0, Y: 1 ): change direction to 2, 1, 0 and 3 (full rotation to left)", function () {
        var testMovingGameObject = objectForDirectionTests;
        testMovingGameObject.direction = 3;
        var startDirection = testMovingGameObject.direction;

        testMovingGameObject.changeDirection(2);
        equal(testMovingGameObject.direction, 2, "Direction was changed from 3 to 2");
        testMovingGameObject.changeDirection(1);
        equal(testMovingGameObject.direction, 1, "Direction was changed from 2 to 1");
        testMovingGameObject.changeDirection(0);
        equal(testMovingGameObject.direction, 0, "Direction was changed from 1 to 0");
        testMovingGameObject.changeDirection(3);

        equal(testMovingGameObject.direction, startDirection, "After full rotation to left - direction was again the same - 3");
    });
    QUnit.testStart(function () { });
}());

/// endregion: MovingGameObject

/// region: MovingGameObject
module("Food.init (constructor)");

test("When food is initialized, should set correct all values", function () {
    var testFoodPosition = {
        x: 30,
        y: 30
    };
    var testFoodSize = 10;
    var testFoodFillColor = "#0000ff";
    var testFoodStrokeColor = "#00ff00";

    var food = new snakeGame.Food(testFoodPosition, testFoodSize);
    equal(food.fcolor, testFoodFillColor, "The fill color is correct");
    equal(food.scolor, testFoodStrokeColor, "The stroke color is correct");
    equal(food.position.x, testFoodPosition.x, "The food X position is correct");
    equal(food.position.y, testFoodPosition.y, "The food Y position is correct");
    equal(food.size, testFoodSize, "The size of the food is as expected");
});

test("Initializing the food at position 0x0", function () {
    var testFoodPosition = {
        x: 0,
        y: 0
    };
    var testFoodSize = 10;
    var food = new snakeGame.Food(testFoodPosition, testFoodSize);
    equal(food.position.x, testFoodPosition.x, "The food X position is correct");
    equal(food.position.y, testFoodPosition.y, "The food Y position is correct");
    equal(food.size, testFoodSize, "The size of the food is as expected");
});

test("Initializing the food at position 150x150", function () {
    var testFoodPosition = {
        x: 150,
        y: 150
    };
    var testFoodSize = 10;
    var food = new snakeGame.Food(testFoodPosition, testFoodSize);
    equal(food.position.x, testFoodPosition.x, "The food X position is correct");
    equal(food.position.y, testFoodPosition.y, "The food Y position is correct");
    equal(food.size, testFoodSize, "The size of the food is as expected");
});

test("Initializing the food at position 300x300", function () {
    var testFoodPosition = {
        x: 300,
        y: 300
    };
    var testFoodSize = 10;
    var food = new snakeGame.Food(testFoodPosition, testFoodSize);
    equal(food.position.x, testFoodPosition.x, "The food X position is correct");
    equal(food.position.y, testFoodPosition.y, "The food Y position is correct");
    equal(food.size, testFoodSize, "The size of the food is as expected");
});

module("Food.changePosition");

test("Change the food position from 0x0 to position 300x300", function () {
    var startFoodPosition = {
        x: 0,
        y: 0
    };
    var testFoodSize = 10;
    var food = new snakeGame.Food(startFoodPosition, testFoodSize);
    equal(food.position.x, startFoodPosition.x, "The food X position is correct");
    equal(food.position.y, startFoodPosition.y, "The food Y position is correct");
    equal(food.size, testFoodSize, "The size of the food is as expected");

    var newFoodPosition = {
        x: 300,
        y: 300
    };

    food.changePosition(newFoodPosition);
    equal(food.position.x, newFoodPosition.x, "The food X position is correct");
    equal(food.position.y, newFoodPosition.y, "The food Y position is correct");
    equal(food.size, testFoodSize, "The size of the food is as expected");
});

test("Change the food position from 30x60 to position 80x20", function () {
    var startFoodPosition = {
        x: 30,
        y: 60
    };
    var testFoodSize = 10;
    var food = new snakeGame.Food(startFoodPosition, testFoodSize);
    equal(food.position.x, startFoodPosition.x, "The food X position is correct");
    equal(food.position.y, startFoodPosition.y, "The food Y position is correct");
    equal(food.size, testFoodSize, "The size of the food is as expected");

    var newFoodPosition = {
        x: 80,
        y: 20
    };

    food.changePosition(newFoodPosition);
    equal(food.position.x, newFoodPosition.x, "The food X position is correct");
    equal(food.position.y, newFoodPosition.y, "The food Y position is correct");
    equal(food.size, testFoodSize, "The size of the food is as expected");
});
/// endregion: Food