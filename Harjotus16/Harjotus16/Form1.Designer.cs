
namespace Harjotus16
{
    partial class LaskuriForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.AloitaBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinuuttiCB = new System.Windows.Forms.ComboBox();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SekunttiCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.Location = new System.Drawing.Point(45, 147);
            this.AikaLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(191, 86);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00:00";
            // 
            // AloitaBT
            // 
            this.AloitaBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AloitaBT.Location = new System.Drawing.Point(30, 279);
            this.AloitaBT.Name = "AloitaBT";
            this.AloitaBT.Size = new System.Drawing.Size(92, 38);
            this.AloitaBT.TabIndex = 1;
            this.AloitaBT.Text = "Aloita";
            this.AloitaBT.UseVisualStyleBackColor = true;
            this.AloitaBT.Click += new System.EventHandler(this.AloitaBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LopetaBT.Location = new System.Drawing.Point(154, 279);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(97, 38);
            this.LopetaBT.TabIndex = 2;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minuutteja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(154, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sekuntia:";
            // 
            // MinuuttiCB
            // 
            this.MinuuttiCB.FormattingEnabled = true;
            this.MinuuttiCB.Location = new System.Drawing.Point(30, 102);
            this.MinuuttiCB.Name = "MinuuttiCB";
            this.MinuuttiCB.Size = new System.Drawing.Size(92, 23);
            this.MinuuttiCB.TabIndex = 5;
            // 
            // AjastinTM
            // 
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick_1);
            // 
            // SekunttiCB
            // 
            this.SekunttiCB.FormattingEnabled = true;
            this.SekunttiCB.Location = new System.Drawing.Point(154, 102);
            this.SekunttiCB.Name = "SekunttiCB";
            this.SekunttiCB.Size = new System.Drawing.Size(97, 23);
            this.SekunttiCB.TabIndex = 6;
            // 
            // LaskuriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 508);
            this.Controls.Add(this.SekunttiCB);
            this.Controls.Add(this.MinuuttiCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.AloitaBT);
            this.Controls.Add(this.AikaLB);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LaskuriForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LaskuriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button AloitaBT;
        private System.Windows.Forms.Button LopetaBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MinuuttiCB;
        private System.Windows.Forms.Timer AjastinTM;
        private System.Windows.Forms.ComboBox SekunttiCB;
    }
}

