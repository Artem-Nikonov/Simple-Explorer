using System;
using System.IO;
using System.Windows.Forms;
using Проводник;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinFormsApp1
{
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
            ShowDrives();
            TypeComboBox.Items.Add(type.Папка);
            TypeComboBox.Items.Add(type.Файл);
        }

        private void ShowAllFiles_Click(object sender, EventArgs e)
        {
            string path = PathBox.Text;
            string type = TypeBox.Text;
            if (FileExist(path))
            {
                MessageBox.Show("Вы пытаетесь перейти в файл.");
                return;
            }
            GoToDir(path, type);
            listBox1.ClearSelected();
            PathBox.Text = CurrentDir.Text;
        }

        private void UpdateDirButton_Click(object sender, EventArgs e)
        {
            string path = CurrentDir.Text;
            string type = TypeBox.Text;
            UpdateDir(path, type);
            listBox1.ClearSelected();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            string? path = listBox1?.SelectedItem?.ToString();
            PathBox.Text = path;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            string path = listBox1.SelectedItem.ToString();
            string type = TypeBox.Text;

            if (FileExist(path))
            {
                string fileType = GetFileType(path);
                switch (fileType)
                {
                    case ".txt":
                        OpenTxtFile(path!);
                        return;
                    case ".mp3":
                        OpenMp3File(path!);
                        return;
                    default:
                        MessageBox.Show("Открывать можно только файлы с расширениями (.txt, .mp3)");
                        return;
                }
            }
            GoToDir(path, type);
            listBox1.ClearSelected();
            PathBox.Text = CurrentDir.Text;
        }

        private void GoToParentDir_Click(object sender, EventArgs e)
        {
            string? path = CurrentDir.Text;
            string type = TypeBox.Text;
            GoToParentDirectory(path, type);
            listBox1.ClearSelected();
            PathBox.Text = CurrentDir.Text;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (StringIsNull(nameBox.Text) || StringIsNull(CurrentDir.Text)) return;
            string path = GetCorrectPath(CurrentDir.Text, nameBox.Text);

            switch (TypeComboBox.SelectedItem)
            {
                case type.Папка:
                    CreateDir(path);
                    break;
                case type.Файл:
                    CreateFile(path);
                    break;
                default:
                    MessageBox.Show("Выбирите тип создаваемого объекта.");
                    return;
            }

            UpdateDir(CurrentDir.Text);
            listBox1.SelectedItem = path;
 
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StringIsNull(nameBox.Text) || StringIsNull(CurrentDir.Text)) return;
            string path = GetCorrectPath(CurrentDir.Text, nameBox.Text);
            listBox1.SelectedItem= path;

            switch (TypeComboBox.SelectedItem)
            {
                case type.Папка:
                    OpenConfirmForm(path, DeleteDir);
                    break;
                case type.Файл:
                    OpenConfirmForm(path, DeleteFile);
                    break;
                default:
                    MessageBox.Show("Выбирите тип удаляемого объекта.");
                    return;
            }
            UpdateDir(CurrentDir.Text);
            PathBox.Text = CurrentDir.Text;
            listBox1.ClearSelected();
        }

        private void OpenTxt_Click(object sender, EventArgs e)
        {
            if (StringIsNull(nameBox.Text) || StringIsNull(CurrentDir.Text)) return;
            string path = GetCorrectPath(CurrentDir.Text, nameBox.Text);
            string fileType = GetFileType(path);
            if (DirExist(path) || fileType != ".txt")
            {
                MessageBox.Show("Открывать в редакторе можно только файлы с расширением (.txt)");
                return;
            }
            OpenTxtFile(path);
        }

        private void SetLightThemeButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
            ChangeColor(Color.Gainsboro, Color.Black, listBox1, PathBox, TypeBox, ShowAllFiles,
                                                  panel1, GoToParentDir, UpdateDirButton, panel2,
                                                  label1, nameBox, TypeComboBox, CreateButton,
                                                  DeleteButton, OpenTxt, panel3, label2,
                                                  SetDarkThemeButton, SetLightThemeButton,
                                                  SetFontButton, label3);
        }

        private void SetDarkThemeButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            ChangeColor(Color.Black, Color.Gray, listBox1, PathBox, TypeBox, ShowAllFiles,
                                                  panel1, GoToParentDir, UpdateDirButton, panel2,
                                                  label1, nameBox, TypeComboBox, CreateButton,
                                                  DeleteButton, OpenTxt, panel3, label2,
                                                  SetDarkThemeButton, SetLightThemeButton,
                                                  SetFontButton, label3);
            listBox1.ForeColor = Color.Teal;
            label3.ForeColor = Color.Teal;
        }

        private void SetFontButton_Click(object sender, EventArgs e) => ChangeFont(listBox1);

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) => GC.Collect();

    }
    
}
