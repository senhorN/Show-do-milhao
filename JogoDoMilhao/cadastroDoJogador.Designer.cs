
namespace JogoDoMilhao
{
    partial class cadastroDoJogador
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
            this.lbltextoCadastro = new System.Windows.Forms.Label();
            this.lbltxtNome = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltextoCadastro
            // 
            this.lbltextoCadastro.BackColor = System.Drawing.Color.Blue;
            this.lbltextoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextoCadastro.ForeColor = System.Drawing.Color.White;
            this.lbltextoCadastro.Location = new System.Drawing.Point(-1, -1);
            this.lbltextoCadastro.Name = "lbltextoCadastro";
            this.lbltextoCadastro.Size = new System.Drawing.Size(332, 58);
            this.lbltextoCadastro.TabIndex = 0;
            this.lbltextoCadastro.Text = "Cadastro";
            this.lbltextoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltxtNome
            // 
            this.lbltxtNome.AutoSize = true;
            this.lbltxtNome.BackColor = System.Drawing.Color.Transparent;
            this.lbltxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtNome.ForeColor = System.Drawing.Color.White;
            this.lbltxtNome.Location = new System.Drawing.Point(138, 153);
            this.lbltxtNome.Name = "lbltxtNome";
            this.lbltxtNome.Size = new System.Drawing.Size(51, 20);
            this.lbltxtNome.TabIndex = 1;
            this.lbltxtNome.Text = "Nome";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.AcceptsTab = true;
            this.txtBoxNome.AccessibleDescription = "";
            this.txtBoxNome.Location = new System.Drawing.Point(45, 185);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(242, 20);
            this.txtBoxNome.TabIndex = 2;
            // 
            // btnCadastar
            // 
            this.btnCadastar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCadastar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastar.ForeColor = System.Drawing.Color.White;
            this.btnCadastar.Location = new System.Drawing.Point(45, 225);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(242, 57);
            this.btnCadastar.TabIndex = 3;
            this.btnCadastar.Text = "Cadastrar";
            this.btnCadastar.UseVisualStyleBackColor = false;
            this.btnCadastar.Click += new System.EventHandler(this.btnCadastar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Yellow;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(13, 72);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(295, 72);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Olá jogador! \r\nInsira seu nome completo para jogar! \r\n";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cadastroDoJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDoMilhao.Properties.Resources.fundo_azul_curvas_escuro;
            this.ClientSize = new System.Drawing.Size(320, 305);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCadastar);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lbltxtNome);
            this.Controls.Add(this.lbltextoCadastro);
            this.Name = "cadastroDoJogador";
            this.Text = "cadastroDoJogador";
            this.Load += new System.EventHandler(this.cadastroDoJogador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltextoCadastro;
        private System.Windows.Forms.Label lbltxtNome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.Label lblInfo;
    }
}