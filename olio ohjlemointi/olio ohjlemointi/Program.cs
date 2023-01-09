using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_ohjlemointi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koira koira1 = new Koira("Rekku", "Mopsi", 2); // luodaan uusi koira olio/instanssi


            koira1.HaeTiedot();

            Koira koira2 = new Koira("Ali", "bulldog", 5    );


            koira2.HaeTiedot();

            koira1.Hauku();
            koira2.Hauku();
        }
    }
}
