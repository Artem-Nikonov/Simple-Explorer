using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Проводник
{

    public partial class ConfirmForm : Form
    {
        private string path;

        public ConfirmForm()
        {
            InitializeComponent();
        }

        public ConfirmForm(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        public void SubscribeToConfirmButtonEvent(EventHandler act) => button1.Click += act;

        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void button2_Click(object sender, EventArgs e) => this.Close();

        private void ConfirmForm_Load(object sender, EventArgs e) => label1.Text = $"Удалить {path}?";

        private void ConfirmForm_FormClosed(object sender, FormClosedEventArgs e) => GC.Collect();
    }
}
