(function () {

module( "Queue tests" );
	test( "Add one element", function( assert ) { 
		var queue = new snakeGame.Queue();
		queue.enqueue(1);
	 
		var result = queue.length();
	 
		assert.equal( result, 1, "One element added!" );
	});

	test( "Add multiple elements", function( assert ) { 
		var queue = new snakeGame.Queue();
		queue.enqueue(1);
		queue.enqueue(2);
		queue.enqueue(3);
	 
		var result = queue.length();
	 
		assert.equal( result, 3, "Three elements was added!" );
	});

	test( "Test dequeue", function( assert ) { 
		var queue = new snakeGame.Queue();
		queue.enqueue(1);
		queue.enqueue(2);
	 
		var result = queue.dequeue();
	 
		assert.equal( result, 1, "Add two elemetns and dequeue" );
	});

	test( "Test Get first ELement", function( assert ) { 
		var queue = new snakeGame.Queue();
		queue.enqueue(524);
		queue.enqueue(2);
	 
		var result = queue.getFirstElem();
	 
		assert.equal( result, 524, "Get first element of queue" );
	});

	test( "Test Get last ELement", function( assert ) { 
		var queue = new snakeGame.Queue();
		queue.enqueue(524);
		queue.enqueue(2);
	 
		var result = queue.getLastElem();
	 
		assert.equal( result, 2, "Get last element of queue" );
	});

	test( "Test Element at given position", function( assert ) { 
		var queue = new snakeGame.Queue();
		queue.enqueue(524);
		queue.enqueue(2);
		queue.enqueue(22);
		queue.enqueue(211);
	 
		var result = queue.elementAt(2);
	 
		assert.equal( result, 22, "Get element with index 2" );
	});

	test( "Test Queue length", function( assert ) { 
		var queue = new snakeGame.Queue();
		queue.enqueue(524);
		queue.enqueue(2);
		queue.enqueue(22);
		queue.enqueue(211);
	 
		var result = queue.length();
	 
		assert.equal( result, 4, "Get length" );
	});

module( "Snake tests" );	
	test( "Starting length of snake", function( assert ) { 
		var snake = new snakeGame.Snake();
		var length = snake.snakeBody.length();
		var expected = 4;
	 
		assert.equal( expected, length, "Starting length is correct!" );
	});
	
	test( "Starting coordinate X of snake", function( assert ) { 
		var snake = new snakeGame.Snake();
		var coordinateX = snake.currentDirection.x;
		var expected = 10;
	 
		assert.equal( coordinateX, expected, "Starting coordinate X is correct!" );
	});
	
	test( "Starting coordinate Y of snake", function( assert ) { 
		var snake = new snakeGame.Snake();
		var coordinateY = snake.currentDirection.y;
		var expected = 0;
	 
		assert.equal( coordinateY, expected, "Starting coordinate Y is correct!" );
	});
	
	test( "Get head of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(10, 0);
		var head = snake.getHead();
		var expected = { x : 130, y : 0};
	 
		assert.equal( head.x, expected.x, "Head X coordinate is correct!" );
		assert.equal( head.y, expected.y, "Head Y coordinate is correct!" );
	});
	
	test( "Get next head of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(10, 0);
		var nextHead = snake.getNextHead();
		var expected = { x : 140, y : 0};
	 
		assert.equal( nextHead.x, expected.x, "Next head X coordinate is correct!" );
		assert.equal( nextHead.y, expected.y, "Next head Y coordinate is correct!" );
	});
	
	test( "Check move of the snake by X", function( assert ) { 
		var snake = new snakeGame.Snake(20, 0);
		var startHead = snake.snakeBody.arr[3].x;
		var startTail = snake.snakeBody.arr[0].x;
		snake.move();
		var lengthOfSnake = startHead - startTail;
		var movedHead = snake.snakeBody.arr[3].x;
		var movedTail = snake.snakeBody.arr[0].x;
		var movementOfHead = movedHead - startHead;
		var movementOfTail = movedTail - startTail;
		
		var expectedValueOfTheHead = 240;
		var expectedValueOfTheTail = 210;
		var expectedMovingOfTheHead = 10;
		var expectedMovindOfTheTail = 10;
		
		assert.equal( movementOfHead, movementOfTail, "The tail moved as much as the head!" );	
		
		assert.equal( movementOfHead, expectedMovingOfTheHead, "Moved head value by X is correct!" );
		assert.equal( movementOfTail, expectedMovindOfTheTail, "Moved tail value by X is correct!" );
		
		assert.equal( movedHead, expectedValueOfTheHead, "Moved head value by X is correct!" );
		assert.equal( movedTail, expectedValueOfTheTail, "Moved tail value by X is correct!" );
	});
	
	test( "Check start direction of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(30, 30);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;		
		
		var expectedStartDirectionX = 10;
		var expectedStartDirectionY = 0;
		
		assert.equal( startDirectionX, expectedStartDirectionX, "Start direction by X is correct!" );
		assert.equal( startDirectionY, expectedStartDirectionY, "Start direction by Y is correct!" );
	});		
	
	test( "Check turn UP of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(30, 30);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;
		
		snake.turnUp();
		
		var directionXAfterTurnUp = snake.currentDirection.x;
		var directionYAfterTurnUp = snake.currentDirection.y;	

		var expectedDirectionX = 0;
		var expectedDirectionY = -10;
		
		assert.equal( directionXAfterTurnUp, expectedDirectionX, "After turn UP direction by X is correct!" );
		assert.equal( directionYAfterTurnUp, expectedDirectionY, "After turn UP direction by Y is correct!" );
	});

	test( "Check second turn UP of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(30, 30);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;
		
		snake.turnUp();
		
		var directionXAfterTurnUp = snake.currentDirection.x;
		var directionYAfterTurnUp = snake.currentDirection.y;	
		
		snake.turnUp();
		
		var directionXAfterSecondTurnUp = snake.currentDirection.x;
		var directionYAfterSecondTurnUp = snake.currentDirection.y;	
		
		var hasDirectionXChanged = directionXAfterSecondTurnUp - directionXAfterTurnUp;
		var hasDirectionYChanged = directionYAfterSecondTurnUp - directionYAfterTurnUp;

		var expectedDirectionX = 0;
		var expectedDirectionY = -10;
		
		assert.equal( hasDirectionXChanged, 0, "After second turn UP direction by X has no changing!" );
		assert.equal( hasDirectionYChanged, 0, "After second turn UP direction by Y has no changing!" );
		
		assert.equal( directionXAfterSecondTurnUp, expectedDirectionX, "After second turn UP direction by X is correct!" );
		assert.equal( directionYAfterSecondTurnUp, expectedDirectionY, "After second turn UP direction by Y is correct!" );
	});
	
		test( "Check turn DOWN of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(20, 20);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;
		
		snake.turnDown();
		
		var directionXAfterTurnDown = snake.currentDirection.x;
		var directionYAfterTurnDown = snake.currentDirection.y;	

		var expectedDirectionX = 0;
		var expectedDirectionY = 10;
		
		assert.equal( directionXAfterTurnDown, expectedDirectionX, "After turn UP direction by X is correct!" );
		assert.equal( directionYAfterTurnDown, expectedDirectionY, "After turn UP direction by Y is correct!" );
	});

	test( "Check second turn DOWN of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(40, 40);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;
		
		snake.turnDown();
		
		var directionXAfterTurnDown = snake.currentDirection.x;
		var directionYAfterTurnDown = snake.currentDirection.y;	
		
		snake.turnDown();
		
		var directionXAfterSecondTurnDown = snake.currentDirection.x;
		var directionYAfterSecondTurnDown = snake.currentDirection.y;	
		
		var hasDirectionXChanged = directionXAfterSecondTurnDown - directionXAfterTurnDown;
		var hasDirectionYChanged = directionYAfterSecondTurnDown - directionYAfterTurnDown;

		var expectedDirectionX = 0;
		var expectedDirectionY = 10;
		
		assert.equal( hasDirectionXChanged, 0, "After second turn DOWN direction by X has no changing!" );
		assert.equal( hasDirectionYChanged, 0, "After second turn DOWN direction by Y has no changing!" );
		
		assert.equal( directionXAfterSecondTurnDown, expectedDirectionX, "After second turn DOWN direction by X is correct!" );
		assert.equal( directionYAfterSecondTurnDown, expectedDirectionY, "After second turn DOWN direction by Y is correct!" );
	});
	
	test( "Check turn LEFT of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(40, 40);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;
		
		snake.turnDown();
		snake.turnLeft();
		
		var directionXAfterTurnLeft = snake.currentDirection.x;
		var directionYAfterTurnLeft = snake.currentDirection.y;	

		var expectedDirectionX = -10;
		var expectedDirectionY = 0;
		
		assert.equal( directionXAfterTurnLeft, expectedDirectionX, "After turn LEFT direction by X is correct!" );
		assert.equal( directionYAfterTurnLeft, expectedDirectionY, "After turn LEFT direction by Y is correct!" );
	});

	test( "Check second turn LEFT of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(30, 30);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;
		
		snake.turnDown();
		snake.turnLeft();
		
		var directionXAfterTurnLeft = snake.currentDirection.x;
		var directionYAfterTurnLeft = snake.currentDirection.y;	
		
		snake.turnLeft();
		
		var directionXAfterSecondTurnLeft = snake.currentDirection.x;
		var directionYAfterSecondTurnLeft = snake.currentDirection.y;	
		
		var hasDirectionXChanged = directionXAfterSecondTurnLeft - directionXAfterTurnLeft;
		var hasDirectionYChanged = directionYAfterSecondTurnLeft - directionYAfterTurnLeft;

		var expectedDirectionX = -10;
		var expectedDirectionY = 0;
		
		assert.equal( hasDirectionXChanged, 0, "After second turn LEFT direction by X has no changing!" );
		assert.equal( hasDirectionYChanged, 0, "After second turn LEFT direction by Y has no changing!" );
		
		assert.equal( directionXAfterSecondTurnLeft, expectedDirectionX, "After second turn LEFT direction by X is correct!" );
		assert.equal( directionYAfterSecondTurnLeft, expectedDirectionY, "After second turn LEFT direction by Y is correct!" );
	});
	
	test( "Check turn RIGHT of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(20, 30);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;
		
		snake.turnDown();
		snake.turnRight();
		
		var directionXAfterTurnRight = snake.currentDirection.x;
		var directionYAfterTurnRight = snake.currentDirection.y;	

		var expectedDirectionX = 10;
		var expectedDirectionY = 0;
		
		assert.equal( directionXAfterTurnRight, expectedDirectionX, "After turn RIGHT direction by X is correct!" );
		assert.equal( directionYAfterTurnRight, expectedDirectionY, "After turn RIGHT direction by Y is correct!" );
	});

	test( "Check second turn RIGHT of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(20, 30);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;
		
		snake.turnDown();
		snake.turnRight();
		
		var directionXAfterTurnRight = snake.currentDirection.x;
		var directionYAfterTurnRight = snake.currentDirection.y;	
		
		snake.turnRight();
		
		var directionXAfterSecondTurnRight = snake.currentDirection.x;
		var directionYAfterSecondTurnRight = snake.currentDirection.y;	
		
		var hasDirectionXChanged = directionXAfterSecondTurnRight - directionXAfterTurnRight;
		var hasDirectionYChanged = directionYAfterSecondTurnRight - directionYAfterTurnRight;

		var expectedDirectionX = 10;
		var expectedDirectionY = 0;
		
		assert.equal( hasDirectionXChanged, 0, "After second turn RIGHT direction by X has no changing!" );
		assert.equal( hasDirectionYChanged, 0, "After second turn RIGHT direction by Y has no changing!" );
		
		assert.equal( directionXAfterSecondTurnRight, expectedDirectionX, "After second turn RIGHT direction by X is correct!" );
		assert.equal( directionYAfterSecondTurnRight, expectedDirectionY, "After second turn RIGHT direction by Y is correct!" );
	});
	
	test( "Check FULL ROTATION of the snake", function( assert ) { 
		var snake = new snakeGame.Snake(30, 30);
		var startDirectionX = snake.currentDirection.x;
		var startDirectionY = snake.currentDirection.y;
		
		snake.turnDown();
		
		var currentDirectionByX = snake.currentDirection.x;
		var currentDirectionByY = snake.currentDirection.y;
		
		var expectedDirectionX = 0;
		var expectedDirectionY = 10;
		
		assert.equal( currentDirectionByX, expectedDirectionX, "After first turn direction by X is correct!" );
		assert.equal( currentDirectionByY, expectedDirectionY, "After first turn direction by Y is correct!" );
		
		snake.turnRight();
		
		currentDirectionByX = snake.currentDirection.x;
		currentDirectionByY = snake.currentDirection.y;
		
		expectedDirectionX = 10;
		expectedDirectionY = 0;
		
		assert.equal( currentDirectionByX, expectedDirectionX, "After second turn direction by X is correct!" );
		assert.equal( currentDirectionByY, expectedDirectionY, "After second turn direction by Y is correct!" );
		
		snake.turnUp();
		
		currentDirectionByX = snake.currentDirection.x;
		currentDirectionByY = snake.currentDirection.y;
		
		expectedDirectionX = 0;
		expectedDirectionY = -10;
		
		assert.equal( currentDirectionByX, expectedDirectionX, "After third turn direction by X is correct!" );
		assert.equal( currentDirectionByY, expectedDirectionY, "After third turn direction by Y is correct!" );
		
		snake.turnLeft();
		
		currentDirectionByX = snake.currentDirection.x;
		currentDirectionByY = snake.currentDirection.y;
		
		expectedDirectionX = -10;
		expectedDirectionY = 0;
		
		assert.equal( currentDirectionByX, expectedDirectionX, "After fourth turn direction by X is correct!" );
		assert.equal( currentDirectionByY, expectedDirectionY, "After fourth turn direction by Y is correct!" );
		
		snake.turnDown();
		snake.turnLeft();
		snake.turnUp();
		snake.turnRight();
		
		currentDirectionByX = snake.currentDirection.x;
		currentDirectionByY = snake.currentDirection.y;
		
		expectedDirectionX = 10;
		expectedDirectionY = 0;
		
		assert.equal( currentDirectionByX, expectedDirectionX, "After another full rotation direction by X is correct!" );
		assert.equal( currentDirectionByY, expectedDirectionY, "After another full rotation direction by Y is correct!" );
	});

module( "Test class Food" );
	test( "Check if food is on the game field", function( assert ) { 
		var food = new snakeGame.Food(80, 80);
		var haveFood = food.coords;

		var expectedFoodX = 10 <= haveFood.x <= 70;
		var expectedFoodY = 10 <= haveFood.y <= 70;
	 
		assert.equal( true, expectedFoodX, "Food is on the field!" );
		assert.equal( true, expectedFoodY, "Food is on the field!" );
 	});
	


module( "Test coords" );
 	test( "Test coords*10", function( assert ) { 
		var newCoords = new snakeGame.Coords(10, 10);
		var result = newCoords.x;
	 
 	  assert.equal( result, 100, "coordinates are correct" );
	});
}());