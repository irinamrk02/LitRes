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
    public partial class FormClientSet : Form
    {
        public FormClientSet()
        {
            InitializeComponent();
            ShowClient();
            ShowBook();
        }

        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientSet clientSet in Program.litRes.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientSet.Id.ToString(),clientSet.LastName,
                    clientSet.FirstName,clientSet.MiddleName,
                    clientSet.Phone, clientSet.Email,
                    clientSet.BookSet.Title + " - " + clientSet.BookSet.Author
                });
                item.Tag = clientSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowBook()
        {
            comboBoxBook.Items.Clear();
            foreach (BookSet bookSet in Program.litRes.BookSet)
            {
                string[] item = { bookSet.Id.ToString() + ". ", bookSet.Title + " - " +
                bookSet.Author};
                comboBoxBook.Items.Add(string.Join(" ", item));
            }
        }


        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClientSet clientSet = new ClientSet();

                if (comboBoxBook.SelectedItem != null)
                    clientSet.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                else throw new Exception("Обязательные данные не заполнены");


                if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" ||
                        textBoxMiddleName.Text == "" || textBoxPhone.Text == "" || textBoxEmail.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    
                    clientSet.LastName = textBoxLastName.Text;
                    clientSet.FirstName = textBoxFirstName.Text;
                    clientSet.MiddleName = textBoxMiddleName.Text;
                    clientSet.Phone = textBoxPhone.Text;
                    clientSet.Email = textBoxEmail.Text;
                }
                Program.litRes.ClientSet.Add(clientSet);
                Program.litRes.SaveChanges();
                ShowClient();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

            try
            {
                
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    if (comboBoxBook.SelectedItem != null)
                        clientSet.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                    else throw new Exception("Обязательные данные не заполнены");

                    if (textBoxLastName.Text == "" || textBoxFirstName.Text == "" || 
                        textBoxMiddleName.Text == "" || textBoxPhone.Text == "" || textBoxEmail.Text == "")
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        clientSet.LastName = textBoxLastName.Text;
                        clientSet.FirstName = textBoxFirstName.Text;
                        clientSet.MiddleName = textBoxMiddleName.Text;
                        clientSet.Phone = textBoxPhone.Text;
                        clientSet.Email = textBoxEmail.Text;

                    }
                }

                    Program.litRes.SaveChanges();
                    ShowClient();
                
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void ListViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                textBoxLastName.Text = clientSet.LastName;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmail.Text = clientSet.Email;
                comboBoxBook.Text = clientSet.IdBook.ToString() +"." 
                    + clientSet.BookSet.Title + " - " + clientSet.BookSet.Author; 
            }
            else
            {
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                comboBoxBook.SelectedItem = null;
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.litRes.ClientSet.Remove(clientSet);
                    Program.litRes.SaveChanges();
                    ShowClient();
                }

                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                comboBoxBook.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
