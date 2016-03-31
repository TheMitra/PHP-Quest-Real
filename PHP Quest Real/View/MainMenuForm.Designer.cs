namespace PHP_Quest_Real
{
    partial class MainMenuForm
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
            this.lblGlosaStatus = new System.Windows.Forms.Label();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.lblSpråk = new System.Windows.Forms.Label();
            this.lblGlosor = new System.Windows.Forms.Label();
            this.språkLista = new System.Windows.Forms.ListBox();
            this.glosLista = new System.Windows.Forms.ListBox();
            this.btnGlostestStart = new System.Windows.Forms.Button();
            this.btnNySpråk = new System.Windows.Forms.Button();
            this.btnNyGlosa = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGlosaStatus
            // 
            this.lblGlosaStatus.AutoSize = true;
            this.lblGlosaStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lblGlosaStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGlosaStatus.Location = new System.Drawing.Point(16, 211);
            this.lblGlosaStatus.Name = "lblGlosaStatus";
            this.lblGlosaStatus.Size = new System.Drawing.Size(81, 15);
            this.lblGlosaStatus.TabIndex = 17;
            this.lblGlosaStatus.Text = "Felmeddelande";
            this.lblGlosaStatus.Visible = false;
            // 
            // btnTaBort
            // 
            this.btnTaBort.BackColor = System.Drawing.Color.Red;
            this.btnTaBort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaBort.Location = new System.Drawing.Point(177, 175);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(56, 23);
            this.btnTaBort.TabIndex = 16;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = false;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // lblSpråk
            // 
            this.lblSpråk.AutoSize = true;
            this.lblSpråk.BackColor = System.Drawing.SystemColors.Control;
            this.lblSpråk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpråk.Location = new System.Drawing.Point(281, 21);
            this.lblSpråk.Name = "lblSpråk";
            this.lblSpråk.Size = new System.Drawing.Size(37, 15);
            this.lblSpråk.TabIndex = 15;
            this.lblSpråk.Text = "Språk";
            // 
            // lblGlosor
            // 
            this.lblGlosor.AutoSize = true;
            this.lblGlosor.BackColor = System.Drawing.SystemColors.Control;
            this.lblGlosor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGlosor.Location = new System.Drawing.Point(72, 21);
            this.lblGlosor.Name = "lblGlosor";
            this.lblGlosor.Size = new System.Drawing.Size(39, 15);
            this.lblGlosor.TabIndex = 14;
            this.lblGlosor.Text = "Glosor";
            // 
            // språkLista
            // 
            this.språkLista.FormattingEnabled = true;
            this.språkLista.Location = new System.Drawing.Point(239, 35);
            this.språkLista.Name = "språkLista";
            this.språkLista.Size = new System.Drawing.Size(120, 134);
            this.språkLista.TabIndex = 12;
            // 
            // glosLista
            // 
            this.glosLista.FormattingEnabled = true;
            this.glosLista.Location = new System.Drawing.Point(16, 35);
            this.glosLista.Name = "glosLista";
            this.glosLista.Size = new System.Drawing.Size(155, 134);
            this.glosLista.TabIndex = 12;
            // 
            // btnGlostestStart
            // 
            this.btnGlostestStart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGlostestStart.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGlostestStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnGlostestStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlostestStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlostestStart.Location = new System.Drawing.Point(16, 240);
            this.btnGlostestStart.Name = "btnGlostestStart";
            this.btnGlostestStart.Size = new System.Drawing.Size(120, 30);
            this.btnGlostestStart.TabIndex = 11;
            this.btnGlostestStart.Text = "Starta glostest";
            this.btnGlostestStart.UseVisualStyleBackColor = false;
            this.btnGlostestStart.Click += new System.EventHandler(this.btnGlostestStart_Click);
            // 
            // btnNySpråk
            // 
            this.btnNySpråk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNySpråk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNySpråk.Location = new System.Drawing.Point(239, 175);
            this.btnNySpråk.Name = "btnNySpråk";
            this.btnNySpråk.Size = new System.Drawing.Size(120, 23);
            this.btnNySpråk.TabIndex = 10;
            this.btnNySpråk.Text = "Lägg till nytt språk";
            this.btnNySpråk.UseVisualStyleBackColor = false;
            this.btnNySpråk.Click += new System.EventHandler(this.btnNySpråk_Click);
            // 
            // btnNyGlosa
            // 
            this.btnNyGlosa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNyGlosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNyGlosa.Location = new System.Drawing.Point(16, 175);
            this.btnNyGlosa.Name = "btnNyGlosa";
            this.btnNyGlosa.Size = new System.Drawing.Size(155, 23);
            this.btnNyGlosa.TabIndex = 9;
            this.btnNyGlosa.Text = "Lägg till glosa";
            this.btnNyGlosa.UseVisualStyleBackColor = false;
            this.btnNyGlosa.Click += new System.EventHandler(this.btnNyGlosa_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(253, 240);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 18;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 291);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblGlosaStatus);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.lblSpråk);
            this.Controls.Add(this.lblGlosor);
            this.Controls.Add(this.språkLista);
            this.Controls.Add(this.glosLista);
            this.Controls.Add(this.btnGlostestStart);
            this.Controls.Add(this.btnNySpråk);
            this.Controls.Add(this.btnNyGlosa);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGlosaStatus;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Label lblSpråk;
        private System.Windows.Forms.Label lblGlosor;
        private System.Windows.Forms.ListBox språkLista;
        private System.Windows.Forms.ListBox glosLista;
        private System.Windows.Forms.Button btnGlostestStart;
        private System.Windows.Forms.Button btnNySpråk;
        private System.Windows.Forms.Button btnNyGlosa;
        private System.Windows.Forms.Button btnReload;
    }
}