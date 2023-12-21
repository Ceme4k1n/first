namespace WindowsFormsApp1
{
    partial class From_Price_Update
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
            this.Price_Update = new System.Windows.Forms.Button();
            this.Get_Id_Box = new System.Windows.Forms.TextBox();
            this.Get_New_Price_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Uppdater_Grid = new System.Windows.Forms.DataGridView();
            this.Osnova_Button = new System.Windows.Forms.Button();
            this.Delete_product_button = new System.Windows.Forms.Button();
            this.All_order_button = new System.Windows.Forms.Button();
            this.Add_prod_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Uppdater_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Price_Update
            // 
            this.Price_Update.Location = new System.Drawing.Point(255, 12);
            this.Price_Update.Name = "Price_Update";
            this.Price_Update.Size = new System.Drawing.Size(268, 62);
            this.Price_Update.TabIndex = 0;
            this.Price_Update.Text = "Изменить цену";
            this.Price_Update.UseVisualStyleBackColor = true;
            this.Price_Update.Click += new System.EventHandler(this.Price_Update_Click);
            // 
            // Get_Id_Box
            // 
            this.Get_Id_Box.Location = new System.Drawing.Point(255, 117);
            this.Get_Id_Box.Name = "Get_Id_Box";
            this.Get_Id_Box.Size = new System.Drawing.Size(100, 20);
            this.Get_Id_Box.TabIndex = 1;
            // 
            // Get_New_Price_Box
            // 
            this.Get_New_Price_Box.Location = new System.Drawing.Point(423, 117);
            this.Get_New_Price_Box.Name = "Get_New_Price_Box";
            this.Get_New_Price_Box.Size = new System.Drawing.Size(100, 20);
            this.Get_New_Price_Box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Новая цена продукта";
            // 
            // Uppdater_Grid
            // 
            this.Uppdater_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Uppdater_Grid.Location = new System.Drawing.Point(134, 188);
            this.Uppdater_Grid.Name = "Uppdater_Grid";
            this.Uppdater_Grid.Size = new System.Drawing.Size(537, 188);
            this.Uppdater_Grid.TabIndex = 5;
            // 
            // Osnova_Button
            // 
            this.Osnova_Button.Location = new System.Drawing.Point(29, 382);
            this.Osnova_Button.Name = "Osnova_Button";
            this.Osnova_Button.Size = new System.Drawing.Size(167, 23);
            this.Osnova_Button.TabIndex = 6;
            this.Osnova_Button.Text = "Главная";
            this.Osnova_Button.UseVisualStyleBackColor = true;
            this.Osnova_Button.Click += new System.EventHandler(this.Osnova_Button_Click);
            // 
            // Delete_product_button
            // 
            this.Delete_product_button.Location = new System.Drawing.Point(202, 382);
            this.Delete_product_button.Name = "Delete_product_button";
            this.Delete_product_button.Size = new System.Drawing.Size(186, 23);
            this.Delete_product_button.TabIndex = 7;
            this.Delete_product_button.Text = "Удалить продукт";
            this.Delete_product_button.UseVisualStyleBackColor = true;
            this.Delete_product_button.Click += new System.EventHandler(this.Delete_product_button_Click);
            // 
            // All_order_button
            // 
            this.All_order_button.Location = new System.Drawing.Point(394, 382);
            this.All_order_button.Name = "All_order_button";
            this.All_order_button.Size = new System.Drawing.Size(184, 23);
            this.All_order_button.TabIndex = 8;
            this.All_order_button.Text = "Все заказы покупаетля";
            this.All_order_button.UseVisualStyleBackColor = true;
            this.All_order_button.Click += new System.EventHandler(this.All_order_button_Click);
            // 
            // Add_prod_button
            // 
            this.Add_prod_button.Location = new System.Drawing.Point(584, 382);
            this.Add_prod_button.Name = "Add_prod_button";
            this.Add_prod_button.Size = new System.Drawing.Size(184, 23);
            this.Add_prod_button.TabIndex = 9;
            this.Add_prod_button.Text = "Добавить продукт";
            this.Add_prod_button.UseVisualStyleBackColor = true;
            this.Add_prod_button.Click += new System.EventHandler(this.Add_prod_button_Click);
            // 
            // From_Price_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_prod_button);
            this.Controls.Add(this.All_order_button);
            this.Controls.Add(this.Delete_product_button);
            this.Controls.Add(this.Osnova_Button);
            this.Controls.Add(this.Uppdater_Grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Get_New_Price_Box);
            this.Controls.Add(this.Get_Id_Box);
            this.Controls.Add(this.Price_Update);
            this.Name = "From_Price_Update";
            this.Text = "From_Price_Update";
            ((System.ComponentModel.ISupportInitialize)(this.Uppdater_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Price_Update;
        private System.Windows.Forms.TextBox Get_Id_Box;
        private System.Windows.Forms.TextBox Get_New_Price_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Uppdater_Grid;
        private System.Windows.Forms.Button Osnova_Button;
        private System.Windows.Forms.Button Delete_product_button;
        private System.Windows.Forms.Button All_order_button;
        private System.Windows.Forms.Button Add_prod_button;
    }
}