namespace Harjoitus3
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
            this.LukuYksiTB = new System.Windows.Forms.TextBox();
            this.LukuKaksiTB = new System.Windows.Forms.TextBox();
            this.LaskuToimitusCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LukuYksiTB
            // 
            this.LukuYksiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LukuYksiTB.Location = new System.Drawing.Point(103, 122);
            this.LukuYksiTB.Name = "LukuYksiTB";
            this.LukuYksiTB.Size = new System.Drawing.Size(100, 31);
            this.LukuYksiTB.TabIndex = 0;
            // 
            // LukuKaksiTB
            // 
            this.LukuKaksiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LukuKaksiTB.Location = new System.Drawing.Point(378, 122);
            this.LukuKaksiTB.Name = "LukuKaksiTB";
            this.LukuKaksiTB.Size = new System.Drawing.Size(100, 31);
            this.LukuKaksiTB.TabIndex = 1;
            // 
            // LaskuToimitusCB
            // 
            this.LaskuToimitusCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskuToimitusCB.FormattingEnabled = true;
            this.LaskuToimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskuToimitusCB.Location = new System.Drawing.Point(229, 120);
            this.LaskuToimitusCB.Name = "LaskuToimitusCB";
            this.LaskuToimitusCB.Size = new System.Drawing.Size(121, 33);
            this.LaskuToimitusCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(548, 128);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(26, 25);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "X";
            this.VastausLB.Visible = false;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskeBT.Location = new System.Drawing.Point(622, 124);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(96, 32);
            this.LaskeBT.TabIndex = 5;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaskuToimitusCB);
            this.Controls.Add(this.LukuKaksiTB);
            this.Controls.Add(this.LukuYksiTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LukuYksiTB;
        private System.Windows.Forms.TextBox LukuKaksiTB;
        private System.Windows.Forms.ComboBox LaskuToimitusCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button LaskeBT;
    }
}

