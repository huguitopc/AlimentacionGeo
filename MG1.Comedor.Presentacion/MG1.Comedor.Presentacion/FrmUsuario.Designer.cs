namespace MG1.Comedor.Presentacion
{
    partial class FrmUsuario
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.dg_Usuario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Grupo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(39, 102);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(114, 13);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(134, 20);
            this.txt_Usuario.TabIndex = 5;
            // 
            // dg_Usuario
            // 
            this.dg_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Usuario.Location = new System.Drawing.Point(39, 131);
            this.dg_Usuario.Name = "dg_Usuario";
            this.dg_Usuario.Size = new System.Drawing.Size(209, 118);
            this.dg_Usuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(114, 39);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(134, 20);
            this.txt_Contraseña.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grupo";
            // 
            // cb_Grupo
            // 
            this.cb_Grupo.FormattingEnabled = true;
            this.cb_Grupo.Location = new System.Drawing.Point(114, 65);
            this.cb_Grupo.Name = "cb_Grupo";
            this.cb_Grupo.Size = new System.Drawing.Size(134, 21);
            this.cb_Grupo.TabIndex = 11;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb_Grupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.dg_Usuario);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.DataGridView dg_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Grupo;
    }
}