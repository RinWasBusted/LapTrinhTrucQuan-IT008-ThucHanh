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
    public partial class LifecycleForm : Form
    {
        private Form1 _mainForm;
        public LifecycleForm()
        {
            InitializeComponent();
         
        }

        public LifecycleForm(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void LifecycleForm_Load(object sender, EventArgs e)
        {
            _mainForm.addEvent("Load");

        }

        private void LifecycleForm_Activated(object sender, EventArgs e)
        {
            _mainForm.addEvent("Activated");
        }

        private void LifecycleForm_Deactivate(object sender, EventArgs e)
        {
            _mainForm.addEvent("Deactivated");
        }

        private void LifecycleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.addEvent("Form closing");
        }

        private void LifecycleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.addEvent("Form closed");
        }
    }
}
