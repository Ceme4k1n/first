namespace WindowsFormsApp1
{
    partial class ALL_Form
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
            this.ALL_grid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_prod_button = new System.Windows.Forms.Button();
            this.All_order_button = new System.Windows.Forms.Button();
            this.Delete_product_button = new System.Windows.Forms.Button();
            this.Osnova_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ALL_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ALL_grid
            // 
            this.ALL_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ALL_grid.Location = new System.Drawing.Point(189, 12);
            this.ALL_grid.Name = "ALL_grid";
            this.ALL_grid.Size = new System.Drawing.Size(437, 275);
            this.ALL_grid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_prod_button
            // 
            this.Add_prod_button.Location = new System.Drawing.Point(588, 415);
            this.Add_prod_button.Name = "Add_prod_button";
            this.Add_prod_button.Size = new System.Drawing.Size(184, 23);
            this.Add_prod_button.TabIndex = 17;
            this.Add_prod_button.Text = "Добавить продукт";
            this.Add_prod_button.UseVisualStyleBackColor = true;
            this.Add_prod_button.Click += new System.EventHandler(this.Add_prod_button_Click);
            // 
            // All_order_button
            // 
            this.All_order_button.Location = new System.Drawing.Point(398, 415);
            this.All_order_button.Name = "All_order_button";
            this.All_order_button.Size = new System.Drawing.Size(184, 23);
            this.All_order_button.TabIndex = 16;
            this.All_order_button.Text = "Изменить цену продукта";
            this.All_order_button.UseVisualStyleBackColor = true;
            this.All_order_button.Click += new System.EventHandler(this.All_order_button_Click);
            // 
            // Delete_product_button
            // 
            this.Delete_product_button.Location = new System.Drawing.Point(206, 415);
            this.Delete_product_button.Name = "Delete_product_button";
            this.Delete_product_button.Size = new System.Drawing.Size(186, 23);
            this.Delete_product_button.TabIndex = 15;
            this.Delete_product_button.Text = "Удалить продукт";
            this.Delete_product_button.UseVisualStyleBackColor = true;
            this.Delete_product_button.Click += new System.EventHandler(this.Delete_product_button_Click);
            // 
            // Osnova_Button
            // 
            this.Osnova_Button.Location = new System.Drawing.Point(33, 415);
            this.Osnova_Button.Name = "Osnova_Button";
            this.Osnova_Button.Size = new System.Drawing.Size(167, 23);
            this.Osnova_Button.TabIndex = 14;
            this.Osnova_Button.Text = "Главная";
            this.Osnova_Button.UseVisualStyleBackColor = true;
            this.Osnova_Button.Click += new System.EventHandler(this.Osnova_Button_Click);
            // 
            // ALL_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_prod_button);
            this.Controls.Add(this.All_order_button);
            this.Controls.Add(this.Delete_product_button);
            this.Controls.Add(this.Osnova_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ALL_grid);
            this.Name = "ALL_Form";
            this.Text = "ALL_Form";
            ((System.ComponentModel.ISupportInitialize)(this.ALL_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ALL_grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add_prod_button;
        private System.Windows.Forms.Button All_order_button;
        private System.Windows.Forms.Button Delete_product_button;
        private System.Windows.Forms.Button Osnova_Button;
    }
}