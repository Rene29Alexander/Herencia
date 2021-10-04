using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Taxi taxi = new Taxi();
            MessageBox.Show(taxi.vehiculoMatricula = "ACS-0123");
            MessageBox.Show(taxi.numeroLicencia="ph_123");
            MessageBox.Show(taxi.vehiculoModelo = "Toyota corola");
            MessageBox.Show(taxi.vehiculoPotenciaCV="143");
            MessageBox.Show(taxi.getLicencia(321, "tiene licencia"));
            MessageBox.Show(taxi.getPotencia("toyota",123));
            
            
            MessageBox.Show(taxi.getMatricula());
            MessageBox.Show(taxi.TaxisRegion());
            MessageBox.Show(taxi.getMatricula());
            MessageBox.Show(taxi.vehiculoMatricula);
            MessageBox.Show(taxi.vehiculoModelo);
            


            Autobus autobus = new Autobus();
            MessageBox.Show(autobus.vehiculoMatricula = "BER-3210");
            MessageBox.Show(autobus.vehiculoLicencia="scdx123");
            MessageBox.Show(autobus.vehiculoModelo = "volvo per43");
            MessageBox.Show(autobus.vehiculoPotenciaCV="323");
            MessageBox.Show(autobus.vehiculoModelo);
            MessageBox.Show(autobus.vehiculoMatricula);
            MessageBox.Show(autobus.vehiculoModelo);
            MessageBox.Show(autobus.getmodelo());
            MessageBox.Show(autobus.ruta());
                
           
            


        }
    }
}
