namespace PHP_Quest_Real.View
{
    partial class GlostestResultat
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAndraGlosor = new System.Windows.Forms.Button();
            this.btnSammaGlosor = new System.Windows.Forms.Button();
            this.listBoxFelSvar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAntalRätt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBästaResultat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(246, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 38);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Avsluta programmet";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAndraGlosor
            // 
            this.btnAndraGlosor.Location = new System.Drawing.Point(129, 227);
            this.btnAndraGlosor.Name = "btnAndraGlosor";
            this.btnAndraGlosor.Size = new System.Drawing.Size(111, 38);
            this.btnAndraGlosor.TabIndex = 15;
            this.btnAndraGlosor.Text = "Gör testet igen med \r\nandra glosor";
            this.btnAndraGlosor.UseVisualStyleBackColor = true;
            // 
            // btnSammaGlosor
            // 
            this.btnSammaGlosor.Location = new System.Drawing.Point(12, 227);
            this.btnSammaGlosor.Name = "btnSammaGlosor";
            this.btnSammaGlosor.Size = new System.Drawing.Size(111, 38);
            this.btnSammaGlosor.TabIndex = 14;
            this.btnSammaGlosor.Text = "Gör testet igen med \r\nsamma glosor";
            this.btnSammaGlosor.UseVisualStyleBackColor = true;
            // 
            // listBoxFelSvar
            // 
            this.listBoxFelSvar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFelSvar.FormattingEnabled = true;
            this.listBoxFelSvar.Location = new System.Drawing.Point(20, 91);
            this.listBoxFelSvar.Name = "listBoxFelSvar";
            this.listBoxFelSvar.Size = new System.Drawing.Size(120, 130);
            this.listBoxFelSvar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Glosor du bör öva mer på:";
            // 
            // lblAntalRätt
            // 
            this.lblAntalRätt.AutoSize = true;
            this.lblAntalRätt.BackColor = System.Drawing.Color.White;
            this.lblAntalRätt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntalRätt.Location = new System.Drawing.Point(17, 46);
            this.lblAntalRätt.Name = "lblAntalRätt";
            this.lblAntalRätt.Size = new System.Drawing.Size(57, 15);
            this.lblAntalRätt.TabIndex = 11;
            this.lblAntalRätt.Text = "Antal rätt:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 199);
            this.label2.TabIndex = 10;
            this.label2.Text = "        Ditt resultat:";
            // 
            // listBoxBästaResultat
            // 
            this.listBoxBästaResultat.BackColor = System.Drawing.Color.White;
            this.listBoxBästaResultat.FormattingEnabled = true;
            this.listBoxBästaResultat.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4.",
            "5.",
            "6.",
            "7.",
            "8.",
            "9.",
            "10.",
            "11.",
            "12.",
            "13.",
            "14.",
            "15."});
            this.listBoxBästaResultat.Location = new System.Drawing.Point(203, 22);
            this.listBoxBästaResultat.Name = "listBoxBästaResultat";
            this.listBoxBästaResultat.Size = new System.Drawing.Size(154, 199);
            this.listBoxBästaResultat.TabIndex = 9;
            // 
            // GlostestResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 286);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAndraGlosor);
            this.Controls.Add(this.btnSammaGlosor);
            this.Controls.Add(this.listBoxFelSvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAntalRätt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxBästaResultat);
            this.Name = "GlostestResultat";
            this.Text = "Resultat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAndraGlosor;
        private System.Windows.Forms.Button btnSammaGlosor;
        private System.Windows.Forms.ListBox listBoxFelSvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAntalRätt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxBästaResultat;
    }
}