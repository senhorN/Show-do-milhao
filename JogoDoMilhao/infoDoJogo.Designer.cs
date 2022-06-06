
namespace JogoDoMilhao
{
    partial class infoDoJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoDoJogo));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblinfoJogo = new System.Windows.Forms.Label();
            this.imgShowDoMilhao = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowDoMilhao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Blue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(0, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(747, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Informação do jogo ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinfoJogo
            // 
            this.lblinfoJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblinfoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfoJogo.Location = new System.Drawing.Point(12, 67);
            this.lblinfoJogo.Name = "lblinfoJogo";
            this.lblinfoJogo.Size = new System.Drawing.Size(417, 242);
            this.lblinfoJogo.TabIndex = 1;
            this.lblinfoJogo.Text = resources.GetString("lblinfoJogo.Text");
            // 
            // imgShowDoMilhao
            // 
            this.imgShowDoMilhao.BackColor = System.Drawing.Color.Transparent;
            this.imgShowDoMilhao.Image = global::JogoDoMilhao.Properties.Resources.Show_do_milhao_removebg_preview;
            this.imgShowDoMilhao.Location = new System.Drawing.Point(435, 67);
            this.imgShowDoMilhao.Name = "imgShowDoMilhao";
            this.imgShowDoMilhao.Size = new System.Drawing.Size(300, 165);
            this.imgShowDoMilhao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShowDoMilhao.TabIndex = 2;
            this.imgShowDoMilhao.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJogar.Location = new System.Drawing.Point(600, 357);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(124, 37);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // infoDoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDoMilhao.Properties.Resources.fundo_azul_curvas_escuro;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.imgShowDoMilhao);
            this.Controls.Add(this.lblinfoJogo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "infoDoJogo";
            this.Text = "infoDoJogo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imgShowDoMilhao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblinfoJogo;
        private System.Windows.Forms.PictureBox imgShowDoMilhao;
        private System.Windows.Forms.Button btnJogar;
    }
}