namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 24;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;


            // 1. The AcademyPopcorn class contains an IndestructibleBlock class.
            //    Use it to create side and ceiling walls to the game. You can ONLY edit the AcademyPopcornMain.cs file.
            for (int i = startRow - startCol; i < WorldRows; i++)
            {
                IndestructibleBlock topWall = new IndestructibleBlock(new MatrixCoords(1, i), '—');
                IndestructibleBlock leftSideWall = new IndestructibleBlock(new MatrixCoords(i, startCol - 1));
                IndestructibleBlock righSideWall = new IndestructibleBlock(new MatrixCoords(i, endCol));

                engine.AddObject(topWall);
                engine.AddObject(leftSideWall);
                engine.AddObject(righSideWall);
            }

            // Currenet blocks
            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);
            }

            // Unpassable blocks
            //for (int i = startCol; i < endCol; i++)
            //{
            //    UnpassableBlock unpassBlock = new UnpassableBlock(new MatrixCoords(startRow, i));
            //    engine.AddObject(unpassBlock);
            //}

            // Exploding blocks
            //for (int i = startCol; i < endCol ; i++)
            //{
            //    ExplodingBlock expBlock = new ExplodingBlock(new MatrixCoords(startRow, i));
            //    engine.AddObject(expBlock);
            //}

            // Gift blocks
            //for (int i = startCol; i < endCol; i++)
            //{
            //    GiftBlock giftBlock = new GiftBlock(new MatrixCoords(startRow, i));
            //    engine.AddObject(giftBlock);
            //}

            // Origianl ball
            //Ball theBall = new Ball(new MatrixCoords(WorldRows - 2, WorldCols / 2),
            //    new MatrixCoords(-1, -1));
            //engine.AddObject(theBall);

            // 7. Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            MeteoriteBall theMeteoriteBall = new MeteoriteBall(new MatrixCoords(WorldCols - 2, WorldRows / 2),
                new MatrixCoords(-1, 1), 3);
            engine.AddObject(theMeteoriteBall);

            // 9. Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in AcademyPopcornMain.cs file.
            //UnstoppableBall theUnstoppableBall = new UnstoppableBall(new MatrixCoords(WorldCols - 2, WorldRows / 2),
            //    new MatrixCoords(-1, -1));
            //engine.AddObject(theUnstoppableBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);

            // Trail
            //TrailObject trail = new TrailObject(new MatrixCoords(10, 3), 10);
            //engine.AddObject(trail);
        }

        static void Main()
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 200);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}
