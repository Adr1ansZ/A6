namespace A6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsobrenome = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.btnveri = new System.Windows.Forms.Button();
            this.picimagem = new System.Windows.Forms.PictureBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblresult1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsobrenome = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(237, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(391, 41);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Bem vindo a África.";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(1, 98);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(96, 30);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome:";
            // 
            // lblsobrenome
            // 
            this.lblsobrenome.AutoSize = true;
            this.lblsobrenome.BackColor = System.Drawing.Color.Transparent;
            this.lblsobrenome.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsobrenome.Location = new System.Drawing.Point(1, 180);
            this.lblsobrenome.Name = "lblsobrenome";
            this.lblsobrenome.Size = new System.Drawing.Size(170, 30);
            this.lblsobrenome.TabIndex = 2;
            this.lblsobrenome.Text = "Sobrenome:";
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.BackColor = System.Drawing.Color.Transparent;
            this.lblano.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblano.Location = new System.Drawing.Point(7, 270);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(75, 30);
            this.lblano.TabIndex = 3;
            this.lblano.Text = "Ano:";
            // 
            // btnveri
            // 
            this.btnveri.Location = new System.Drawing.Point(41, 352);
            this.btnveri.Name = "btnveri";
            this.btnveri.Size = new System.Drawing.Size(75, 23);
            this.btnveri.TabIndex = 4;
            this.btnveri.Text = "Verificar:";
            this.btnveri.UseVisualStyleBackColor = true;
            this.btnveri.Click += new System.EventHandler(this.btnveri_Click);
            // 
            // picimagem
            // 
            this.picimagem.Image = global::A6.Properties.Resources.saudem_todos_o_rei_julien_maurice_mork_960x720;
            this.picimagem.Location = new System.Drawing.Point(435, 98);
            this.picimagem.Name = "picimagem";
            this.picimagem.Size = new System.Drawing.Size(295, 297);
            this.picimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimagem.TabIndex = 5;
            this.picimagem.TabStop = false;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(418, 410);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(58, 13);
            this.lblresult.TabIndex = 6;
            this.lblresult.Text = "Resultado:";
            this.lblresult.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblresult1
            // 
            this.lblresult1.AutoSize = true;
            this.lblresult1.BackColor = System.Drawing.Color.Transparent;
            this.lblresult1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult1.Location = new System.Drawing.Point(560, 401);
            this.lblresult1.Name = "lblresult1";
            this.lblresult1.Size = new System.Drawing.Size(0, 42);
            this.lblresult1.TabIndex = 7;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(103, 105);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 8;
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.Location = new System.Drawing.Point(177, 190);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtsobrenome.TabIndex = 9;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(88, 277);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(100, 20);
            this.txtano.TabIndex = 10;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(139, 351);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A6.Properties.Resources.AAAABfyfbYCOrOGvKdJLqNfSXwEEw1BSp4gTX_trxbJ8KBqT08aWEO8PmdHe5MmD0TrYObYw1YaS2A1B99FdlPcsIi_AjERXdXQElGvA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.txtsobrenome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblresult1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.picimagem);
            this.Controls.Add(this.btnveri);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblsobrenome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsobrenome;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Button btnveri;
        private System.Windows.Forms.PictureBox picimagem;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblresult1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsobrenome;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Button btnlimpar;
    }
}

