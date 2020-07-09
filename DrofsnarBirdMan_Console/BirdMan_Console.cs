using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarBirdMan_Console
{
    class BirdMan_Console
    {
        public void Drofsnar()
        {
            string player = "Drofsnar";
            int sPoints = 5000;
            int sLives = 3;
            string interpolStart = $"{player} starts with {sPoints} points and {sLives} lives";
            Console.WriteLine(interpolStart);
            Console.ReadLine();
            
            GamePiece Bird = new GamePiece();
            Bird.PieceName = "Bird";
            Bird.PointValue = 10;

            GamePiece IcelandGull = new GamePiece();
            Bird.PieceName = "IcelandGull";
            IcelandGull.PointValue = 3000;

            GamePiece CrestedIbis = new GamePiece();
            CrestedIbis.PieceName = "CrestedIbis";
            Bird.PointValue = 100;

            GamePiece GreatKiskudee = new GamePiece();
            GreatKiskudee.PieceName = "GreatKiskudee";
            Bird.PointValue = 300;

            GamePiece RedCrossBill  = new GamePiece();
            RedCrossBill.PieceName = "Bird";
            Bird.PointValue = 500;

            GamePiece RedneckedPhalarope = new GamePiece();
            RedneckedPhalarope.PieceName = "RedneckedPhalarope";
            Bird.PointValue = 700;


           

        }
    }
}
