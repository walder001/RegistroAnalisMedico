﻿namespace RegistroAnalisisMedico
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paceintesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analisisToolStripMenuItem,
            this.tipoAnalisisToolStripMenuItem,
            this.paceintesToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // analisisToolStripMenuItem
            // 
            this.analisisToolStripMenuItem.Name = "analisisToolStripMenuItem";
            this.analisisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analisisToolStripMenuItem.Text = "Analisis";
            this.analisisToolStripMenuItem.Click += new System.EventHandler(this.AnalisisToolStripMenuItem_Click);
            // 
            // tipoAnalisisToolStripMenuItem
            // 
            this.tipoAnalisisToolStripMenuItem.Name = "tipoAnalisisToolStripMenuItem";
            this.tipoAnalisisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoAnalisisToolStripMenuItem.Text = "TipoAnalisis";
            this.tipoAnalisisToolStripMenuItem.Click += new System.EventHandler(this.TipoAnalisisToolStripMenuItem_Click);
            // 
            // paceintesToolStripMenuItem
            // 
            this.paceintesToolStripMenuItem.Name = "paceintesToolStripMenuItem";
            this.paceintesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paceintesToolStripMenuItem.Text = "Pacientes";
            this.paceintesToolStripMenuItem.Click += new System.EventHandler(this.PaceintesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainFrom";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisisToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tipoAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paceintesToolStripMenuItem;
    }
}

