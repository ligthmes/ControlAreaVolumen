namespace ControlAreaVolumen
{
    partial class frmControlAreaVolumen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControlAreaVolumen.Properties.Resources.banner_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(73, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 222);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(675, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de area y volumen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(361, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diametro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altura";
            // 
            // txtDiametro
            // 
            this.txtDiametro.Location = new System.Drawing.Point(361, 425);
            this.txtDiametro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(141, 31);
            this.txtDiametro.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(73, 425);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(141, 31);
            this.txtAltura.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(361, 530);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 38);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(626, 343);
            this.txtR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(354, 256);
            this.txtR.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(635, 630);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 38);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(873, 630);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 38);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmControlAreaVolumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1116, 697);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtDiametro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmControlAreaVolumen";
            this.Text = "Control de área y volumen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDiametro;
        private TextBox txtAltura;
        private Button btnCalcular;
        private TextBox txtR;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}