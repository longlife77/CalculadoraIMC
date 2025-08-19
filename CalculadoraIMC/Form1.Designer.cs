namespace CalculadoraIMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPeso = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCalculeSeuIMC = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.lblSaudavel = new System.Windows.Forms.Label();
            this.txbIMC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(95, 83);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso:";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(135, 80);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 20);
            this.txbPeso.TabIndex = 1;
            this.txbPeso.TextChanged += new System.EventHandler(this.txbPeso_TextChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAltura.Location = new System.Drawing.Point(92, 118);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(135, 118);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCalcular.Location = new System.Drawing.Point(128, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 51);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCalculeSeuIMC
            // 
            this.lblCalculeSeuIMC.AutoSize = true;
            this.lblCalculeSeuIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculeSeuIMC.Location = new System.Drawing.Point(108, 22);
            this.lblCalculeSeuIMC.Name = "lblCalculeSeuIMC";
            this.lblCalculeSeuIMC.Size = new System.Drawing.Size(165, 24);
            this.lblCalculeSeuIMC.TabIndex = 5;
            this.lblCalculeSeuIMC.Text = "Calcule Seu IMC";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(95, 216);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(26, 13);
            this.lblImc.TabIndex = 6;
            this.lblImc.Text = "IMC";
            // 
            // lblSaudavel
            // 
            this.lblSaudavel.AutoSize = true;
            this.lblSaudavel.ForeColor = System.Drawing.Color.Black;
            this.lblSaudavel.Location = new System.Drawing.Point(96, 252);
            this.lblSaudavel.Name = "lblSaudavel";
            this.lblSaudavel.Size = new System.Drawing.Size(0, 13);
            this.lblSaudavel.TabIndex = 7;
            // 
            // txbIMC
            // 
            this.txbIMC.Location = new System.Drawing.Point(135, 212);
            this.txbIMC.Name = "txbIMC";
            this.txbIMC.Size = new System.Drawing.Size(100, 20);
            this.txbIMC.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbIMC);
            this.Controls.Add(this.lblSaudavel);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.lblCalculeSeuIMC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.lblPeso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCalculeSeuIMC;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label lblSaudavel;
        private System.Windows.Forms.TextBox txbIMC;
    }
}

