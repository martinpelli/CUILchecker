using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paractico1_Ejercicio8_TDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            string cuil = textBox.Text;

            if (cuil.Length == 11)
            {
                string type = cuil.Substring(0, 2);
                switch (type)
                {
                    case "20":
                        type = "Es Hombre";
                        break;
                    case "27":
                        type = "Es Mujer";
                        break;
                    case "30":
                        type = "Es Empresa";
                        break;
                    default:
                        invalidCuil();
                        return;
                }
                int z = calculateZ(cuil.Substring(0,10));
                if (z == int.Parse(cuil[10].ToString()))
                {
                    MessageBox.Show("El CUIT/CUIL es válido");
                }
                else
                {
                    invalidCuil();
                }
            }
            else
            {
                invalidCuil();
            }
        }


        private void invalidCuil()
        {
            MessageBox.Show("El CUIT/CUIL es inválido");
        }


        private int calculateZ(string Body)
        {
            const string defaultNumbers = "5432765432";
            int total = 0;
            for (int i = 0; i<10; i++)
            {
                int result = Int32.Parse(Body[i].ToString()) * Int32.Parse(defaultNumbers[i].ToString());
                total += result; 
            }
            int resto = total - ((total/11) * 11);
            return 11 - resto;
        }
    }
}
