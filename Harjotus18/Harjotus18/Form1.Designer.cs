namespace Harjotus18
{
    partial class TietoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OppilaitosCB = new System.Windows.Forms.ComboBox();
            this.VastuuCB = new System.Windows.Forms.ComboBox();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PpaikkaLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.PnroLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.PuhLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avain henkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // OppilaitosCB
            // 
            this.OppilaitosCB.FormattingEnabled = true;
            this.OppilaitosCB.Location = new System.Drawing.Point(76, 184);
            this.OppilaitosCB.Name = "OppilaitosCB";
            this.OppilaitosCB.Size = new System.Drawing.Size(121, 32);
            this.OppilaitosCB.TabIndex = 3;
            this.OppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitosCB_SelectedIndexChanged);
            // 
            // VastuuCB
            // 
            this.VastuuCB.FormattingEnabled = true;
            this.VastuuCB.Location = new System.Drawing.Point(350, 184);
            this.VastuuCB.Name = "VastuuCB";
            this.VastuuCB.Size = new System.Drawing.Size(121, 32);
            this.VastuuCB.TabIndex = 4;
            this.VastuuCB.TextChanged += new System.EventHandler(this.VastuuCB_TextChanged);
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(76, 245);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(64, 24);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PpaikkaLB
            // 
            this.PpaikkaLB.AutoSize = true;
            this.PpaikkaLB.Location = new System.Drawing.Point(76, 335);
            this.PpaikkaLB.Name = "PpaikkaLB";
            this.PpaikkaLB.Size = new System.Drawing.Size(142, 24);
            this.PpaikkaLB.TabIndex = 6;
            this.PpaikkaLB.Text = "Postitoimipaikka";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(346, 286);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(68, 24);
            this.OsastoLB.TabIndex = 7;
            this.OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(346, 245);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(53, 24);
            this.TitteliLB.TabIndex = 8;
            this.TitteliLB.Text = "Titteli";
            // 
            // PnroLB
            // 
            this.PnroLB.AutoSize = true;
            this.PnroLB.Location = new System.Drawing.Point(76, 286);
            this.PnroLB.Name = "PnroLB";
            this.PnroLB.Size = new System.Drawing.Size(116, 24);
            this.PnroLB.TabIndex = 9;
            this.PnroLB.Text = "Postinumero";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(76, 377);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(74, 24);
            this.PuhelinLB.TabIndex = 10;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // PuhLB
            // 
            this.PuhLB.AutoSize = true;
            this.PuhLB.Location = new System.Drawing.Point(346, 377);
            this.PuhLB.Name = "PuhLB";
            this.PuhLB.Size = new System.Drawing.Size(74, 24);
            this.PuhLB.TabIndex = 11;
            this.PuhLB.Text = "Puhelin";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(346, 335);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(102, 24);
            this.EmailLB.TabIndex = 12;
            this.EmailLB.Text = "Sähköposti";
            // 
            // TietoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 514);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.PuhLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PnroLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.PpaikkaLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.VastuuCB);
            this.Controls.Add(this.OppilaitosCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TietoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TietoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OppilaitosCB;
        private System.Windows.Forms.ComboBox VastuuCB;
        private System.Windows.Forms.Label OsoiteLB;
        private System.Windows.Forms.Label PpaikkaLB;
        private System.Windows.Forms.Label OsastoLB;
        private System.Windows.Forms.Label TitteliLB;
        private System.Windows.Forms.Label PnroLB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.Label PuhLB;
        private System.Windows.Forms.Label EmailLB;
    }
}

