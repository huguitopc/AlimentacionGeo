﻿namespace MG1.Comedor.Presentacion
{
    partial class FrmGrupo
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
            this.dg_Grupo = new System.Windows.Forms.DataGridView();
            this.txt_Grupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Grupo)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Grupo
            // 
            this.dg_Grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Grupo.Location = new System.Drawing.Point(37, 115);
            this.dg_Grupo.Name = "dg_Grupo";
            this.dg_Grupo.Size = new System.Drawing.Size(209, 118);
            this.dg_Grupo.TabIndex = 0;
            // 
            // txt_Grupo
            // 
            this.txt_Grupo.Location = new System.Drawing.Point(94, 26);
            this.txt_Grupo.Name = "txt_Grupo";
            this.txt_Grupo.Size = new System.Drawing.Size(152, 20);
            this.txt_Grupo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupo";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(37, 67);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // FrmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Grupo);
            this.Controls.Add(this.dg_Grupo);
            this.Name = "FrmGrupo";
            this.Text = "FrmGrupo";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Grupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Grupo;
        private System.Windows.Forms.TextBox txt_Grupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Guardar;
    }
}