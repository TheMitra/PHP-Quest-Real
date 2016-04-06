namespace PHP_Quest_Real
{
    partial class LogInForm
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
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblProfil = new System.Windows.Forms.Label();
            this.lblProfil2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Användarnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lösenord:";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(137, 28);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(100, 20);
            this.txbUsername.TabIndex = 2;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(137, 59);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(100, 20);
            this.txbPassword.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(44, 88);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Logga in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(40, 177);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrera.TabIndex = 5;
            this.btnRegistrera.Text = "Skapa profil";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(121, 93);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(40, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Status:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(36, 115);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Har du ingen profil?";
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.BackColor = System.Drawing.Color.Transparent;
            this.lblProfil.Location = new System.Drawing.Point(37, 135);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(181, 39);
            this.lblProfil.TabIndex = 8;
            this.lblProfil.Text = "Fyll i rutorna med det användarnamn \r\noch lösenord du vill ha. Sedan \r\ntryck på S" +
    "kapa Profil  knappen.";
            // 
            // lblProfil2
            // 
            this.lblProfil2.AutoSize = true;
            this.lblProfil2.BackColor = System.Drawing.Color.Transparent;
            this.lblProfil2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProfil2.Location = new System.Drawing.Point(78, 161);
            this.lblProfil2.Name = "lblProfil2";
            this.lblProfil2.Size = new System.Drawing.Size(64, 13);
            this.lblProfil2.TabIndex = 9;
            this.lblProfil2.Text = "Skapa Profil";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 206);
            this.Controls.Add(this.lblProfil2);
            this.Controls.Add(this.lblProfil);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogInForm";
            this.Text = "Logga in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.Label lblProfil2;
    }
}