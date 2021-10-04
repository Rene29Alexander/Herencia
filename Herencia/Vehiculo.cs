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
        public String vehiculoPotenciaCV { get; set; }
        public String vehiculoLicencia { get; set; }


     
        public virtual string getMatricula()
        {
            return "El color del vehiculo es: ";
        }
        public virtual string getmodelo()
        {
            return "La marca del vehiculo es: nissan sentra";
        }

        public int getPotencia()
        {
            return 243;
        }

       
        public string getPotencia(string marca, int potencia)
        {
            return "El vehiculo de marca"+ " " + marca +
                " tiene"+ " " + potencia +" " +"caballos";
        }



        public string getLicencia(int matricula, string licencia)
        {

            return "El auto tiene matriculas"+" " + matricula +
                " y el conductor "+" " + licencia;

        }
    }
}