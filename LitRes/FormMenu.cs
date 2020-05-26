using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitRes
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBooks_Click(object sender, EventArgs e)
        {
            Form formBook = new FormBookSet();
            formBook.Show();
        }

        private void ButtonClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClientSet();
            formClient.Show();
        }

        private void ButtonOrders_Click(object sender, EventArgs e)
        {
            Form formOrder = new FormOrderSet();
            formOrder.Show();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Form formMain = new Main();
            formMain.Show();
            this.Hide();
        }
    }
}
