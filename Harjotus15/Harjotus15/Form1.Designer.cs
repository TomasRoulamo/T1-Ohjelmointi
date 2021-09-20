namespace Harjotus15
{
    partial class KelloForm
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.AloitaBT = new System.Windows.Forms.Button();
            this.TimerTM = new System.Windows.Forms.Timer(this.components);
            this.LopetaBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AikaLB.Location = new System.Drawing.Point(65, 105);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(603, 108);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00:00:00.000";
            // 
            // AloitaBT
            // 
            this.AloitaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AloitaBT.Location = new System.Drawing.Point(83, 279);
            this.AloitaBT.Name = "AloitaBT";
            this.AloitaBT.Size = new System.Drawing.Size(81, 37);
            this.AloitaBT.TabIndex = 1;
            this.AloitaBT.Text = "Aloita";
            this.AloitaBT.UseVisualStyleBackColor = true;
            this.AloitaBT.Click += new System.EventHandler(this.AloitaBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LopetaBT.Location = new System.Drawing.Point(280, 279);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(87, 37);
            this.LopetaBT.TabIndex = 2;
            this.LopetaBT.Text = "Lopeta\r\n";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBT.Location = new System.Drawing.Point(480, 279);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(83, 37);
            this.ResetBT.TabIndex = 3;
            this.ResetBT.Text = "Reset";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // KelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.AloitaBT);
            this.Controls.Add(this.AikaLB);
            this.Name = "KelloForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button AloitaBT;
        private System.Windows.Forms.Timer TimerTM;
        private System.Windows.Forms.Button LopetaBT;
        private System.Windows.Forms.Button ResetBT;
    }
}

