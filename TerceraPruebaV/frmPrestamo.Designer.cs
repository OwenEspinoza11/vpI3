namespace TerceraPruebaV
{
    partial class frmPrestamo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vehiculo");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Vivienda");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Prestamo", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoBien = new System.Windows.Forms.ComboBox();
            this.mtxtValor = new System.Windows.Forms.MaskedTextBox();
            this.cboPlazo = new System.Windows.Forms.ComboBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrimeraCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Vehiculo";
            treeNode1.Text = "Vehiculo";
            treeNode2.Name = "Vivienda";
            treeNode2.Text = "Vivienda";
            treeNode3.Name = "Prestamo";
            treeNode3.Text = "Prestamo";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(121, 426);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(365, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prestamos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo bien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plazo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cuota";
            // 
            // cboTipoBien
            // 
            this.cboTipoBien.FormattingEnabled = true;
            this.cboTipoBien.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.cboTipoBien.Location = new System.Drawing.Point(274, 76);
            this.cboTipoBien.Name = "cboTipoBien";
            this.cboTipoBien.Size = new System.Drawing.Size(121, 23);
            this.cboTipoBien.TabIndex = 6;
            // 
            // mtxtValor
            // 
            this.mtxtValor.Location = new System.Drawing.Point(274, 126);
            this.mtxtValor.Mask = "0000000";
            this.mtxtValor.Name = "mtxtValor";
            this.mtxtValor.Size = new System.Drawing.Size(100, 23);
            this.mtxtValor.TabIndex = 7;
            // 
            // cboPlazo
            // 
            this.cboPlazo.FormattingEnabled = true;
            this.cboPlazo.Items.AddRange(new object[] {
            "48",
            "60",
            "72",
            "120",
            "180",
            "240"});
            this.cboPlazo.Location = new System.Drawing.Point(274, 177);
            this.cboPlazo.Name = "cboPlazo";
            this.cboPlazo.Size = new System.Drawing.Size(61, 23);
            this.cboPlazo.TabIndex = 8;
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(274, 231);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(100, 23);
            this.txtCuota.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(449, 76);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(449, 125);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(449, 177);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(449, 231);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrimeraCuota,
            this.Interes,
            this.Cuota,
            this.Saldo});
            this.dataGridView1.Location = new System.Drawing.Point(155, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // PrimeraCuota
            // 
            this.PrimeraCuota.HeaderText = "Primera cuota";
            this.PrimeraCuota.Name = "PrimeraCuota";
            // 
            // Interes
            // 
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            // 
            // Cuota
            // 
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(668, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(592, 76);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(100, 23);
            this.txtInteres.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Interes";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(592, 148);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 23);
            this.txtSaldo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Saldo";
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.cboPlazo);
            this.Controls.Add(this.mtxtValor);
            this.Controls.Add(this.cboTipoBien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmPrestamo";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboTipoBien;
        private MaskedTextBox mtxtValor;
        private ComboBox cboPlazo;
        private TextBox txtCuota;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Button btnBorrar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PrimeraCuota;
        private DataGridViewTextBoxColumn Interes;
        private DataGridViewTextBoxColumn Cuota;
        private DataGridViewTextBoxColumn Saldo;
        private Button btnSalir;
        private TextBox txtInteres;
        private Label label6;
        private TextBox txtSaldo;
        private Label label7;
    }
}