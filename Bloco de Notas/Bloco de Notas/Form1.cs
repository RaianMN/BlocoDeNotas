using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_Notas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // "|*.txt" = filtro, quer dizer que o progrma so abrira
            // arquivos txt
            openFileDialog1.Filter = "Arquivos de texto |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName,
                    RichTextBoxStreamType.PlainText);
            }
                                         
            
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
             saveFileDialog1.Filter = "Arquivos de texto |*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK
                && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,
                    RichTextBoxStreamType.PlainText);
            
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() ==  DialogResult.OK)
            {
                this.richTextBox1.Font = fontDialog1.Font;

            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
