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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
            comboBoxGenre.SelectedIndex = 0;
            ShowBooks();
        }

        void ShowBooks()
        {
            listViewBooksClassic.Items.Clear();
            listViewBooksPsyhology.Items.Clear();
            listViewBooksFantasy.Items.Clear();

            foreach (BookSet book in Program.litRes.BookSet)
            {
                if (book.Genre == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        book.Id.ToString(), book.Title,
                        book.Author, book.Price.ToString()
                    });
                    item.Tag = book;
                    listViewBooksClassic.Items.Add(item);
                }
                else if (book.Genre == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        book.Id.ToString(), book.Title,
                        book.Author, book.Price.ToString()
                    });
                    item.Tag = book;
                    listViewBooksPsyhology.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        book.Id.ToString(), book.Title,
                        book.Author, book.Price.ToString()
                    });
                    item.Tag = book;
                    listViewBooksFantasy.Items.Add(item);
                }
                listViewBooksClassic.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewBooksPsyhology.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewBooksFantasy.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBuy_Click(object sender, EventArgs e)
        {
          
            Form formBuy = new FormBuy();
            formBuy.Show();
            this.Hide();

        }

        private void ComboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGenre.SelectedIndex == 0)
            {
                listViewBooksClassic.Visible = true;

                listViewBooksPsyhology.Visible = false;
                listViewBooksFantasy.Visible = false;
            }
            else if (comboBoxGenre.SelectedIndex == 1)
            {
                listViewBooksPsyhology.Visible = true;

                listViewBooksClassic.Visible = false;
                listViewBooksFantasy.Visible = false;
            }
            else if (comboBoxGenre.SelectedIndex == 2)
            {
                listViewBooksFantasy.Visible = true;

                listViewBooksPsyhology.Visible = false;
                listViewBooksClassic.Visible = false;
            }
        }

        private void ListViewBooksFantasy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListViewPsyhology_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewBooksFantasy_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    }

