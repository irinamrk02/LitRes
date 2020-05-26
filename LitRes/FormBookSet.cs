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
            listViewBooks.Items.Clear();

            foreach (BookSet book in Program.litRes.BookSet)
            {
                if (book.Genre == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        book.Id.ToString(), book.Title, book.Author, book.Genre.ToString("Классика"), book.Price.ToString()
                    });
                    item.Tag = book;
                    listViewBooks.Items.Add(item);
                }
                else if (book.Genre == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                       book.Id.ToString(), book.Title, book.Author, book.Genre.ToString("Психология"), book.Price.ToString()
                    });
                    item.Tag = book;
                    listViewBooks.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                       book.Id.ToString(), book.Title, book.Author, book.Genre.ToString("Фантастика"), book.Price.ToString()
                    });
                    item.Tag = book;
                    listViewBooks.Items.Add(item);
                }
                listViewBooks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void ListViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 1)
            {
                BookSet book = listViewBooks.SelectedItems[0].Tag as BookSet;
                textBoxTitle.Text = book.Title;
                textBoxAuthor.Text = book.Author;
                comboBoxGenre.Text = book.Genre.ToString();
                textBoxPrice.Text = book.Price.ToString();
            }
            else
            {
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                comboBoxGenre.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }

       

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if ( textBoxTitle.Text != "" && textBoxAuthor.Text != "" && 
                textBoxPrice.Text != "" && comboBoxGenre.SelectedItem != null)
            {
                BookSet book = new BookSet();

                book.Title = textBoxTitle.Text;
                book.Author = textBoxAuthor.Text;

                if (comboBoxGenre.SelectedIndex == 0)
                {
                    book.Genre = 0;
                   
                }
                else if (comboBoxGenre.SelectedIndex == 1)
                {
                    book.Genre = 1;
                    
                }
                else if (comboBoxGenre.SelectedIndex == 2)
                {
                    book.Genre = 2;
                    
                }

                book.Price = Convert.ToInt32(textBoxPrice.Text);

                Program.litRes.BookSet.Add(book);
                Program.litRes.SaveChanges();
                ShowBookSet();
            }
            else
            { MessageBox.Show("Заполните обязательные поля!", "Ошибка", 
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBooks.SelectedItems.Count == 1)
                {
                    BookSet book = listViewBooks.SelectedItems[0].Tag as BookSet;

                    if (textBoxTitle.Text != "" && textBoxAuthor.Text != "" &&
                    textBoxPrice.Text != "" && comboBoxGenre.SelectedItem != null)
                    {
                        throw new Exception("Заполните обязательные поля!");
                    }

                    book.Title = textBoxTitle.Text;
                    book.Author = textBoxAuthor.Text;

                    if (comboBoxGenre.SelectedIndex == 0)
                    {
                        book.Genre = 0;
                    }
                    else if (comboBoxGenre.SelectedIndex == 1)
                    {
                        book.Genre = 1;
                    }
                    else if (comboBoxGenre.SelectedIndex == 2)
                    {
                        book.Genre = 2;
                    }

                    book.Price = Convert.ToInt32(textBoxPrice.Text);

                    Program.litRes.SaveChanges();
                    ShowBookSet();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGenre.SelectedIndex == 0)
                {
                    if (listViewBooks.SelectedItems.Count == 1)
                    {
                        BookSet book = listViewBooks.SelectedItems[0].Tag as BookSet;
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
                    if (listViewBooks.SelectedItems.Count == 1)
                    {
                        BookSet book = listViewBooks.SelectedItems[0].Tag as BookSet;
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
                    if (listViewBooks.SelectedItems.Count == 1)
                    {
                        BookSet book = listViewBooks.SelectedItems[0].Tag as BookSet;
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

