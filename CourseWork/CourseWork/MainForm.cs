using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm newForm = new ClientForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DealerForm newForm = new DealerForm();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DealForm newForm = new DealForm();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBForm newForm = new DBForm();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportsForm newForm = new ReportsForm();
            newForm.Show();
        }
    }
}
