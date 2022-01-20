using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMCEngine
{
    public partial class NewProject : Form
    {
        private String projName;

        public NewProject()
        {
            InitializeComponent();
        }

        private void NewProject_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            projName = textBox1.Text;
        }
        
        private void CREATE_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            new Engine.BMCEngine().Show();
        }

        
        private void NewProj_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
