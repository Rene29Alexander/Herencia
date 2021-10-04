using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Taxi: Vehiculo.Vehiculo
    {
        public string numeroLicencia { get; set; }

        public string TaxisRegion()
        {
            return "La region del taxi es san miguel";
        }

        public override string getMatricula()
        {
            
            return "tiene licencia de taxista";

        }
        




    }
}
