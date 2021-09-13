namespace Harjoitus_12
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
            this.VastausRB1 = new System.Windows.Forms.RadioButton();
            this.VastausRB2 = new System.Windows.Forms.RadioButton();
            this.VastausRB3 = new System.Windows.Forms.RadioButton();
            this.VastausRB4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KysymysLB.Location = new System.Drawing.Point(39, 28);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(256, 25);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(39, 148);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(90, 25);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // VastausRB1
            // 
            this.VastausRB1.AutoSize = true;
            this.VastausRB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausRB1.Location = new System.Drawing.Point(312, 56);
            this.VastausRB1.Name = "VastausRB1";
            this.VastausRB1.Size = new System.Drawing.Size(38, 24);
            this.VastausRB1.TabIndex = 2;
            this.VastausRB1.TabStop = true;
            this.VastausRB1.Text = "A";
            this.VastausRB1.UseVisualStyleBackColor = true;
            // 
            // VastausRB2
            // 
            this.VastausRB2.AutoSize = true;
            this.VastausRB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausRB2.Location = new System.Drawing.Point(312, 82);
            this.VastausRB2.Name = "VastausRB2";
            this.VastausRB2.Size = new System.Drawing.Size(38, 24);
            this.VastausRB2.TabIndex = 3;
            this.VastausRB2.TabStop = true;
            this.VastausRB2.Text = "B";
            this.VastausRB2.UseVisualStyleBackColor = true;
            // 
            // VastausRB3
            // 
            this.VastausRB3.AutoSize = true;
            this.VastausRB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausRB3.Location = new System.Drawing.Point(312, 104);
            this.VastausRB3.Name = "VastausRB3";
            this.VastausRB3.Size = new System.Drawing.Size(38, 24);
            this.VastausRB3.TabIndex = 4;
            this.VastausRB3.TabStop = true;
            this.VastausRB3.Text = "C";
            this.VastausRB3.UseVisualStyleBackColor = true;
            // 
            // VastausRB4
            // 
            this.VastausRB4.AutoSize = true;
            this.VastausRB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausRB4.Location = new System.Drawing.Point(312, 128);
            this.VastausRB4.Name = "VastausRB4";
            this.VastausRB4.Size = new System.Drawing.Size(39, 24);
            this.VastausRB4.TabIndex = 5;
            this.VastausRB4.TabStop = true;
            this.VastausRB4.Text = "D";
            this.VastausRB4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(312, 159);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.VastausRB4);
            this.Controls.Add(this.VastausRB3);
            this.Controls.Add(this.VastausRB2);
            this.Controls.Add(this.VastausRB1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.RadioButton VastausRB1;
        private System.Windows.Forms.RadioButton VastausRB2;
        private System.Windows.Forms.RadioButton VastausRB3;
        private System.Windows.Forms.RadioButton VastausRB4;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

