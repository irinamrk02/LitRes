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
    public partial class FormBookSet : Form
    {
        public FormBookSet()
        {
            InitializeComponent();
            comboBoxGenre.SelectedIndex = 0;
            ShowBookSet();
        }

        void ShowBookSet()
        {
            listViewClassic.Items.Clear();
            listViewPsychology.Items.Clear();
            listViewFantasy.Items.Clear();

            foreach (BookSet book in Program.litRes.BookSet)
            {
                if (book.Genre == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        book.Title, book.Author, book.Price.ToString()
                    });
                    item.Tag = book;
                    listViewClassic.Items.Add(item);
                }
                else if (book.Genre == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        book.Title, book.Author, book.Price.ToString()
                    });
                    item.Tag = book;
                    listViewPsychology.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        book.Title, book.Author, book.Price.ToString()
                    });
                    item.Tag = book;
                    listViewFantasy.Items.Add(item);
                }
                listViewClassic.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewPsychology.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewFantasy.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //классика
            if (comboBoxGenre.SelectedIndex == 0)
            {
                listViewClassic.Visible = true;

                listViewPsychology.Visible = false;
                listViewFantasy.Visible = false;

                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPrice.Text = "";
            }

            //психология
            else if (comboBoxGenre.SelectedIndex == 1)
            {
                listViewPsychology.Visible = true;
                
                listViewClassic.Visible = false;
                listViewFantasy.Visible = false;

                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPrice.Text = "";
            }

            //фантастика
            else if (comboBoxGenre.SelectedIndex == 2)
            {
                listViewFantasy.Visible = true;
                
                listViewClassic.Visible = false;
                listViewPsychology.Visible = false;

                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void ListViewClassic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClassic.SelectedItems.Count == 1)
            {
                BookSet book = listViewClassic.SelectedItems[0].Tag as BookSet;
                textBoxTitle.Text = book.Title;
                textBoxAuthor.Text = book.Author;
                textBoxPrice.Text = book.Price.ToString();
            }
            else
            {
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void ListViewPsychology_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClassic.SelectedItems.Count == 1)
            {
                BookSet book = listViewPsychology.SelectedItems[0].Tag as BookSet;
                textBoxTitle.Text = book.Title;
                textBoxAuthor.Text = book.Author;
                textBoxPrice.Text = book.Price.ToString();
            }
            else
            {
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void ListViewFantasy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClassic.SelectedItems.Count == 1)
            {
                BookSet book = listViewFantasy.SelectedItems[0].Tag as BookSet;
                textBoxTitle.Text = book.Title;
                textBoxAuthor.Text = book.Author;
                textBoxPrice.Text = book.Price.ToString();
            }
            else
            {
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                BookSet book = new BookSet();
                book.Title = textBoxTitle.Text;
                book.Author = textBoxAuthor.Text;
                book.Price = Convert.ToInt32(textBoxPrice.Text);

                Program.litRes.BookSet.Add(book);
                Program.litRes.SaveChanges();
                ShowBookSet();
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message, "Ошибка", 
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                BookSet book = new BookSet();
                book.Title = textBoxTitle.Text;
                book.Author = textBoxAuthor.Text;
                book.Price = Convert.ToInt32(textBoxPrice.Text);

                Program.litRes.SaveChanges();
                ShowBookSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Ошибка",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGenre.SelectedIndex == 0)
                {
                    if (listViewClassic.SelectedItems.Count == 1)
                    {
                        BookSet book = listViewClassic.SelectedItems[0].Tag as BookSet;
                        Program.litRes.BookSet.Remove(book);
                        Program.litRes.SaveChanges();
                        ShowBookSet();
                    }
                    textBoxTitle.Text = "";
                    textBoxAuthor.Text = "";
                    textBoxPrice.Text = "";
                }
                else if (comboBoxGenre.SelectedIndex == 1)
                {
                    if (listViewPsychology.SelectedItems.Count == 1)
                    {
                        BookSet book = listViewPsychology.SelectedItems[0].Tag as BookSet;
                        Program.litRes.BookSet.Remove(book);
                        Program.litRes.SaveChanges();
                        ShowBookSet();
                    }
                    textBoxTitle.Text = "";
                    textBoxAuthor.Text = "";
                    textBoxPrice.Text = "";
                }
                else if (comboBoxGenre.SelectedIndex == 2)
                {
                    if (listViewFantasy.SelectedItems.Count == 1)
                    {
                        BookSet book = listViewFantasy.SelectedItems[0].Tag as BookSet;
                        Program.litRes.BookSet.Remove(book);
                        Program.litRes.SaveChanges();
                        ShowBookSet();
                    }
                    textBoxTitle.Text = "";
                    textBoxAuthor.Text = "";
                    textBoxPrice.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
