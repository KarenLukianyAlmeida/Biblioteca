namespace Livraria
{
    partial class F_AddAutor
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
            this.mtb_nascimentoAutor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salvarCadastro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_visualizarObras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtb_nascimentoAutor
            // 
            this.mtb_nascimentoAutor.Location = new System.Drawing.Point(416, 44);
            this.mtb_nascimentoAutor.Mask = "00/00/0000";
            this.mtb_nascimentoAutor.Name = "mtb_nascimentoAutor";
            this.mtb_nascimentoAutor.Size = new System.Drawing.Size(100, 23);
            this.mtb_nascimentoAutor.TabIndex = 20;
            this.mtb_nascimentoAutor.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(416, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nascimento";
            // 
            // tb_nomeAutor
            // 
            this.tb_nomeAutor.Location = new System.Drawing.Point(12, 44);
            this.tb_nomeAutor.Name = "tb_nomeAutor";
            this.tb_nomeAutor.Size = new System.Drawing.Size(374, 23);
            this.tb_nomeAutor.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome ";
            // 
            // btn_salvarCadastro
            // 
            this.btn_salvarCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salvarCadastro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salvarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_salvarCadastro.Location = new System.Drawing.Point(12, 189);
            this.btn_salvarCadastro.Name = "btn_salvarCadastro";
            this.btn_salvarCadastro.Size = new System.Drawing.Size(504, 30);
            this.btn_salvarCadastro.TabIndex = 21;
            this.btn_salvarCadastro.Text = "Salvar Cadastro";
            this.btn_salvarCadastro.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Obras";
            // 
            // btn_visualizarObras
            // 
            this.btn_visualizarObras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_visualizarObras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_visualizarObras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_visualizarObras.Location = new System.Drawing.Point(12, 107);
            this.btn_visualizarObras.Name = "btn_visualizarObras";
            this.btn_visualizarObras.Size = new System.Drawing.Size(150, 30);
            this.btn_visualizarObras.TabIndex = 24;
            this.btn_visualizarObras.Text = "Visualizar";
            this.btn_visualizarObras.UseVisualStyleBackColor = false;
            // 
            // F_AddAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 237);
            this.Controls.Add(this.btn_visualizarObras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salvarCadastro);
            this.Controls.Add(this.mtb_nascimentoAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nomeAutor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_AddAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Autor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_nascimentoAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salvarCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_visualizarObras;
    }
}