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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.modBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workerDgv)).BeginInit();
            this.contextMenuStripWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // trabajadoresLabel
            // 
            this.trabajadoresLabel.AutoSize = true;
            this.trabajadoresLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabajadoresLabel.Location = new System.Drawing.Point(12, 34);
            this.trabajadoresLabel.Name = "trabajadoresLabel";
            this.trabajadoresLabel.Size = new System.Drawing.Size(137, 28);
            this.trabajadoresLabel.TabIndex = 0;
            this.trabajadoresLabel.Text = "TRABAJADOR:";
            // 
            // trabajadoresBtn
            // 
            this.trabajadoresBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabajadoresBtn.Image = global::App_Evaluacion_ENE.Properties.Resources._32195__1_;
            this.trabajadoresBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trabajadoresBtn.Location = new System.Drawing.Point(155, 26);
            this.trabajadoresBtn.Name = "trabajadoresBtn";
            this.trabajadoresBtn.Size = new System.Drawing.Size(739, 44);
            this.trabajadoresBtn.TabIndex = 1;
            this.trabajadoresBtn.Text = "TODOS";
            this.trabajadoresBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trabajadoresBtn.UseVisualStyleBackColor = true;
            this.trabajadoresBtn.Click += new System.EventHandler(this.trabajadoresBtn_Click);
            // 
            // workerDgv
            // 
            this.workerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerDgv.Location = new System.Drawing.Point(12, 80);
            this.workerDgv.Name = "workerDgv";
            this.workerDgv.RowHeadersWidth = 51;
            this.workerDgv.RowTemplate.Height = 24;
            this.workerDgv.Size = new System.Drawing.Size(882, 305);
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
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(609, 415);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(285, 44);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Eliminar";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(12, 415);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(302, 44);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Agregar";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // modBtn
            // 
            this.modBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtn.Location = new System.Drawing.Point(320, 415);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(283, 44);
            this.modBtn.TabIndex = 5;
            this.modBtn.Text = "Modificar";
            this.modBtn.UseVisualStyleBackColor = true;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 485);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
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
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button modBtn;
    }
}