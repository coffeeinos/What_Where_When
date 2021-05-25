using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace What_Where_When
{
    public partial class Greeting : Form
    {
        public Greeting()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void Greeting_Click(object sender, EventArgs e)
        {
            this.Hide();

            EnteringQuestions enteringQuestions = new EnteringQuestions();

            enteringQuestions.Show();
        }

        private void Greeting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
