namespace Calculo_de_Idade_de_uma_pessoa
{
    partial class Form1
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
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblDiasdevida = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblHorasdevida = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblDiasvida = new System.Windows.Forms.Label();
            this.lblHorasvida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(12, 30);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(55, 15);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = " Idade :\r\n";
            this.lblIdade.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(87, 30);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(41, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // lblDiasdevida
            // 
            this.lblDiasdevida.AutoSize = true;
            this.lblDiasdevida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasdevida.Location = new System.Drawing.Point(108, 75);
            this.lblDiasdevida.Name = "lblDiasdevida";
            this.lblDiasdevida.Size = new System.Drawing.Size(0, 15);
            this.lblDiasdevida.TabIndex = 2;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(18, 65);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(90, 15);
            this.lblDias.TabIndex = 3;
            this.lblDias.Text = "Dias de vida:";
            this.lblDias.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(18, 90);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(99, 15);
            this.lblHoras.TabIndex = 4;
            this.lblHoras.Text = "Horas de vida:";
            // 
            // lblHorasdevida
            // 
            this.lblHorasdevida.AutoSize = true;
            this.lblHorasdevida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasdevida.Location = new System.Drawing.Point(108, 103);
            this.lblHorasdevida.Name = "lblHorasdevida";
            this.lblHorasdevida.Size = new System.Drawing.Size(0, 15);
            this.lblHorasdevida.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(354, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 34);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblDiasvida
            // 
            this.lblDiasvida.AutoSize = true;
            this.lblDiasvida.Location = new System.Drawing.Point(114, 67);
            this.lblDiasvida.Name = "lblDiasvida";
            this.lblDiasvida.Size = new System.Drawing.Size(25, 13);
            this.lblDiasvida.TabIndex = 7;
            this.lblDiasvida.Text = "------";
            this.lblDiasvida.Click += new System.EventHandler(this.lblDiasvida_Click);
            // 
            // lblHorasvida
            // 
            this.lblHorasvida.AutoSize = true;
            this.lblHorasvida.Location = new System.Drawing.Point(123, 92);
            this.lblHorasvida.Name = "lblHorasvida";
            this.lblHorasvida.Size = new System.Drawing.Size(22, 13);
            this.lblHorasvida.TabIndex = 8;
            this.lblHorasvida.Text = "-----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(471, 262);
            this.Controls.Add(this.lblHorasvida);
            this.Controls.Add(this.lblDiasvida);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblHorasdevida);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblDiasdevida);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Name = "Form1";
            this.Text = "Dias e Horas de vida";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblDiasdevida;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblHorasdevida;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDiasvida;
        private System.Windows.Forms.Label lblHorasvida;
    }
}

