using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    class FlatWhite : Kaffe, Imælk
    { /// <summary>
    ///  interfacet inplementeres sammen med pris hvorefter man, override virtual metoden Styrke og ændre den til mild.
    /// </summar >
    /// <returns></returns>
        public int MlMælk()
        {
            return  160;
        }

        public override int Pris()
        {
            return 45;
        }
        public override string Styrke()
        {
            return "mild";
        }
    }
}
