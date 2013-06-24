using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            //Task 1: - create side and ceiling walls to the game
            //Adding the both sides...
            for (int i = 0; i < WorldRows; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, 0)));
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1)));
            }
            //.. and the top border - can look better with another value of the symbol constant in UnderstructibleBlock
            for (int i = 0; i < WorldCols; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(0, i)));
            }

            /*
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);
            }
            */
            //Task 12: Test the Gift and GiftBlock classes by adding them through the AcademyPopcornMain.cs file.
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock;
                if (i == 7)
                {
                    currBlock = new ExplodingBlock(new MatrixCoords(startRow, i));
                }
                else if (i == endCol - 3)
                {
                    currBlock = new GiftBlock(new MatrixCoords(startRow, i));
                }
                else
                {
                    currBlock = new Block(new MatrixCoords(startRow, i));
                }
                engine.AddObject(currBlock);
            }
            
            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));
            engine.AddObject(theBall);
            
            // Task 7: Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            /*
            Ball theMeteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));
            engine.AddObject(theMeteoriteBall);
            */
            /*
            // Task 9: Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in AcademyPopcornMain.cs file
            
            Ball theUnstopableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), 
                new MatrixCoords(-1, 1));
            engine.AddObject(theUnstopableBall);

            for (int i = 2; i < WorldCols/2; i+=2)
            {
                engine.AddObject(new UnpassableBlock(new MatrixCoords(4, i)));
            }
            */

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);

            //Task 3 
            Racket theNewOneRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength + 1);
            engine.AddObject(theNewOneRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            //Testing ShootingRacketEngine
            //ShootingRacketEngine gameEngine = new ShootingRacketEngine(renderer, keyboard);             

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            //Task 13
            /*
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };
            */
            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}