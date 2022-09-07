using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_JasonGrondin.Model
{
    public class DeNormal : De
    {
        public override int Brasser()
        {
            Random rnd = new Random();
            int ResultatDe = rnd.Next(1, 7);
            return ResultatDe;
        }
    }
}
