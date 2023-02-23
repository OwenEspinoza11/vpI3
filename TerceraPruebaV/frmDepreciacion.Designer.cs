namespace TerceraPruebaV
{
    partial class frmDepreciacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Vehiculo");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Edificio");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Mobiliario");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Depreciacion", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mtxtValor = new System.Windows.Forms.MaskedTextBox();
            this.txtDepreciacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Vehiculo";
            treeNode13.Text = "Vehiculo";
            treeNode14.Name = "Edificio";
            treeNode14.Text = "Edificio";
            treeNode15.Name = "Mobiliario";
            treeNode15.Text = "Mobiliario";
            treeNode16.Name = "Depreciacion";
            treeNode16.Text = "Depreciacion";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(121, 426);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Depreciacion";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(213, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(294, 244);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(375, 244);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mtxtValor
            // 
            this.mtxtValor.Location = new System.Drawing.Point(309, 78);
            this.mtxtValor.Name = "mtxtValor";
            this.mtxtValor.Size = new System.Drawing.Size(100, 23);
            this.mtxtValor.TabIndex = 6;
            // 
            // txtDepreciacion
            // 
            this.txtDepreciacion.Location = new System.Drawing.Point(309, 155);
            this.txtDepreciacion.Name = "txtDepreciacion";
            this.txtDepreciacion.Size = new System.Drawing.Size(100, 23);
            this.txtDepreciacion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(333, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Depreciacion";
            // 
            // frmDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepreciacion);
            this.Controls.Add(this.mtxtValor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmDepreciacion";
            this.Text = "Depreciacion";
            this.Load += new System.EventHandler(this.frmDepreciacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private Label label2;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private MaskedTextBox mtxtValor;
        private TextBox txtDepreciacion;
        private Label label3;
    }
}