using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelUL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<ul>");
            foreach (var line  in richTextBox1.Lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    stringBuilder.Append("<li>");
                    stringBuilder.Append(line.Replace("  ", " ").Replace("\r\n", "").Replace("\t", ""));
                    stringBuilder.AppendLine("</li>");
                }
            }
            stringBuilder.AppendLine("</ul>");
            richTextBox1.Text = stringBuilder.ToString();
        }
    }
}
