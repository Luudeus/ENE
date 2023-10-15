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
            this.components = new System.ComponentModel.Container();
            this.trabajadoresLabel = new System.Windows.Forms.Label();
            this.trabajadoresBtn = new System.Windows.Forms.Button();
            this.workerDgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStripWorker = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tODOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.workerDgv)).BeginInit();
            this.contextMenuStripWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // trabajadoresLabel
            // 
            this.trabajadoresLabel.AutoSize = true;
            this.trabajadoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabajadoresLabel.Location = new System.Drawing.Point(162, 34);
            this.trabajadoresLabel.Name = "trabajadoresLabel";
            this.trabajadoresLabel.Size = new System.Drawing.Size(153, 25);
            this.trabajadoresLabel.TabIndex = 0;
            this.trabajadoresLabel.Text = "TRABAJADOR:";
            // 
            // trabajadoresBtn
            // 
            this.trabajadoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabajadoresBtn.Image = global::App_Evaluacion_ENE.Properties.Resources._32195__1_;
            this.trabajadoresBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trabajadoresBtn.Location = new System.Drawing.Point(349, 30);
            this.trabajadoresBtn.Name = "trabajadoresBtn";
            this.trabajadoresBtn.Size = new System.Drawing.Size(255, 33);
            this.trabajadoresBtn.TabIndex = 1;
            this.trabajadoresBtn.Text = "TODOS";
            this.trabajadoresBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trabajadoresBtn.UseVisualStyleBackColor = true;
            this.trabajadoresBtn.Click += new System.EventHandler(this.trabajadoresBtn_Click);
            // 
            // workerDgv
            // 
            this.workerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerDgv.Location = new System.Drawing.Point(12, 90);
            this.workerDgv.Name = "workerDgv";
            this.workerDgv.RowHeadersWidth = 51;
            this.workerDgv.RowTemplate.Height = 24;
            this.workerDgv.Size = new System.Drawing.Size(941, 326);
            this.workerDgv.TabIndex = 2;
            // 
            // contextMenuStripWorker
            // 
            this.contextMenuStripWorker.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripWorker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODOSToolStripMenuItem});
            this.contextMenuStripWorker.Name = "contextMenuStripWorker";
            this.contextMenuStripWorker.Size = new System.Drawing.Size(127, 28);
            // 
            // tODOSToolStripMenuItem
            // 
            this.tODOSToolStripMenuItem.Name = "tODOSToolStripMenuItem";
            this.tODOSToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.tODOSToolStripMenuItem.Text = "TODOS";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 547);
            this.Controls.Add(this.workerDgv);
            this.Controls.Add(this.trabajadoresBtn);
            this.Controls.Add(this.trabajadoresLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.workerDgv)).EndInit();
            this.contextMenuStripWorker.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trabajadoresLabel;
        private System.Windows.Forms.Button trabajadoresBtn;
        private System.Windows.Forms.DataGridView workerDgv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripWorker;
        private System.Windows.Forms.ToolStripMenuItem tODOSToolStripMenuItem;
    }
}