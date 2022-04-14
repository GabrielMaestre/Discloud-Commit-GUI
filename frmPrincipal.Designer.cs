
namespace Discloud_Commit
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.chkRestart = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(100, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 49);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Upload/Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlUpload
            // 
            this.pnlUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUpload.BackgroundImage")));
            this.pnlUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUpload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpload.Location = new System.Drawing.Point(0, 215);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(384, 146);
            this.pnlUpload.TabIndex = 1;
            this.pnlUpload.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlUpload_DragDrop);
            this.pnlUpload.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlUpload_DragEnter);
            this.pnlUpload.DoubleClick += new System.EventHandler(this.pnlUpload_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID do BOT";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(55, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(248, 27);
            this.txtID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(137, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "API Token";
            // 
            // txtToken
            // 
            this.txtToken.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtToken.Location = new System.Drawing.Point(55, 90);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(248, 27);
            this.txtToken.TabIndex = 5;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(12, 196);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(179, 16);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Local do Arquivo (Zipado)";
            // 
            // chkRestart
            // 
            this.chkRestart.AutoSize = true;
            this.chkRestart.Enabled = false;
            this.chkRestart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkRestart.Location = new System.Drawing.Point(264, 152);
            this.chkRestart.Name = "chkRestart";
            this.chkRestart.Size = new System.Drawing.Size(88, 20);
            this.chkRestart.TabIndex = 7;
            this.chkRestart.Text = "Reniciar?";
            this.chkRestart.UseVisualStyleBackColor = true;
            this.chkRestart.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(40, 40);
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.chkRestart);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlUpload);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discloud Commit";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.CheckBox chkRestart;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

