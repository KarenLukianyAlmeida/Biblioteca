namespace Livraria
{
    partial class F_NovoCliente
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
            this.tb_nomeCliente = new System.Windows.Forms.TextBox();
            this.btn_cadastrarEndereco = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.btn_salvarCadastro = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome ";
            // 
            // tb_nomeCliente
            // 
            this.tb_nomeCliente.Location = new System.Drawing.Point(12, 36);
            this.tb_nomeCliente.Name = "tb_nomeCliente";
            this.tb_nomeCliente.Size = new System.Drawing.Size(374, 23);
            this.tb_nomeCliente.TabIndex = 1;
            // 
            // btn_cadastrarEndereco
            // 
            this.btn_cadastrarEndereco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cadastrarEndereco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastrarEndereco.Location = new System.Drawing.Point(14, 222);
            this.btn_cadastrarEndereco.Name = "btn_cadastrarEndereco";
            this.btn_cadastrarEndereco.Size = new System.Drawing.Size(183, 30);
            this.btn_cadastrarEndereco.TabIndex = 2;
            this.btn_cadastrarEndereco.Text = "Cadastrar Endereço";
            this.btn_cadastrarEndereco.UseVisualStyleBackColor = false;
            this.btn_cadastrarEndereco.Click += new System.EventHandler(this.btn_cadastrarEndereco_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(201, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo";
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cb_sexo.Location = new System.Drawing.Point(201, 168);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(185, 23);
            this.cb_sexo.TabIndex = 8;
            // 
            // btn_salvarCadastro
            // 
            this.btn_salvarCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salvarCadastro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salvarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_salvarCadastro.Location = new System.Drawing.Point(203, 222);
            this.btn_salvarCadastro.Name = "btn_salvarCadastro";
            this.btn_salvarCadastro.Size = new System.Drawing.Size(183, 30);
            this.btn_salvarCadastro.TabIndex = 15;
            this.btn_salvarCadastro.Text = "Salvar Cadastro";
            this.btn_salvarCadastro.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(12, 168);
            this.maskedTextBox2.Mask = "(999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(183, 23);
            this.maskedTextBox2.TabIndex = 17;
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 103);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(374, 23);
            this.dtp_data.TabIndex = 18;
            // 
            // F_NovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 279);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.btn_salvarCadastro);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cadastrarEndereco);
            this.Controls.Add(this.tb_nomeCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_NovoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cliente - Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeCliente;
        private System.Windows.Forms.Button btn_cadastrarEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Button btn_salvarCadastro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DateTimePicker dtp_data;
    }
}