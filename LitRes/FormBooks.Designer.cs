namespace LitRes
{
    partial class FormBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewBooksClassic = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBooksPsyhology = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBooksFantasy = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите жанр";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Классика",
            "Психология",
            "Фантастика"});
            this.comboBoxGenre.Location = new System.Drawing.Point(15, 186);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(299, 32);
            this.comboBoxGenre.TabIndex = 10;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGenre_SelectedIndexChanged);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonBuy.Font = new System.Drawing.Font("Roboto Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuy.Location = new System.Drawing.Point(273, 508);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(160, 54);
            this.buttonBuy.TabIndex = 11;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LitRes.Properties.Resources.litres_logo_rastr;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listViewBooksClassic
            // 
            this.listViewBooksClassic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBooksClassic.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.listViewBooksClassic.FullRowSelect = true;
            this.listViewBooksClassic.GridLines = true;
            this.listViewBooksClassic.HideSelection = false;
            this.listViewBooksClassic.Location = new System.Drawing.Point(15, 237);
            this.listViewBooksClassic.MultiSelect = false;
            this.listViewBooksClassic.Name = "listViewBooksClassic";
            this.listViewBooksClassic.Size = new System.Drawing.Size(418, 265);
            this.listViewBooksClassic.TabIndex = 12;
            this.listViewBooksClassic.UseCompatibleStateImageBehavior = false;
            this.listViewBooksClassic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "книга";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "автор";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "цена";
            // 
            // listViewBooksPsyhology
            // 
            this.listViewBooksPsyhology.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewBooksPsyhology.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.listViewBooksPsyhology.FullRowSelect = true;
            this.listViewBooksPsyhology.GridLines = true;
            this.listViewBooksPsyhology.HideSelection = false;
            this.listViewBooksPsyhology.Location = new System.Drawing.Point(15, 237);
            this.listViewBooksPsyhology.MultiSelect = false;
            this.listViewBooksPsyhology.Name = "listViewBooksPsyhology";
            this.listViewBooksPsyhology.Size = new System.Drawing.Size(418, 265);
            this.listViewBooksPsyhology.TabIndex = 13;
            this.listViewBooksPsyhology.UseCompatibleStateImageBehavior = false;
            this.listViewBooksPsyhology.View = System.Windows.Forms.View.Details;
            this.listViewBooksPsyhology.Visible = false;
            this.listViewBooksPsyhology.SelectedIndexChanged += new System.EventHandler(this.ListViewPsyhology_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "книга";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "автор";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "цена";
            // 
            // listViewBooksFantasy
            // 
            this.listViewBooksFantasy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewBooksFantasy.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewBooksFantasy.FullRowSelect = true;
            this.listViewBooksFantasy.GridLines = true;
            this.listViewBooksFantasy.HideSelection = false;
            this.listViewBooksFantasy.Location = new System.Drawing.Point(15, 237);
            this.listViewBooksFantasy.MultiSelect = false;
            this.listViewBooksFantasy.Name = "listViewBooksFantasy";
            this.listViewBooksFantasy.Size = new System.Drawing.Size(418, 265);
            this.listViewBooksFantasy.TabIndex = 14;
            this.listViewBooksFantasy.UseCompatibleStateImageBehavior = false;
            this.listViewBooksFantasy.View = System.Windows.Forms.View.Details;
            this.listViewBooksFantasy.Visible = false;
            this.listViewBooksFantasy.SelectedIndexChanged += new System.EventHandler(this.ListViewBooksFantasy_SelectedIndexChanged_1);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "id";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "книга";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "автор";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "цена";
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(445, 574);
            this.Controls.Add(this.listViewBooksFantasy);
            this.Controls.Add(this.listViewBooksPsyhology);
            this.Controls.Add(this.listViewBooksClassic);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.ListView listViewBooksClassic;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewBooksPsyhology;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listViewBooksFantasy;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}