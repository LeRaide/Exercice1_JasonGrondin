using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_JasonGrondin.Model
{
    public class DePipe : De
    {
        public override int Brasser()
        {
            Random rnd = new Random();
            double Probability = 0.5;
            if (rnd.NextDouble() < Probability)
            {
                int ResultatDe = rnd.Next(1, 7);
                return ResultatDe;
            }
            else
            {
                int ResultatDe = rnd.Next(3, 7);
                return ResultatDe;
            }
        }
    }
}
