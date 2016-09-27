namespace ConvertidorAcordoba
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
            this.TxtConversion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUSDollars = new System.Windows.Forms.TextBox();
            this.txtNicCordobas = new System.Windows.Forms.TextBox();
            this.txtTaca = new System.Windows.Forms.Label();
            this.txtTacaDecambio = new System.Windows.Forms.TextBox();
            this.ConversionCordobas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txCordobas = new System.Windows.Forms.TextBox();
            this.txTaca = new System.Windows.Forms.TextBox();
            this.txDollars = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtConversion
            // 
            this.TxtConversion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtConversion.Location = new System.Drawing.Point(107, 229);
            this.TxtConversion.Name = "TxtConversion";
            this.TxtConversion.Size = new System.Drawing.Size(111, 23);
            this.TxtConversion.TabIndex = 0;
            this.TxtConversion.Text = "Convertion Dollars";
            this.TxtConversion.UseVisualStyleBackColor = false;
            this.TxtConversion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "US Dollars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nicaragua Cordobas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUSDollars
            // 
            this.txtUSDollars.Location = new System.Drawing.Point(118, 76);
            this.txtUSDollars.Name = "txtUSDollars";
            this.txtUSDollars.Size = new System.Drawing.Size(100, 20);
            this.txtUSDollars.TabIndex = 3;
            this.txtUSDollars.TextChanged += new System.EventHandler(this.txtUSDollars_TextChanged);
            this.txtUSDollars.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUSDollars_KeyPress);
            // 
            // txtNicCordobas
            // 
            this.txtNicCordobas.Location = new System.Drawing.Point(118, 175);
            this.txtNicCordobas.Name = "txtNicCordobas";
            this.txtNicCordobas.Size = new System.Drawing.Size(100, 20);
            this.txtNicCordobas.TabIndex = 4;
            this.txtNicCordobas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTaca
            // 
            this.txtTaca.AutoSize = true;
            this.txtTaca.Location = new System.Drawing.Point(12, 128);
            this.txtTaca.Name = "txtTaca";
            this.txtTaca.Size = new System.Drawing.Size(81, 13);
            this.txtTaca.TabIndex = 5;
            this.txtTaca.Text = "Exchange Rate";
            // 
            // txtTacaDecambio
            // 
            this.txtTacaDecambio.Location = new System.Drawing.Point(118, 125);
            this.txtTacaDecambio.Name = "txtTacaDecambio";
            this.txtTacaDecambio.Size = new System.Drawing.Size(100, 20);
            this.txtTacaDecambio.TabIndex = 6;
            // 
            // ConversionCordobas
            // 
            this.ConversionCordobas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConversionCordobas.Location = new System.Drawing.Point(558, 229);
            this.ConversionCordobas.Name = "ConversionCordobas";
            this.ConversionCordobas.Size = new System.Drawing.Size(121, 23);
            this.ConversionCordobas.TabIndex = 7;
            this.ConversionCordobas.Text = "Convertion Cordobas";
            this.ConversionCordobas.UseVisualStyleBackColor = false;
            this.ConversionCordobas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nicaragua Cordobas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Exchange Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "US Dollars";
            // 
            // txCordobas
            // 
            this.txCordobas.Location = new System.Drawing.Point(560, 79);
            this.txCordobas.Name = "txCordobas";
            this.txCordobas.Size = new System.Drawing.Size(100, 20);
            this.txCordobas.TabIndex = 11;
            // 
            // txTaca
            // 
            this.txTaca.Location = new System.Drawing.Point(560, 128);
            this.txTaca.Name = "txTaca";
            this.txTaca.Size = new System.Drawing.Size(100, 20);
            this.txTaca.TabIndex = 12;
            // 
            // txDollars
            // 
            this.txDollars.Location = new System.Drawing.Point(558, 179);
            this.txDollars.Name = "txDollars";
            this.txDollars.Size = new System.Drawing.Size(102, 20);
            this.txDollars.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Conversion from Dollars to Corbs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Conversion from Corbs to Dollars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(711, 319);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txDollars);
            this.Controls.Add(this.txTaca);
            this.Controls.Add(this.txCordobas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConversionCordobas);
            this.Controls.Add(this.txtTacaDecambio);
            this.Controls.Add(this.txtTaca);
            this.Controls.Add(this.txtNicCordobas);
            this.Controls.Add(this.txtUSDollars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtConversion);
            this.Name = "Form1";
            this.Text = "Convertion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TxtConversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUSDollars;
        private System.Windows.Forms.TextBox txtNicCordobas;
        private System.Windows.Forms.Label txtTaca;
        private System.Windows.Forms.TextBox txtTacaDecambio;
        private System.Windows.Forms.Button ConversionCordobas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCordobas;
        private System.Windows.Forms.TextBox txTaca;
        private System.Windows.Forms.TextBox txDollars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

