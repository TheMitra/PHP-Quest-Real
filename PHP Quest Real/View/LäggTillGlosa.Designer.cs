namespace PHP_Quest_Real.View
{
    partial class LäggTillGlosa
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
            this.label2 = new System.Windows.Forms.Label();
            this.språk = new System.Windows.Forms.ComboBox();
            this.glosa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.glosaSv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 54);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kom ihåg: Om du råkar lägga till fel\r\nord eller stava fel på något ord så\r\nkan du" +
    " ta bort det i menyn och\r\n sedan lägga till det igen";
            // 
            // språk
            // 
            this.språk.FormattingEnabled = true;
            this.språk.Location = new System.Drawing.Point(149, 14);
            this.språk.Name = "språk";
            this.språk.Size = new System.Drawing.Size(121, 21);
            this.språk.TabIndex = 11;
            this.språk.Text = "Välj språk";
            // 
            // glosa
            // 
            this.glosa.Location = new System.Drawing.Point(149, 41);
            this.glosa.Name = "glosa";
            this.glosa.Size = new System.Drawing.Size(121, 20);
            this.glosa.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Lägg till glosan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // glosaSv
            // 
            this.glosaSv.Location = new System.Drawing.Point(14, 41);
            this.glosaSv.Name = "glosaSv";
            this.glosaSv.Size = new System.Drawing.Size(105, 20);
            this.glosaSv.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Glosan på Svenska:";
            // 
            // LäggTillGlosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.språk);
            this.Controls.Add(this.glosa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.glosaSv);
            this.Controls.Add(this.label1);
            this.Name = "LäggTillGlosa";
            this.Text = "Lägg till glosa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox språk;
        private System.Windows.Forms.TextBox glosa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox glosaSv;
        private System.Windows.Forms.Label label1;
    }
}