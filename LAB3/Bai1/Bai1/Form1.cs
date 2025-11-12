using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void addEvent(string eventName)
        {
            lbEvents.Items.Add(eventName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LifecycleForm lifecycleForm = new LifecycleForm(this);

            lifecycleForm.Activate();
            lifecycleForm.Show();
        }
    }
}
