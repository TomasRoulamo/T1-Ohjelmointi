namespace Harjoitus7
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
            this.label1 = new System.Windows.Forms.Label();
            this.LainakorkoTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.VakuutusTB = new System.Windows.Forms.TextBox();
            this.MuutkulutTB = new System.Windows.Forms.TextBox();
            this.PolttoaineTB = new System.Windows.Forms.TextBox();
            this.PesuTB = new System.Windows.Forms.TextBox();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.KmvuosiCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auton kustannuslaskuri";
            // 
            // LainakorkoTB
            // 
            this.LainakorkoTB.Location = new System.Drawing.Point(170, 129);
            this.LainakorkoTB.Name = "LainakorkoTB";
            this.LainakorkoTB.Size = new System.Drawing.Size(100, 20);
            this.LainakorkoTB.TabIndex = 1;
            // 
            // NesteetTB
            // 
            this.NesteetTB.Location = new System.Drawing.Point(170, 176);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(100, 20);
            this.NesteetTB.TabIndex = 2;
            // 
            // VakuutusTB
            // 
            this.VakuutusTB.Location = new System.Drawing.Point(170, 223);
            this.VakuutusTB.Name = "VakuutusTB";
            this.VakuutusTB.Size = new System.Drawing.Size(100, 20);
            this.VakuutusTB.TabIndex = 3;
            // 
            // MuutkulutTB
            // 
            this.MuutkulutTB.Location = new System.Drawing.Point(170, 272);
            this.MuutkulutTB.Name = "MuutkulutTB";
            this.MuutkulutTB.Size = new System.Drawing.Size(100, 20);
            this.MuutkulutTB.TabIndex = 4;
            // 
            // PolttoaineTB
            // 
            this.PolttoaineTB.Location = new System.Drawing.Point(170, 319);
            this.PolttoaineTB.Name = "PolttoaineTB";
            this.PolttoaineTB.Size = new System.Drawing.Size(100, 20);
            this.PolttoaineTB.TabIndex = 5;
            // 
            // PesuTB
            // 
            this.PesuTB.Location = new System.Drawing.Point(547, 128);
            this.PesuTB.Name = "PesuTB";
            this.PesuTB.Size = new System.Drawing.Size(100, 20);
            this.PesuTB.TabIndex = 6;
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(547, 175);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(100, 20);
            this.HuollotTB.TabIndex = 7;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(547, 222);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(100, 20);
            this.RenkaatTB.TabIndex = 8;
            // 
            // KmvuosiCB
            // 
            this.KmvuosiCB.FormattingEnabled = true;
            this.KmvuosiCB.Items.AddRange(new object[] {
            "10000",
            "20000",
            "30000",
            "40000",
            "50000",
            "60000",
            "70000",
            "80000",
            "90000",
            "100000"});
            this.KmvuosiCB.Location = new System.Drawing.Point(547, 271);
            this.KmvuosiCB.Name = "KmvuosiCB";
            this.KmvuosiCB.Size = new System.Drawing.Size(121, 21);
            this.KmvuosiCB.TabIndex = 9;
            this.KmvuosiCB.SelectedIndexChanged += new System.EventHandler(this.KmvuosiCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lainan lyhennys korkoineen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lisättävät nesteet yms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vakuutusmaksut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Muut kulut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Polttoaine:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kilometrit/vuosi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Renkaat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Huollot:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Pesut:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(434, 317);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(37, 20);
            this.VastausLB.TabIndex = 19;
            this.VastausLB.Text = "xxxx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KmvuosiCB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.PesuTB);
            this.Controls.Add(this.PolttoaineTB);
            this.Controls.Add(this.MuutkulutTB);
            this.Controls.Add(this.VakuutusTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.LainakorkoTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LainakorkoTB;
        private System.Windows.Forms.TextBox NesteetTB;
        private System.Windows.Forms.TextBox VakuutusTB;
        private System.Windows.Forms.TextBox MuutkulutTB;
        private System.Windows.Forms.TextBox PolttoaineTB;
        private System.Windows.Forms.TextBox PesuTB;
        private System.Windows.Forms.TextBox HuollotTB;
        private System.Windows.Forms.TextBox RenkaatTB;
        private System.Windows.Forms.ComboBox KmvuosiCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label VastausLB;
    }
}

