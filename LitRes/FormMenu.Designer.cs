namespace LitRes
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LitRes.Properties.Resources.litres_logo_rastr;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonBooks.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBooks.Location = new System.Drawing.Point(12, 142);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(360, 80);
            this.buttonBooks.TabIndex = 7;
            this.buttonBooks.Text = "Книги";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.ButtonBooks_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonClients.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClients.Location = new System.Drawing.Point(12, 236);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(360, 80);
            this.buttonClients.TabIndex = 8;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.ButtonClients_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonOrders.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOrders.Location = new System.Drawing.Point(12, 330);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(360, 80);
            this.buttonOrders.TabIndex = 9;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.ButtonOrders_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonBack.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(35, 38);
            this.buttonBack.TabIndex = 54;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(384, 424);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonBack;
    }
}