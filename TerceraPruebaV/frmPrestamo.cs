namespace TerceraPruebaV
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtxtValor.Clear();
            txtCuota.Clear();
            cboTipoBien.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor, cuota, interesAnual, interesMensual,saldo;
            


            if (treeView1.SelectedNode.Text == "")
            {
                MessageBox.Show("Seleccione una rama");
            }
            else if (cboTipoBien.Text == "")
            {
                MessageBox.Show("Seleccione un tipo de bien");
            }
            else if (mtxtValor.Text == "")
            {
                MessageBox.Show("Ingrese una cantidad");
            }
            else if (mtxtValor.Text == "0")
            {
                MessageBox.Show("El valor no puede ser igual a cero");
            }
            else if (cboPlazo.Text == "")
            {
                MessageBox.Show("Seleccione el plazo para pagar");
            }
            else
            {
                valor = Convert.ToDouble(mtxtValor.Text);

                if (treeView1.SelectedNode.Text.Equals("Vehiculo"))
                {
                    if (cboTipoBien.SelectedItem.Equals("Nuevo"))
                    {
                        if (valor > 5000 || valor < 25000)
                        {
                            if (cboPlazo.SelectedItem.Equals("48"))
                            {
                                interesAnual = valor * 0.15;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 4)) / 48;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                            else if (cboPlazo.SelectedItem.Equals("60"))
                            {
                                interesAnual = valor * 0.15;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 5)) / 60;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                            else if (cboPlazo.SelectedItem.Equals("72"))
                            {
                                interesAnual = valor * 0.15;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 6)) / 72;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un valor entre 5000 y 250000");
                        }
                    }
                    else if (cboTipoBien.SelectedItem.Equals("Usado"))
                    {
                        if (valor > 5000 || valor < 25000)
                        {
                            if (cboPlazo.SelectedItem.Equals("48"))
                            {
                                interesAnual = valor * 0.18;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 4)) / 48;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                            else if (cboPlazo.SelectedItem.Equals("60"))
                            {
                                interesAnual = valor * 0.18;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 5)) / 60;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                            else if (cboPlazo.SelectedItem.Equals("72"))
                            {
                                interesAnual = valor * 0.18;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 6)) / 72;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un valor entre 5000 y 250000");
                        }
                    }                    
                }

                else if (treeView1.SelectedNode.Text.Equals("Vivienda"))
                {
                    if (cboTipoBien.SelectedItem.Equals("Nuevo"))
                    {
                        if (valor > 8000 || valor < 1000000)
                        {
                            if (cboPlazo.SelectedItem.Equals("120"))
                            {
                                interesAnual = valor * 0.15;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 10)) / 120;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                            else if (cboPlazo.SelectedItem.Equals("180"))
                            {
                                interesAnual = valor * 0.15;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 15)) / 180;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                            else if (cboPlazo.SelectedItem.Equals("240"))
                            {
                                interesAnual = valor * 0.15;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 20)) / 240;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un valor entre 5000 y 250000");
                        }
                    }
                    else if (cboTipoBien.SelectedItem.Equals("Usado"))
                    {
                        if (valor > 5000 || valor < 25000)
                        {
                            if (cboPlazo.SelectedItem.Equals("120"))
                            {
                                interesAnual = valor * 0.18;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 10)) / 120;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                            else if (cboPlazo.SelectedItem.Equals("60"))
                            {
                                interesAnual = valor * 0.18;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 15)) / 180;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                            else if (cboPlazo.SelectedItem.Equals("240"))
                            {
                                interesAnual = valor * 0.18;
                                interesMensual = interesAnual / 12;
                                cuota = (valor + (interesAnual * 20)) / 240;
                                saldo = valor - cuota;

                                txtCuota.Text = cuota.ToString();
                                txtInteres.Text = interesAnual.ToString();
                                txtSaldo.Text = saldo.ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un valor entre 8000 y 1000000");
                        }
                    }
                }
            }
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            txtCuota.Enabled = false;
            txtInteres.Enabled = false;
            txtSaldo.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCuota.Text == "")
            {
                MessageBox.Show("Calcular cuota para avanzar");
            }
            else
            {
                

                
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                }

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                
                row.Cells[0].Value = mtxtValor.Text;
                row.Cells[1].Value = txtInteres.Text;
                row.Cells[2].Value = txtCuota.Text;
                row.Cells[3].Value = txtSaldo.Text; 
                

                dataGridView1.Rows.Add(row);
                txtInteres.Text = "";
                mtxtValor.Text = "";
                txtSaldo.Text = "";
                cboTipoBien.Focus();





            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

            }

            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

            row.Cells[0].Value = "";
            row.Cells[1].Value = "";
            row.Cells[2].Value = "";
            row.Cells[3].Value = "";


            dataGridView1.Rows.Add(row);
        }
    }
}