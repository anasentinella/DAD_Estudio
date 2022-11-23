
namespace Estudio
{
    partial class FormCadastrarTurma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxModalidade = new System.Windows.Forms.ComboBox();
            this.maskedtxtHora = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxModalidade);
            this.groupBox1.Controls.Add(this.maskedtxtHora);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtSemana);
            this.groupBox1.Controls.Add(this.txtProfessor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // cbxModalidade
            // 
            this.cbxModalidade.FormattingEnabled = true;
            this.cbxModalidade.Location = new System.Drawing.Point(126, 37);
            this.cbxModalidade.Name = "cbxModalidade";
            this.cbxModalidade.Size = new System.Drawing.Size(248, 21);
            this.cbxModalidade.TabIndex = 10;
            this.cbxModalidade.SelectedIndexChanged += new System.EventHandler(this.cbxModalidade_SelectedIndexChanged);
            // 
            // maskedtxtHora
            // 
            this.maskedtxtHora.Location = new System.Drawing.Point(122, 111);
            this.maskedtxtHora.Mask = "90:00";
            this.maskedtxtHora.Name = "maskedtxtHora";
            this.maskedtxtHora.Size = new System.Drawing.Size(39, 20);
            this.maskedtxtHora.TabIndex = 9;
            this.maskedtxtHora.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(54, 160);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(292, 38);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSemana
            // 
            this.txtSemana.Location = new System.Drawing.Point(126, 86);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(248, 20);
            this.txtSemana.TabIndex = 6;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(126, 60);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(248, 20);
            this.txtProfessor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Professor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia da Semana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // FormCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(456, 268);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastrarTurma";
            this.Text = "Cadastro de Turma";
            this.Load += new System.EventHandler(this.FormCadastrarTurma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedtxtHora;
        private System.Windows.Forms.ComboBox cbxModalidade;
    }
}