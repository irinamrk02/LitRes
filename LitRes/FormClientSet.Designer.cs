namespace LitRes
{
    partial class FormClientSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientSet));
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDel.Font = new System.Drawing.Font("Roboto Light", 16.2F);
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(686, 544);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(160, 54);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewClient.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.listViewClient.FullRowSelect = true;
            this.listViewClient.GridLines = true;
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(257, 88);
            this.listViewClient.MultiSelect = false;
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(589, 439);
            this.listViewClient.TabIndex = 18;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            this.listViewClient.SelectedIndexChanged += new System.EventHandler(this.ListViewClient_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id клиента";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Телефон";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Почта";
            this.columnHeader6.Width = 72;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Книга";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(372, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "Клиенты, сделавшие заказ";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Light", 16.2F);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(507, 544);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(160, 54);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(323, 544);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 54);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Имя *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Фамилия *";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 335);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(212, 32);
            this.textBoxFirstName.TabIndex = 30;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(12, 265);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(212, 32);
            this.textBoxLastName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Телефон *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Отчество *";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(12, 482);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(212, 32);
            this.textBoxPhone.TabIndex = 34;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(12, 408);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(212, 32);
            this.textBoxMiddleName.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Почта *";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(12, 553);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(212, 32);
            this.textBoxEmail.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LitRes.Properties.Resources.litres_logo_rastr;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Items.AddRange(new object[] {
            "Классика",
            "Психология",
            "Фантастика"});
            this.comboBoxBook.Location = new System.Drawing.Point(12, 195);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(212, 32);
            this.comboBoxBook.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Книга *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 48);
            this.label8.TabIndex = 53;
            this.label8.Text = "* отмечены\r\n обязательные поля\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormClientSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(869, 609);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClientSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}