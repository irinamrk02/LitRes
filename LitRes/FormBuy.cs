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
    public partial class FormBuy : Form
    {
        public FormBuy()
        {
            InitializeComponent();
            ShowBook();
        }
        void ShowBook()
        {
            comboBoxBook.Items.Clear();
            foreach (BookSet books in Program.litRes.BookSet)
            {
                string[] item = { books.Id.ToString() + ". ", books.Title + " - ", books.Author };
                comboBoxBook.Items.Add(string.Join(" ", item));
            }
        }
        

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ClientSet client = new ClientSet();
                if (comboBoxBook.SelectedItem != null)
                    client.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                else throw new Exception("Обязательные данные не заполнены");

                

                if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" || textBoxMiddleName.Text == "" 
                   || textBoxPhone.Text == "" || textBoxEmail.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    client.LastName = textBoxLastName.Text;
                    client.FirstName = textBoxFirstName.Text;
                    client.MiddleName = textBoxMiddleName.Text;
                    client.Phone = textBoxPhone.Text;
                    client.Email = textBoxEmail.Text;
                }
                MessageBox.Show("Ваш заказ успешно офоромлен! Книга будет отправленна на почту", "Заказ оформлен",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                Program.litRes.ClientSet.Add(client);
                Program.litRes.SaveChanges();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Form formBooks = new FormBooks();
            formBooks.Show();
            this.Hide();
        }
    }
}
