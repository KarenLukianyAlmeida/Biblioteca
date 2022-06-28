namespace Livraria
{
    partial class F_ClubeClientes
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
            this.btn_pesquisarNome = new System.Windows.Forms.Button();
            this.tb_nomeCliente = new System.Windows.Forms.TextBox();
            this.tb_numeroDaChave = new System.Windows.Forms.TextBox();
            this.btn_pesquisarChave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Membros do Clube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesquisar por nome ";
            // 
            // btn_pesquisarNome
            // 
            this.btn_pesquisarNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pesquisarNome.Location = new System.Drawing.Point(286, 133);
            this.btn_pesquisarNome.Name = "btn_pesquisarNome";
            this.btn_pesquisarNome.Size = new System.Drawing.Size(75, 33);
            this.btn_pesquisarNome.TabIndex = 2;
            this.btn_pesquisarNome.Text = "OK";
            this.btn_pesquisarNome.UseVisualStyleBackColor = true;
            // 
            // tb_nomeCliente
            // 
            this.tb_nomeCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nomeCliente.Location = new System.Drawing.Point(49, 138);
            this.tb_nomeCliente.Name = "tb_nomeCliente";
            this.tb_nomeCliente.Size = new System.Drawing.Size(231, 25);
            this.tb_nomeCliente.TabIndex = 3;
            // 
            // tb_numeroDaChave
            // 
            this.tb_numeroDaChave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_numeroDaChave.Location = new System.Drawing.Point(49, 217);
            this.tb_numeroDaChave.Name = "tb_numeroDaChave";
            this.tb_numeroDaChave.Size = new System.Drawing.Size(231, 25);
            this.tb_numeroDaChave.TabIndex = 6;
            // 
            // btn_pesquisarChave
            // 
            this.btn_pesquisarChave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pesquisarChave.Location = new System.Drawing.Point(286, 212);
            this.btn_pesquisarChave.Name = "btn_pesquisarChave";
            this.btn_pesquisarChave.Size = new System.Drawing.Size(75, 33);
            this.btn_pesquisarChave.TabIndex = 5;
            this.btn_pesquisarChave.Text = "OK";
            this.btn_pesquisarChave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pesquisar pelo nº da chave";
            // 
            // F_ClubeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 324);
            this.Controls.Add(this.tb_numeroDaChave);
            this.Controls.Add(this.btn_pesquisarChave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nomeCliente);
            this.Controls.Add(this.btn_pesquisarNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ClubeClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clube Clientes - Membros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pesquisarNome;
        private System.Windows.Forms.TextBox tb_nomeCliente;
        private System.Windows.Forms.TextBox tb_numeroDaChave;
        private System.Windows.Forms.Button btn_pesquisarChave;
        private System.Windows.Forms.Label label3;
    }
}