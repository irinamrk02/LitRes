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
            ShowOrder();
        }

        void ShowClients()
        {
            comboBoxOrder.Items.Clear();
            foreach (ClientSet client in Program.litRes.ClientSet)
            {
                string[] item = {client.Id.ToString() + ". ", client.LastName + " " 
                 + client.FirstName + " " + client.MiddleName,
                 "Книга: " + client.IdBook.ToString() + ".", client.BookSet.Title};
                comboBoxOrder.Items.Add(string.Join(" ", item));
            }
        }

       void ShowOrder()
        {
            listViewOrder.Items.Clear();
            foreach (OrderSet order in Program.litRes.OrderSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    order.Id.ToString(),
                    order.IdClient.ToString(),
                    order.ClientSet.LastName + " " + order.ClientSet.FirstName + " " + order.ClientSet.MiddleName,
                    order.ClientSet.IdBook.ToString(),
                    order.ClientSet.BookSet.Title,
                    order.Status
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

                comboBoxOrder.Text = orderSet.IdClient.ToString() + " " + orderSet.ClientSet.LastName +
                    " " + orderSet.ClientSet.FirstName + " " + orderSet.ClientSet.MiddleName + " " +
                    orderSet.ClientSet.IdBook.ToString() + " " + orderSet.ClientSet.BookSet.Title;
                comboBoxStatus.Text = orderSet.Status;
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
                    order.Status = comboBoxStatus.SelectedItem.ToString();
                else order.Status = null;

                
                Program.litRes.OrderSet.Add(order);
                Program.litRes.SaveChanges();
                ShowOrder();
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

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrder.SelectedItems.Count == 1)
                {
                    OrderSet order = listViewOrder.SelectedItems[0].Tag as OrderSet;

                    if (comboBoxOrder.SelectedItem != null)
                        order.IdClient = Convert.ToInt32(comboBoxOrder.SelectedItem.ToString().Split('.')[0]);
                    else throw new Exception("Обязательные данные не заполнены");

                    if (comboBoxStatus.SelectedItem != null)
                        order.Status = comboBoxStatus.SelectedItem.ToString();
                    else order.Status = null;

                    Program.litRes.SaveChanges();
                    ShowOrder();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrder.SelectedItems.Count == 1)
                {
                    OrderSet order = listViewOrder.SelectedItems[0].Tag as OrderSet;

                    Program.litRes.OrderSet.Remove(order);
                    Program.litRes.SaveChanges();
                    ShowOrder();
                }
                comboBoxStatus.Text = "";
                comboBoxOrder.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
