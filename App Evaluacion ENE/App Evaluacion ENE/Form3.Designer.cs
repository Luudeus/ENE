namespace App_Evaluacion_ENE
{
    partial class Form3
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
            this.trabajadoresLabel = new System.Windows.Forms.Label();
            this.trabajadoresBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trabajadoresLabel
            // 
            this.trabajadoresLabel.AutoSize = true;
            this.trabajadoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabajadoresLabel.Location = new System.Drawing.Point(84, 57);
            this.trabajadoresLabel.Name = "trabajadoresLabel";
            this.trabajadoresLabel.Size = new System.Drawing.Size(174, 25);
            this.trabajadoresLabel.TabIndex = 0;
            this.trabajadoresLabel.Text = "TRABAJADORES";
            // 
            // trabajadoresBtn
            // 
            this.trabajadoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabajadoresBtn.Image = global::App_Evaluacion_ENE.Properties.Resources._32195__1_;
            this.trabajadoresBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trabajadoresBtn.Location = new System.Drawing.Point(282, 53);
            this.trabajadoresBtn.Name = "trabajadoresBtn";
            this.trabajadoresBtn.Size = new System.Drawing.Size(255, 33);
            this.trabajadoresBtn.TabIndex = 1;
            this.trabajadoresBtn.Text = "TODOS";
            this.trabajadoresBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trabajadoresBtn.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trabajadoresBtn);
            this.Controls.Add(this.trabajadoresLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trabajadoresLabel;
        private System.Windows.Forms.Button trabajadoresBtn;
    }
}