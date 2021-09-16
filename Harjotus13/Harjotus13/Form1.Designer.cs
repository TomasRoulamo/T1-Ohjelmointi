namespace Harjotus13
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KysymysLB.Location = new System.Drawing.Point(12, 47);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(612, 25);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Anna nimesi, niin tarkistan onko se 50 suosituimman joukossa:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(17, 93);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(90, 25);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // NimiTB
            // 
            this.NimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NimiTB.Location = new System.Drawing.Point(630, 47);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(158, 31);
            this.NimiTB.TabIndex = 2;
            this.NimiTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarkistaBT.Location = new System.Drawing.Point(688, 93);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(100, 36);
            this.TarkistaBT.TabIndex = 3;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TarkistaBT);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox NimiTB;
        private System.Windows.Forms.Button TarkistaBT;
    }
}

