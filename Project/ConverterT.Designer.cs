namespace Project
{
    partial class ConverterT
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
            this.btnCon = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCe = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.Centi = new System.Windows.Forms.Label();
            this.Meter = new System.Windows.Forms.Label();
            this.btnCeToF = new System.Windows.Forms.Button();
            this.btnFToCe = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.DarkGray;
            this.btnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCon.Location = new System.Drawing.Point(547, 171);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(136, 45);
            this.btnCon.TabIndex = 29;
            this.btnCon.Text = "Convert";
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Location = new System.Drawing.Point(567, 368);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 47);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCe
            // 
            this.txtCe.Location = new System.Drawing.Point(169, 218);
            this.txtCe.Name = "txtCe";
            this.txtCe.Size = new System.Drawing.Size(162, 20);
            this.txtCe.TabIndex = 27;
            this.txtCe.TextChanged += new System.EventHandler(this.txtCe_TextChanged);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(169, 130);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(162, 20);
            this.txtF.TabIndex = 26;
            this.txtF.TextChanged += new System.EventHandler(this.txtF_TextChanged);
            // 
            // Centi
            // 
            this.Centi.AutoSize = true;
            this.Centi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Centi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Centi.Location = new System.Drawing.Point(43, 218);
            this.Centi.Name = "Centi";
            this.Centi.Size = new System.Drawing.Size(71, 24);
            this.Centi.TabIndex = 25;
            this.Centi.Text = "Celsius";
            // 
            // Meter
            // 
            this.Meter.AutoSize = true;
            this.Meter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Meter.Location = new System.Drawing.Point(43, 130);
            this.Meter.Name = "Meter";
            this.Meter.Size = new System.Drawing.Size(101, 24);
            this.Meter.TabIndex = 24;
            this.Meter.Text = "Fahrenheit";
            // 
            // btnCeToF
            // 
            this.btnCeToF.BackColor = System.Drawing.Color.DarkGray;
            this.btnCeToF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCeToF.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCeToF.Location = new System.Drawing.Point(391, 210);
            this.btnCeToF.Name = "btnCeToF";
            this.btnCeToF.Size = new System.Drawing.Size(136, 61);
            this.btnCeToF.TabIndex = 23;
            this.btnCeToF.Text = "Celsius To Fahrenheit";
            this.btnCeToF.UseVisualStyleBackColor = false;
            this.btnCeToF.Click += new System.EventHandler(this.btnCeToF_Click);
            // 
            // btnFToCe
            // 
            this.btnFToCe.BackColor = System.Drawing.Color.DarkGray;
            this.btnFToCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFToCe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFToCe.Location = new System.Drawing.Point(391, 117);
            this.btnFToCe.Name = "btnFToCe";
            this.btnFToCe.Size = new System.Drawing.Size(136, 58);
            this.btnFToCe.TabIndex = 22;
            this.btnFToCe.Text = "Fahrenheit To Celsius";
            this.btnFToCe.UseVisualStyleBackColor = false;
            this.btnFToCe.Click += new System.EventHandler(this.btnFToCe_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkGray;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnShow.Location = new System.Drawing.Point(294, 368);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(142, 47);
            this.btnShow.TabIndex = 31;
            this.btnShow.Text = "Formula Table";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Temperature Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(43, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "<<<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConverterT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(712, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCe);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.Centi);
            this.Controls.Add(this.Meter);
            this.Controls.Add(this.btnCeToF);
            this.Controls.Add(this.btnFToCe);
            this.Name = "ConverterT";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.ConverterT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCe;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label Centi;
        private System.Windows.Forms.Label Meter;
        private System.Windows.Forms.Button btnCeToF;
        private System.Windows.Forms.Button btnFToCe;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


    }
}