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
    public partial class moshtari_form : Form
    {
        public moshtari_form()
        {
            InitializeComponent();
        }

        private void moshtari_form_Load(object sender, EventArgs e)
        {
            string[] line = File.ReadAllLines("sample.csv");
            for (int i = 0; i < line.Length; i++)
            {
                listBox1.Items.Add(line[i]);
            }

        }
    }
}
