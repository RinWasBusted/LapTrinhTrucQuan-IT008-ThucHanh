using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fontFamilies = FontFamily.Families;
            foreach (var fontFamily in fontFamilies)
            {
                listFont.Items.Add(fontFamily.Name);
            }
        }

        private void listFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string fontName = listFont.Items[e.Index].ToString();
            Font displayFont = null;
            try
            {
                displayFont = new Font(fontName, 12);
            }
            catch
            {
                displayFont = e.Font;
            }

            e.DrawBackground();
            e.Graphics.DrawString(fontName, displayFont, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
            if (displayFont != e.Font)
            {
                displayFont.Dispose();
            }
        }
    }
}
