using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проводник
{
    public partial class TxtRedactor : Form
    {
        private string FilePath = "";
        private TxtFileWorker txtFileWorker = new TxtFileWorker();
        private string OldText = "";

        public TxtRedactor()
        {
            InitializeComponent();
        }

        public TxtRedactor(string FilePath) 
        {
            InitializeComponent();
            this.FilePath = FilePath;
        }

        private void TxtRedactor_Load(object sender, EventArgs e)
        {
            Text+= $" (файл: {FilePath})";
            textOfFile.Text = ReadTxt(FilePath);
        }

        private void TxtRedactor_FormClosed(object sender, FormClosedEventArgs e) => GC.Collect();

        private void SaveTxtFileButton_Click(object sender, EventArgs e)
        {
            string text = textOfFile.Text;
            WriteTxt(FilePath, text);

        }

        private void RemoveTextButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textOfFile.Text))
            {
                MessageBox.Show("Удалять нечего");
                return;
            }
            OldText= textOfFile.Text;
            textOfFile.Text = "";
        }

        private void RestoreTextButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(OldText))
            {
                MessageBox.Show("Восстанавливать нечего");
                return;
            }
            string currentText = textOfFile.Text;
            textOfFile.Text = OldText;
            OldText = currentText;
        }

        private void FontSettings_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textOfFile.Font = fontDialog1.Font;
        }


        //вспомогательные методы
        private string ReadTxt(string path) => txtFileWorker.ReadTxtFIle(path);

        private void WriteTxt(string path, string text) => txtFileWorker.WriteTxtFile(path, text);
    }
}
