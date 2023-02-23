using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerceraPruebaV
{
    public partial class frmDepreciacion : Form
    {
        public frmDepreciacion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtValor.Clear();
            txtDepreciacion.Clear();
            mtxtValor.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor, depreciacion;
            if (treeView1.SelectedNode.Text == "")
            {
                MessageBox.Show("Seleccione una rama");
            }
            else if (mtxtValor.Text == "" || mtxtValor.Text == "0")
            {
                MessageBox.Show("Ingrese un valor que sea mayor a cero");
            }
            else
            {
                valor = Convert.ToDouble(mtxtValor.Text);

                if (treeView1.SelectedNode.Text.Equals("Vehiculo"))
                {
                    if (valor > 5000 || valor < 250000)
                    {
                        depreciacion = valor / 5;

                        txtDepreciacion.Text = depreciacion.ToString();
                    }


                }
                else if (treeView1.SelectedNode.Text.Equals("Edificio"))
                {
                    if (valor > 10000 || valor < 3000000)
                    {
                        depreciacion = valor / 20;

                        txtDepreciacion.Text = depreciacion.ToString();
                    }


                }
                else if (treeView1.SelectedNode.Text.Equals("Mobiliario"))
                {
                    if (valor > 20 || valor < 10000)
                    {
                        depreciacion = valor / 2;

                        txtDepreciacion.Text = depreciacion.ToString();
                    }


                }
            }
        }

        private void frmDepreciacion_Load(object sender, EventArgs e)
        {
            txtDepreciacion.Enabled= false;
        }
    }
}
