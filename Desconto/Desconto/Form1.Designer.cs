namespace Desconto
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValordaCompra = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblValortotal = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(232, 227);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValordaCompra
            // 
            this.lblValordaCompra.AutoSize = true;
            this.lblValordaCompra.Location = new System.Drawing.Point(31, 30);
            this.lblValordaCompra.Name = "lblValordaCompra";
            this.lblValordaCompra.Size = new System.Drawing.Size(108, 13);
            this.lblValordaCompra.TabIndex = 1;
            this.lblValordaCompra.Text = "Valor da Compra :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(31, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total :";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(31, 55);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(82, 13);
            this.lblDesconto.TabIndex = 3;
            this.lblDesconto.Text = "Desconto % :";
            // 
            // lblValortotal
            // 
            this.lblValortotal.AutoSize = true;
            this.lblValortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValortotal.Location = new System.Drawing.Point(28, 187);
            this.lblValortotal.Name = "lblValortotal";
            this.lblValortotal.Size = new System.Drawing.Size(191, 33);
            this.lblValortotal.TabIndex = 4;
            this.lblValortotal.Text = "----------------";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(145, 29);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(145, 55);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 262);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValortotal);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblValordaCompra);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValordaCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblValortotal;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDesconto;
    }
}

