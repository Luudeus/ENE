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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authLabel
            // 
            this.authLabel.AccessibleName = "";
            this.authLabel.AutoSize = true;
            this.authLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authLabel.Location = new System.Drawing.Point(169, 54);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(254, 39);
            this.authLabel.TabIndex = 0;
            this.authLabel.Text = "Autentificación";
            this.authLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // usrLabel
            // 
            this.usrLabel.AutoSize = true;
            this.usrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLabel.Location = new System.Drawing.Point(21, 113);
            this.usrLabel.Name = "usrLabel";
            this.usrLabel.Size = new System.Drawing.Size(93, 25);
            this.usrLabel.TabIndex = 1;
            this.usrLabel.Text = "Usuario:";
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLabel.Location = new System.Drawing.Point(21, 152);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(113, 25);
            this.passwdLabel.TabIndex = 2;
            this.passwdLabel.Text = "Password:";
            this.passwdLabel.Click += new System.EventHandler(this.passwdLabel_Click);
            // 
            // usrTxt
            // 
            this.usrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrTxt.Location = new System.Drawing.Point(165, 108);
            this.usrTxt.Name = "usrTxt";
            this.usrTxt.Size = new System.Drawing.Size(258, 30);
            this.usrTxt.TabIndex = 3;
            this.usrTxt.TextChanged += new System.EventHandler(this.usrTxt_TextChanged);
            // 
            // passwdTxt
            // 
            this.passwdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdTxt.Location = new System.Drawing.Point(165, 150);
            this.passwdTxt.Name = "passwdTxt";
            this.passwdTxt.Size = new System.Drawing.Size(258, 30);
            this.passwdTxt.TabIndex = 4;
            this.passwdTxt.TextChanged += new System.EventHandler(this.passwdTxt_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(165, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(581, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwdTxt);
            this.Controls.Add(this.usrTxt);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.usrLabel);
            this.Controls.Add(this.authLabel);
            this.Name = "enterBtn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox usrTxt;
        private System.Windows.Forms.TextBox passwdTxt;
        private System.Windows.Forms.Button button1;
    }
}

