﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Autobus:Vehiculo.Vehiculo

    {
        public Autobus()
        { }
        
        public int numeroPlazas { get; set; }


        
        public virtual string ruta()
        {
            return "La ruta del autobus es de San Miguel a San Salvador";
        }

        //metodo sobreescrito
        public override string getmodelo()
        {
            
            return "ferrari La ferrari";
        }

        public string getAutobusInfo()
        {
            return "vehiculoMatricula: " + vehiculoMatricula  + "vehiculoModelo" + vehiculoModelo + "vehiculoPotenciaCV" + vehiculoPotenciaCV + "vehiculoLicencia" + vehiculoLicencia;
        }
    }
}
