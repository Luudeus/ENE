namespace App_Evaluacion_ENE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.authLabel = new System.Windows.Forms.Label();
            this.usrLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.usrTxt = new System.Windows.Forms.TextBox();
            this.passwdTxt = new System.Windows.Forms.TextBox();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authLabel
            // 
            this.authLabel.AccessibleName = "";
            this.authLabel.AutoSize = true;
            this.authLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authLabel.Location = new System.Drawing.Point(160, 9);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(245, 46);
            this.authLabel.TabIndex = 0;
            this.authLabel.Text = "Autentificación";
            // 
            // usrLabel
            // 
            this.usrLabel.AutoSize = true;
            this.usrLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLabel.Location = new System.Drawing.Point(12, 68);
            this.usrLabel.Name = "usrLabel";
            this.usrLabel.Size = new System.Drawing.Size(83, 28);
            this.usrLabel.TabIndex = 1;
            this.usrLabel.Text = "Usuario:";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLabel.Location = new System.Drawing.Point(12, 107);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(97, 28);
            this.passwdLabel.TabIndex = 2;
            this.passwdLabel.Text = "Password:";
            // 
            // usrTxt
            // 
            this.usrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrTxt.Location = new System.Drawing.Point(156, 63);
            this.usrTxt.Name = "usrTxt";
            this.usrTxt.Size = new System.Drawing.Size(258, 30);
            this.usrTxt.TabIndex = 3;
            // 
            // passwdTxt
            // 
            this.passwdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdTxt.Location = new System.Drawing.Point(156, 105);
            this.passwdTxt.Name = "passwdTxt";
            this.passwdTxt.PasswordChar = '*';
            this.passwdTxt.Size = new System.Drawing.Size(258, 30);
            this.passwdTxt.TabIndex = 4;
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ingresarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarBtn.Location = new System.Drawing.Point(156, 165);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(258, 58);
            this.ingresarBtn.TabIndex = 5;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = false;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(585, 267);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.passwdTxt);
            this.Controls.Add(this.usrTxt);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.usrLabel);
            this.Controls.Add(this.authLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox usrTxt;
        private System.Windows.Forms.TextBox passwdTxt;
        private System.Windows.Forms.Button ingresarBtn;
    }
}

