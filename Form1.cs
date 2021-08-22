﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXT_EDITOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Janela Forms
        }

        #region Menu Arquivo
        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            mArquivoSalvar.Enabled = true;
            Text = Application.ProductName;

            //Incluir metado referente a arquivo em uso e após salva-lo em disco
        }

        private void mArquivoNovaJanela_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();

            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            //>> Incluir metado referente a arquivo em uso e após salva-lo em disco
        
    }

                
        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir...";
            dialog.Filter = "rich text file| *.rtf|texto|*.txt|todos|*.*";

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(dialog.FileName))
                {
                    FileInfo file = new FileInfo(dialog.FileName);
                    Text = Application.ProductName + " - " + file.Name;

                    Gerenciador.FolderPath = file.DirectoryName + "\\";
                    Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Gerenciador.FileExt = file.Extension;

                    //Objeto responsável por ler o arquivo em disco
                    StreamReader stream = null;

                    try
                    {
                        stream = new StreamReader(file.FullName, true);

                        txtConteudo.Text = stream.ReadToEnd();

                        mArquivoSalvar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Formato de arquivo não suportado. \n" + ex.Message);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }

        }

        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar...";
                dialog.Filter = "rich text file| *.rtf|texto|*.txt|todos|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;

                var result = dialog.ShowDialog();

                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvarArquivo(dialog.FileName);

                }
            }

        }

        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar Como...";
                dialog.Filter = "rich text file | *.rtf|texto|*.txt|todos|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;

                var result = dialog.ShowDialog();

                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvarArquivo(dialog.FileName);
                
                }
            
        }
        
        private void SalvarArquivo(string path)
        {
            //Objeto responsável por escrever o arquivo em disco

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(txtConteudo.Text);

                FileInfo file = new FileInfo(path);
                Gerenciador.FolderPath = file.DirectoryName + "\\";
                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Gerenciador.FileExt = file.Extension;

                Text = Application.ProductName + " - " + file.Name;

                mArquivoSalvar.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro Salvar Arquivo: \n" + ex.Message);
            }
            finally
            {
                writer.Close();
            }
        }

        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
                        
        }
        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            mArquivoSalvar.Enabled = true;
        }
        #endregion

        #region Menu Editar

        private void mEditarDesfazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Undo();
            // incluir metado que funcione no metado excluir
        }
        private void mEditarRafazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e)
        {
            txtConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e)
        {
            txtConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e)
        {
            txtConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e)
        {
           txtConteudo.Text = txtConteudo.Text.Remove(txtConteudo.SelectionStart, txtConteudo.SelectedText.Length);
        }

        private void mEditarDataHora_Click(object sender, EventArgs e)
        {
            int index = txtConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            if (txtConteudo.SelectionStart == txtConteudo.Text.Length)
            {
                txtConteudo.Text = txtConteudo.Text + dataHora;
                txtConteudo.SelectionStart = index + dataHora.Length;
                return;
            }
            string temp = "";
            for (int i = 0; i < txtConteudo.Text.Length; i++)
            {
                if (i == txtConteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += txtConteudo.Text[i];
                }
                else
                {
                    temp += txtConteudo.Text[i];
                }
            }

            txtConteudo.Text = temp;
            txtConteudo.SelectionStart = index + dataHora.Length;
        }
        #endregion

        #region Menu Formatar

        private void mFormatarQuebraLinha_Click(object sender, EventArgs e)
        {
            txtConteudo.WordWrap = mFormatarQuebraLinha.Checked;

        }

        private void mFormatarFonte_Click(object sender, EventArgs e)
        {
            FontDialog fonte = new FontDialog();
            fonte.ShowColor = true;
            fonte.ShowEffects = true;

            fonte.Font = txtConteudo.Font;
            fonte.Color = txtConteudo.ForeColor;

            DialogResult result = fonte.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtConteudo.Font = fonte.Font;
                txtConteudo.ForeColor = fonte.Color;
            }
        }

        #endregion

        #region Menu Exibir
        private void mExibirZoomApliar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor += 0.1f;
            AtualizarZoomStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomReduzir_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor -= 0.1f;
            AtualizarZoomStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomRestaurar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor = 1f;
           //statusBarLabel.Text = (txtConteudo.ZoomFactor * 100).ToString();
            AtualizarZoomStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirStatus_Click(object sender, EventArgs e)
        {
            statusBarLabel.Visible = mExibirStatus.Checked;
        }

        private void AtualizarZoomStatusBar(float zoom)
        {
            statusBarLabel.Text = $"{Math.Round(zoom * 100)}%";

        }
        #endregion

        #region Menu Ajuda
        private void mAjudaExibirAjudar_Click(object sender, EventArgs e)
        {
            FormAjuda formAjuda = new FormAjuda();
            formAjuda.Show();
        }

        private void mAjudaSobre_Click(object sender, EventArgs e)
        {
            FormSobre formSobre = new FormSobre();
            formSobre.Show();
        }
        private void mAjuda_Click(object sender, EventArgs e)
        {

        }

        #endregion

        
    }

}
