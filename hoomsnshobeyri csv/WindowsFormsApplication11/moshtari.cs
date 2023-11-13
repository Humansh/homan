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

namespace WindowsFormsApplication11
{
    public partial class moshtari : Form
    {
        public string stdname { get; set; }
        public moshtari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string family = textBox2.Text;
            string tel = textBox3.Text;
            string line = name + "," + family + "," + tel+"\n";
            File.AppendAllText("sample.csv", line);
        }
    }
}
