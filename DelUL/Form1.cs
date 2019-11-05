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
            //foreach (var line  in richTextBox1.Lines)
            //{
            //    if (!string.IsNullOrEmpty(line))
            //    {
            //        stringBuilder.Append("<li>");
            //        stringBuilder.Append(line.Replace("  ", " ").Replace("\r\n", "").Replace("\t", ""));
            //        stringBuilder.AppendLine("</li>");
            //    }
            //}
           for(int i =0; i< richTextBox1.Lines.Count(); i ++)
            {
                if (!string.IsNullOrEmpty(richTextBox1.Lines[i]))
                {
                    stringBuilder.Append("<li>");
                    stringBuilder.Append(richTextBox1.Lines[i].Replace("  ", " ").Replace("\r\n", "").Replace("\t", ""));
                    if (richTextBox1.Lines.Count() - i == 1 || (richTextBox1.Lines.Count() - i == 2) && string.IsNullOrEmpty(richTextBox1.Lines.Last())) 
                    {
                        stringBuilder.Append("</li>");
                    }
                    else
                    {
                        stringBuilder.AppendLine("</li>");
                    }
                }
            }

            stringBuilder.Append("</ul>");
            richTextBox1.Text = stringBuilder.ToString();
        }
    }
}
