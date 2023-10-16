namespace App_Evaluacion_ENE
{
    partial class Form2
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
            this.workedHrsLabel = new System.Windows.Forms.Label();
            this.extraHrsLabel = new System.Windows.Forms.Label();
            this.calcularBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.liquidoLabel = new System.Windows.Forms.Label();
            this.brutoLabel = new System.Windows.Forms.Label();
            this.trabajadasTxt = new System.Windows.Forms.TextBox();
            this.extraTxt = new System.Windows.Forms.TextBox();
            this.liquidoTxt = new System.Windows.Forms.TextBox();
            this.brutoTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStripSalud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fONASAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSALUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mASVIDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bANMEDICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripAFP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cUPRUMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODELOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAPITALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVIDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afpBtn = new System.Windows.Forms.Button();
            this.saludBtn = new System.Windows.Forms.Button();
            this.contextMenuStripSalud.SuspendLayout();
            this.contextMenuStripAFP.SuspendLayout();
            this.SuspendLayout();
            // 
            // workedHrsLabel
            // 
            this.workedHrsLabel.AutoSize = true;
            this.workedHrsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workedHrsLabel.Location = new System.Drawing.Point(12, 9);
            this.workedHrsLabel.Name = "workedHrsLabel";
            this.workedHrsLabel.Size = new System.Drawing.Size(204, 28);
            this.workedHrsLabel.TabIndex = 0;
            this.workedHrsLabel.Text = "HORAS TRABAJADAS:";
            // 
            // extraHrsLabel
            // 
            this.extraHrsLabel.AutoSize = true;
            this.extraHrsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraHrsLabel.Location = new System.Drawing.Point(12, 55);
            this.extraHrsLabel.Name = "extraHrsLabel";
            this.extraHrsLabel.Size = new System.Drawing.Size(154, 28);
            this.extraHrsLabel.TabIndex = 1;
            this.extraHrsLabel.Text = "HORAS EXTRAS:";
            // 
            // calcularBtn
            // 
            this.calcularBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcularBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularBtn.Location = new System.Drawing.Point(17, 110);
            this.calcularBtn.Name = "calcularBtn";
            this.calcularBtn.Size = new System.Drawing.Size(114, 35);
            this.calcularBtn.TabIndex = 2;
            this.calcularBtn.Text = "Calcular";
            this.calcularBtn.UseVisualStyleBackColor = true;
            this.calcularBtn.Click += new System.EventHandler(this.calcularBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(17, 151);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(114, 36);
            this.guardarBtn.TabIndex = 3;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarBtn.Location = new System.Drawing.Point(17, 192);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(114, 74);
            this.limpiarBtn.TabIndex = 4;
            this.limpiarBtn.Text = "Limpiar\r\nCampos";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // liquidoLabel
            // 
            this.liquidoLabel.AutoSize = true;
            this.liquidoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liquidoLabel.Location = new System.Drawing.Point(285, 199);
            this.liquidoLabel.Name = "liquidoLabel";
            this.liquidoLabel.Size = new System.Drawing.Size(171, 28);
            this.liquidoLabel.TabIndex = 7;
            this.liquidoLabel.Text = "SUELDO LIQUIDO:";
            // 
            // brutoLabel
            // 
            this.brutoLabel.AutoSize = true;
            this.brutoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brutoLabel.Location = new System.Drawing.Point(285, 117);
            this.brutoLabel.Name = "brutoLabel";
            this.brutoLabel.Size = new System.Drawing.Size(155, 28);
            this.brutoLabel.TabIndex = 6;
            this.brutoLabel.Text = "SUELDO BRUTO:";
            // 
            // trabajadasTxt
            // 
            this.trabajadasTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabajadasTxt.Location = new System.Drawing.Point(290, 6);
            this.trabajadasTxt.Name = "trabajadasTxt";
            this.trabajadasTxt.Size = new System.Drawing.Size(175, 34);
            this.trabajadasTxt.TabIndex = 8;
            // 
            // extraTxt
            // 
            this.extraTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraTxt.Location = new System.Drawing.Point(290, 52);
            this.extraTxt.Name = "extraTxt";
            this.extraTxt.Size = new System.Drawing.Size(175, 34);
            this.extraTxt.TabIndex = 9;
            // 
            // liquidoTxt
            // 
            this.liquidoTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liquidoTxt.Location = new System.Drawing.Point(530, 196);
            this.liquidoTxt.Name = "liquidoTxt";
            this.liquidoTxt.ReadOnly = true;
            this.liquidoTxt.Size = new System.Drawing.Size(175, 34);
            this.liquidoTxt.TabIndex = 11;
            // 
            // brutoTxt
            // 
            this.brutoTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brutoTxt.Location = new System.Drawing.Point(530, 114);
            this.brutoTxt.Name = "brutoTxt";
            this.brutoTxt.ReadOnly = true;
            this.brutoTxt.Size = new System.Drawing.Size(175, 34);
            this.brutoTxt.TabIndex = 10;
            // 
            // contextMenuStripSalud
            // 
            this.contextMenuStripSalud.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSalud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fONASAToolStripMenuItem,
            this.cONSALUDToolStripMenuItem,
            this.mASVIDAToolStripMenuItem,
            this.bANMEDICAToolStripMenuItem});
            this.contextMenuStripSalud.Name = "contextMenuStrip1";
            this.contextMenuStripSalud.Size = new System.Drawing.Size(164, 100);
            // 
            // fONASAToolStripMenuItem
            // 
            this.fONASAToolStripMenuItem.Name = "fONASAToolStripMenuItem";
            this.fONASAToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.fONASAToolStripMenuItem.Text = "FONASA";
            // 
            // cONSALUDToolStripMenuItem
            // 
            this.cONSALUDToolStripMenuItem.Name = "cONSALUDToolStripMenuItem";
            this.cONSALUDToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.cONSALUDToolStripMenuItem.Text = "CONSALUD";
            // 
            // mASVIDAToolStripMenuItem
            // 
            this.mASVIDAToolStripMenuItem.Name = "mASVIDAToolStripMenuItem";
            this.mASVIDAToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.mASVIDAToolStripMenuItem.Text = "MASVIDA";
            // 
            // bANMEDICAToolStripMenuItem
            // 
            this.bANMEDICAToolStripMenuItem.Name = "bANMEDICAToolStripMenuItem";
            this.bANMEDICAToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.bANMEDICAToolStripMenuItem.Text = "BANMEDICA";
            // 
            // contextMenuStripAFP
            // 
            this.contextMenuStripAFP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAFP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUPRUMToolStripMenuItem,
            this.mODELOToolStripMenuItem,
            this.cAPITALToolStripMenuItem,
            this.pROVIDAToolStripMenuItem});
            this.contextMenuStripAFP.Name = "contextMenuStrip1";
            this.contextMenuStripAFP.Size = new System.Drawing.Size(141, 100);
            // 
            // cUPRUMToolStripMenuItem
            // 
            this.cUPRUMToolStripMenuItem.Name = "cUPRUMToolStripMenuItem";
            this.cUPRUMToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.cUPRUMToolStripMenuItem.Text = "CUPRUM";
            // 
            // mODELOToolStripMenuItem
            // 
            this.mODELOToolStripMenuItem.Name = "mODELOToolStripMenuItem";
            this.mODELOToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.mODELOToolStripMenuItem.Text = "MODELO";
            // 
            // cAPITALToolStripMenuItem
            // 
            this.cAPITALToolStripMenuItem.Name = "cAPITALToolStripMenuItem";
            this.cAPITALToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.cAPITALToolStripMenuItem.Text = "CAPITAL";
            // 
            // pROVIDAToolStripMenuItem
            // 
            this.pROVIDAToolStripMenuItem.Name = "pROVIDAToolStripMenuItem";
            this.pROVIDAToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.pROVIDAToolStripMenuItem.Text = "PROVIDA";
            // 
            // afpBtn
            // 
            this.afpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afpBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afpBtn.Image = global::App_Evaluacion_ENE.Properties.Resources._32195__1_;
            this.afpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.afpBtn.Location = new System.Drawing.Point(530, 4);
            this.afpBtn.Name = "afpBtn";
            this.afpBtn.Size = new System.Drawing.Size(175, 36);
            this.afpBtn.TabIndex = 13;
            this.afpBtn.Text = "CUPRUM";
            this.afpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.afpBtn.UseVisualStyleBackColor = true;
            this.afpBtn.Click += new System.EventHandler(this.afpBtn_Click);
            // 
            // saludBtn
            // 
            this.saludBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saludBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludBtn.Image = global::App_Evaluacion_ENE.Properties.Resources._32195__1_;
            this.saludBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saludBtn.Location = new System.Drawing.Point(530, 50);
            this.saludBtn.Name = "saludBtn";
            this.saludBtn.Size = new System.Drawing.Size(175, 36);
            this.saludBtn.TabIndex = 12;
            this.saludBtn.Text = "FONASA";
            this.saludBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saludBtn.UseVisualStyleBackColor = true;
            this.saludBtn.Click += new System.EventHandler(this.saludBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 291);
            this.Controls.Add(this.afpBtn);
            this.Controls.Add(this.saludBtn);
            this.Controls.Add(this.liquidoTxt);
            this.Controls.Add(this.brutoTxt);
            this.Controls.Add(this.extraTxt);
            this.Controls.Add(this.trabajadasTxt);
            this.Controls.Add(this.liquidoLabel);
            this.Controls.Add(this.brutoLabel);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.calcularBtn);
            this.Controls.Add(this.extraHrsLabel);
            this.Controls.Add(this.workedHrsLabel);
            this.Name = "Form2";
            this.Text = "Calcular Sueldo";
            this.contextMenuStripSalud.ResumeLayout(false);
            this.contextMenuStripAFP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workedHrsLabel;
        private System.Windows.Forms.Label extraHrsLabel;
        private System.Windows.Forms.Button calcularBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Label liquidoLabel;
        private System.Windows.Forms.Label brutoLabel;
        private System.Windows.Forms.TextBox trabajadasTxt;
        private System.Windows.Forms.TextBox extraTxt;
        private System.Windows.Forms.TextBox liquidoTxt;
        private System.Windows.Forms.TextBox brutoTxt;
        private System.Windows.Forms.Button saludBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSalud;
        private System.Windows.Forms.ToolStripMenuItem fONASAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSALUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mASVIDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bANMEDICAToolStripMenuItem;
        private System.Windows.Forms.Button afpBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAFP;
        private System.Windows.Forms.ToolStripMenuItem cUPRUMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODELOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAPITALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVIDAToolStripMenuItem;
    }
}