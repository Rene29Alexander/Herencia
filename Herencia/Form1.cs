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
            taxi.vehiculoMatricula = "ACS-0123";
            taxi.numeroLicencia = 12345;
            taxi.vehiculoModelo = "Toyota corola";
            taxi.vehiculoPotenciaCV = 121;
            taxi.vehiculoLicencia = true;
            
            MessageBox.Show(taxi.getMatricula());
            MessageBox.Show(taxi.TaxisRegion());
            MessageBox.Show(taxi.getMatricula());
            MessageBox.Show(taxi.vehiculoMatricula);
            MessageBox.Show(taxi.vehiculoModelo);
            


            Autobus autobus = new Autobus();
            autobus.vehiculoMatricula = "BER-3210";
            autobus.vehiculoLicencia = false;
            autobus.vehiculoModelo = "volvo per43";
            autobus.vehiculoPotenciaCV = 93;
            MessageBox.Show(autobus.vehiculoModelo);
            MessageBox.Show(autobus.vehiculoMatricula);
            MessageBox.Show(autobus.vehiculoModelo);
            MessageBox.Show(autobus.getmodelo());
            MessageBox.Show(autobus.ruta());
                
           
            


        }
    }
}
