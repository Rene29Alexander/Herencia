using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    
    class Vehiculo
    {
        
        public string vehiculoMatricula { get; set; }
        public string vehiculoModelo { get; set; }
        public int vehiculoPotenciaCV { get; set; }
        public string vehiculoLicencia { get; set; }
     


     
        public virtual string getMatricula()
        {
            return "El color del vehiculo es: ";
        }
        public virtual string getmodelo()
        {
            return "La marca del vehiculo es: ";
        }

        public int getPotencia()
        {
            return 243;
        }

       
        public string getPotencia(string marca, int potencia)
        {
            return "El vehiculo de marca" + marca +
                " tiene" + potencia + "caballos";
        }


  
        public  string Licencia()
        {

            string licencia = null;
            return "El auto tiene matriculas" + vehiculoMatricula +
                " y el conductor " + licencia;

        }
    }
}