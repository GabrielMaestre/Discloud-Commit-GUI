using System;
using System.Drawing;
using System.Windows.Forms;

using System.Net;
using System.IO;
using RestSharp;

//Feito por: Gabriel Maestre // PINGUIN.ZIP
namespace Discloud_Commit
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        string lastFile = "";

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 80, 120, 184);
            this.ForeColor = Color.White;

            this.pnlUpload.AllowDrop = true;
            this.pnlUpload.BackColor = Color.FromArgb(255, 54, 85, 133);
        }

        private void pnlUpload_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlUpload_DragDrop(object sender, DragEventArgs e)
        {
            lblPath.Text = e.Data.GetData(DataFormats.FileDrop).ToString();
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach(string file in droppedFiles)
            {
                string fileName = getFileName(file);
                lastFile = Path.GetFullPath(file);
                lblPath.Text = lastFile;
            }
        }
        private string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        private string getFileNameWith(string path)
        {
            return Path.GetFileName(path);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtToken.Text == "")
                MessageBox.Show("Campos Vazios; ID ou TOKEN", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                var botID = txtID.Text;
                var tokenAPI = txtToken.Text;
                bool restartBot;

                if (chkRestart.Checked)
                    restartBot = true;
                else
                    restartBot = false;

                var client = new RestClient($"https://discloud.app/status/bot/{botID}/commit?restart={restartBot}");
                var request = new RestRequest($"https://discloud.app/status/bot/{botID}/commit?restart={restartBot}", Method.POST);
                request.AddFile("file", lastFile, "zip");
                request.AddHeader("Content-Type", "multipart/form-data");
                request.AddHeader("api-token", tokenAPI);

                try
                {
                    client.ExecuteAsync(request, response =>
                    {
                        if (response.StatusCode == HttpStatusCode.OK)// OK
                        {
                         Console.WriteLine("HTTP STATUS CODE: OK");
                            MessageBox.Show("Arquivos enviados com Sucesso! Seu bot será Reniciado assim que terminar o Upload.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else// NOT OK
                        {
                         Console.WriteLine("HTTP STATUS CODE: NO RESPONSE");
                            MessageBox.Show("Falha ao Enviar os Arquivos.\nVerifique seu TOKEN de API\nVerifique o ID do Bot.\n Verifique se ZIPou certo sua pasta.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtID.Clear();
                            txtToken.Clear();
                        }

                        Console.WriteLine(response.Content);
                    });
                }
                catch (Exception b)
                {
                    // Log
                    Console.WriteLine(b);
                }
            }//ELSE
        }//BtnSubmit

        private void pnlUpload_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog upFileDialog = new OpenFileDialog();
            upFileDialog.Filter = "Zip Files (*.ZIP)|*.ZIP";
            upFileDialog.ReadOnlyChecked = true;
            upFileDialog.ShowReadOnly = true;
            upFileDialog.Multiselect = false;

            if (upFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = upFileDialog.FileName;
            }
        }
    }
}