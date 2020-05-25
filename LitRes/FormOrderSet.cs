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
    public partial class FormOrderSet : Form
    {
        public FormOrderSet()
        {
            InitializeComponent();
            ShowClients();
            ShowOrderSet();
        }

        void ShowClients()
        {
            comboBoxOrder.Items.Clear();
            foreach (ClientSet client in Program.litRes.ClientSet)
            {
                string[] item = {client.Id.ToString(), client.LastName + " " 
                 + client.FirstName + " " + client.MiddleName,
                 "Книга: " + client.IdBook.ToString() + ".", client.BookSet.Title };
                comboBoxOrder.Items.Add(string.Join(" ", item));
            }
        }

        void ShowOrderSet()
        {
            listViewOrder.Items.Clear();
            foreach (OrderSet order in Program.litRes.OrderSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    order.Id.ToString(),
                    order.IdClient.ToString() + ". ",
                    order.ClientSet.LastName +
                    order.ClientSet.FirstName.Remove(1) + "." +
                    order.ClientSet.MiddleName.Remove(1) + ".",
                    order.ClientSet.IdBook.ToString() + ".",
                    order.ClientSet.BookSet.Title + " - " +
                    order.ClientSet.BookSet.Author,
                    order.Status.ToString()
                });
                    item.Tag = order;
                    listViewOrder.Items.Add(item);
                
            }
            listViewOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ListViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                OrderSet orderSet = listViewOrder.SelectedItems[0].Tag as OrderSet;

                comboBoxOrder.Text = orderSet.IdClient.ToString() + ". " +
                orderSet.ClientSet.LastName + " " + orderSet.ClientSet.FirstName + " - " +
                orderSet.ClientSet.IdBook.ToString() + ". " + orderSet.ClientSet.BookSet.Title; 
                comboBoxStatus.Text = orderSet.Status.ToString();
            }
            else
            {
                comboBoxOrder.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OrderSet order = new OrderSet();

                if (comboBoxOrder.SelectedItem != null)
                    order.IdClient = Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]);
                else throw new Exception("Обязательные данные не заполнены");

                if (comboBoxStatus.SelectedItem != null)
                    order.Status = Convert.ToInt32(comboBoxStatus.SelectedItem.ToString());
                else order.Status = null;

                
                Program.litRes.OrderSet.Add(order);
                Program.litRes.SaveChanges();
                ShowOrderSet();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormOrderSet_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
