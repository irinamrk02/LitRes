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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form formGenre = new FormBooks();
            formGenre.Show();

            FormBooks genre = new FormBooks();
            genre.Show();
            this.Hide();
        }

        private void ButtonAmin_Click(object sender, EventArgs e)
        {
            FormAuthorization authorization = new FormAuthorization();
            authorization.Show();
            this.Hide();
        }
    }
}
