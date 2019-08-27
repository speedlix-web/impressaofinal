using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace impressaofinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 100, 100);
            e.Graphics.DrawImage(pictureBox1.Image, 100, 600, pictureBox1.Width, pictureBox1.Height);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
