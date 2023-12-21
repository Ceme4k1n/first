namespace WindowsFormsApp1
{
    partial class Delete_Form
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
            this.Delete_Grid = new System.Windows.Forms.DataGridView();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.ID_delete_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_prod_button = new System.Windows.Forms.Button();
            this.All_order_button = new System.Windows.Forms.Button();
            this.Delete_product_button = new System.Windows.Forms.Button();
            this.Osnova_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_Grid
            // 
            this.Delete_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Delete_Grid.Location = new System.Drawing.Point(146, 22);
            this.Delete_Grid.Name = "Delete_Grid";
            this.Delete_Grid.Size = new System.Drawing.Size(541, 256);
            this.Delete_Grid.TabIndex = 0;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(334, 323);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(157, 66);
            this.Delete_Button.TabIndex = 1;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // ID_delete_box
            // 
            this.ID_delete_box.Location = new System.Drawing.Point(334, 297);
            this.ID_delete_box.Name = "ID_delete_box";
            this.ID_delete_box.Size = new System.Drawing.Size(157, 20);
            this.ID_delete_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Идентификатор продукта";
            // 
            // Add_prod_button
            // 
            this.Add_prod_button.Location = new System.Drawing.Point(583, 415);
            this.Add_prod_button.Name = "Add_prod_button";
            this.Add_prod_button.Size = new System.Drawing.Size(184, 23);
            this.Add_prod_button.TabIndex = 17;
            this.Add_prod_button.Text = "Добавить продукт";
            this.Add_prod_button.UseVisualStyleBackColor = true;
            this.Add_prod_button.Click += new System.EventHandler(this.Add_prod_button_Click);
            // 
            // All_order_button
            // 
            this.All_order_button.Location = new System.Drawing.Point(393, 415);
            this.All_order_button.Name = "All_order_button";
            this.All_order_button.Size = new System.Drawing.Size(184, 23);
            this.All_order_button.TabIndex = 16;
            this.All_order_button.Text = "Все заказы покупаетля";
            this.All_order_button.UseVisualStyleBackColor = true;
            this.All_order_button.Click += new System.EventHandler(this.All_order_button_Click);
            // 
            // Delete_product_button
            // 
            this.Delete_product_button.Location = new System.Drawing.Point(201, 415);
            this.Delete_product_button.Name = "Delete_product_button";
            this.Delete_product_button.Size = new System.Drawing.Size(186, 23);
            this.Delete_product_button.TabIndex = 15;
            this.Delete_product_button.Text = "Изменить цену продукта";
            this.Delete_product_button.UseVisualStyleBackColor = true;
            this.Delete_product_button.Click += new System.EventHandler(this.Delete_product_button_Click);
            // 
            // Osnova_Button
            // 
            this.Osnova_Button.Location = new System.Drawing.Point(28, 415);
            this.Osnova_Button.Name = "Osnova_Button";
            this.Osnova_Button.Size = new System.Drawing.Size(167, 23);
            this.Osnova_Button.TabIndex = 14;
            this.Osnova_Button.Text = "Главная";
            this.Osnova_Button.UseVisualStyleBackColor = true;
            this.Osnova_Button.Click += new System.EventHandler(this.Osnova_Button_Click);
            // 
            // Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_prod_button);
            this.Controls.Add(this.All_order_button);
            this.Controls.Add(this.Delete_product_button);
            this.Controls.Add(this.Osnova_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_delete_box);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Delete_Grid);
            this.Name = "Delete_Form";
            this.Text = "Delete_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Delete_Grid;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox ID_delete_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_prod_button;
        private System.Windows.Forms.Button All_order_button;
        private System.Windows.Forms.Button Delete_product_button;
        private System.Windows.Forms.Button Osnova_Button;
    }
}