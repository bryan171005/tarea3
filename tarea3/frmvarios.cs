using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp2025C
{
    public partial class frmvarios : Form 
    {
        public frmvarios()
        {
            InitializeComponent();
        }

        private void frmvarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpNacimiento.Value;
            DateTime calculo = dtpcalculo.Value;

            int edad = calculo.Year - nacimiento.Year;
            int mes = calculo.Month - nacimiento.Month;
            int dia = calculo.Day - nacimiento.Day;

            if (mes < 0 || (mes == 0 && dia < 0))
            {
                edad--;
                mes += 12; 
            }

           
            if (dia < 0)
            {
                mes--; 
                dia += DateTime.DaysInMonth(calculo.Year, calculo.Month - 1); 
            }
            MessageBox.Show("años" + edad + "meses" + mes + "dias" + dia, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpcalculo.Enabled = true;
            dtpcalculo.MinDate = dtpNacimiento.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fecha = textBox1.Text.Substring(4, 6);
            String sexo = textBox1.Text.Substring(10, 1);
            String estadoN= textBox1.Text.Substring(11,2);
            string estadoNombre = "";

            switch (estadoN)
            {
                case "AS": estadoNombre = "Aguascalientes"; break;
                case "BC": estadoNombre = "Baja California"; break;
                case "BS": estadoNombre = "Baja California Sur"; break;
                case "CC": estadoNombre = "Campeche"; break;
                case "CS": estadoNombre = "Chiapas"; break;
                case "CH": estadoNombre = "Chihuahua"; break;
                case "CL": estadoNombre = "Coahuila"; break;
                case "CM": estadoNombre = "Colima"; break;
                case "DF": estadoNombre = "Ciudad de México"; break;
                case "DG": estadoNombre = "Durango"; break;
                case "GT": estadoNombre = "Guanajuato"; break;
                case "GR": estadoNombre = "Guerrero"; break;
                case "HG": estadoNombre = "Hidalgo"; break;
                case "JC": estadoNombre = "Jalisco"; break;
                case "MC": estadoNombre = "México"; break;
                case "MN": estadoNombre = "Michoacán"; break;
                case "MS": estadoNombre = "Morelos"; break;
                case "NT": estadoNombre = "Nayarit"; break;
                case "NL": estadoNombre = "Nuevo León"; break;
                case "OC": estadoNombre = "Oaxaca"; break;
                case "PL": estadoNombre = "Puebla"; break;
                case "QT": estadoNombre = "Querétaro"; break;
                case "QR": estadoNombre = "Quintana Roo"; break;
                case "SP": estadoNombre = "San Luis Potosí"; break;
                case "SL": estadoNombre = "Sinaloa"; break;
                case "SR": estadoNombre = "Sonora"; break;
                case "TC": estadoNombre = "Tabasco"; break;
                case "TS": estadoNombre = "Tamaulipas"; break;
                case "TL": estadoNombre = "Tlaxcala"; break;
                case "VZ": estadoNombre = "Veracruz"; break;
                case "YN": estadoNombre = "Yucatán"; break;
                case "ZS": estadoNombre = "Zacatecas"; break;
                case "NE": estadoNombre = "Nacido en el extranjero"; break;
                default: estadoNombre = "Estado no reconocido"; break;
            }
            string genero = "";

            switch (sexo)
            {
                case "H": genero = "Hombre"; break;
                case "M": genero = "Mujer"; break;
                default: genero = "No identificado"; break;
            }

            MessageBox.Show("Fecha de nacimiento"+fecha+"Estado de nacimiento: "+estadoNombre+"Sexo"+genero);
        }

    }
}
