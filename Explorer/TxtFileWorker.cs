using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проводник
{
    internal class TxtFileWorker: ITxtFileWorker
    {
        /*~TxtFileWorker()
        {
            MessageBox.Show("jkpjopj");
        }*/
        public string ReadTxtFIle(string path)
        {
            string text;
            using (StreamReader file = new StreamReader(path))
            {
                text = file.ReadToEnd();
            }
            return text;
        }

        public void WriteTxtFile(string path, string text)
        {
            using (StreamWriter file = new StreamWriter(path, false))
            {
                file.WriteLine(text);
            }
        }
    }


}
