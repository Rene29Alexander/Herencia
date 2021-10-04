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
            taxi.vehiculoLicencia = "2346";
            
            MessageBox.Show(taxi.getMatricula());
            MessageBox.Show(taxi.TaxisRegion());
            MessageBox.Show(taxi.getMatricula());
            MessageBox.Show(taxi.vehiculoMatricula);
            MessageBox.Show(taxi.vehiculoModelo);
            


            Autobus autobus = new Autobus();
            autobus.vehiculoMatricula = "BER-3210";
            autobus.vehiculoLicencia = "6754";
            autobus.vehiculoModelo = "volvo per43";
            autobus.vehiculoPotenciaCV = 93;
            MessageBox.Show(autobus.vehiculoModelo);
            MessageBox.Show(autobus.vehiculoMatricula);
            MessageBox.Show(autobus.vehiculoModelo);
            MessageBox.Show(autobus.getmodelo());
            MessageBox.Show(autobus.ruta());
                

        }

        private void btn_Click(object sender, EventArgs e)
        { 
            Taxi taxi = new Taxi();
            taxi.vehiculoMatricula = vehiculoMatriculaTaxi.Text;
            taxi.numeroLicencia = Convert.ToInt32(numeroLicencia.Text);
            taxi.vehiculoModelo = vehiculoModeloTaxi.Text;
            taxi.vehiculoPotenciaCV = Convert.ToInt32(vehiculoPotenciaCVTaxi.Text);
            taxi.vehiculoLicencia = vehiculoLicenciaTaxi.Text;


            Autobus autobus = new Autobus();
            autobus.vehiculoMatricula = vehiculoMatriculaAutobus.Text;
            autobus.vehiculoLicencia = vehiculoLicenciaAutobus.Text;
            autobus.vehiculoModelo = vehiculoModeloAutobus.Text;
            autobus.vehiculoPotenciaCV = Convert.ToInt32(vehiculoPotenciaCVAutobus.Text);

            lstHerenciaInfo.Items.Add("Mediante constructor vacío: " + taxi.getTaxiInfo());
            lstHerenciaInfo.Items.Add("Mediante constructor vacío: " + autobus.getAutobusInfo());

        }
    }
}
