
namespace Estudio
{
    partial class FormExcluirTurma
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cbxDiaSemana = new System.Windows.Forms.ComboBox();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.cbxModalidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.cbxDiaSemana);
            this.groupBox1.Controls.Add(this.cbxHora);
            this.groupBox1.Controls.Add(this.cbxModalidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(64, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.Location = new System.Drawing.Point(63, 168);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(238, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir ";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cbxDiaSemana
            // 
            this.cbxDiaSemana.FormattingEnabled = true;
            this.cbxDiaSemana.Location = new System.Drawing.Point(131, 70);
            this.cbxDiaSemana.Name = "cbxDiaSemana";
            this.cbxDiaSemana.Size = new System.Drawing.Size(170, 21);
            this.cbxDiaSemana.TabIndex = 5;
            this.cbxDiaSemana.SelectedIndexChanged += new System.EventHandler(this.cbxDiaSemana_SelectedIndexChanged);
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(131, 106);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(170, 21);
            this.cbxHora.TabIndex = 4;
            // 
            // cbxModalidade
            // 
            this.cbxModalidade.FormattingEnabled = true;
            this.cbxModalidade.Location = new System.Drawing.Point(131, 32);
            this.cbxModalidade.Name = "cbxModalidade";
            this.cbxModalidade.Size = new System.Drawing.Size(170, 21);
            this.cbxModalidade.TabIndex = 3;
            this.cbxModalidade.SelectedIndexChanged += new System.EventHandler(this.cbxModalidade_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia da Semana :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // FormExcluirTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(482, 320);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormExcluirTurma";
            this.Text = "Excluir Turma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cbxDiaSemana;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.ComboBox cbxModalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}