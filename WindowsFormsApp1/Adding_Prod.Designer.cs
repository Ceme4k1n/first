namespace WindowsFormsApp1
{
    partial class Adding_Prod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adding_Prod));
            this.Adding_Button = new System.Windows.Forms.Button();
            this.Adder_prod_Grid = new System.Windows.Forms.DataGridView();
            this.Name_Prod = new System.Windows.Forms.TextBox();
            this.Price_prod = new System.Windows.Forms.TextBox();
            this.Prod_Category = new System.Windows.Forms.TextBox();
            this.Prod_provider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_prod_button = new System.Windows.Forms.Button();
            this.All_order_button = new System.Windows.Forms.Button();
            this.Delete_product_button = new System.Windows.Forms.Button();
            this.Osnova_Button = new System.Windows.Forms.Button();
            this.rabotaDataSet = new WindowsFormsApp1.RabotaDataSet();
            this.last_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.last_orderTableAdapter = new WindowsFormsApp1.RabotaDataSetTableAdapters.last_orderTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.RabotaDataSetTableAdapters.TableAdapterManager();
            this.last_orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.last_orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Adder_prod_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_orderBindingNavigator)).BeginInit();
            this.last_orderBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adding_Button
            // 
            this.Adding_Button.Location = new System.Drawing.Point(292, 312);
            this.Adding_Button.Name = "Adding_Button";
            this.Adding_Button.Size = new System.Drawing.Size(229, 50);
            this.Adding_Button.TabIndex = 0;
            this.Adding_Button.Text = "Добавить";
            this.Adding_Button.UseVisualStyleBackColor = true;
            this.Adding_Button.Click += new System.EventHandler(this.Adding_Button_Click);
            // 
            // Adder_prod_Grid
            // 
            this.Adder_prod_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Adder_prod_Grid.Location = new System.Drawing.Point(134, 12);
            this.Adder_prod_Grid.Name = "Adder_prod_Grid";
            this.Adder_prod_Grid.Size = new System.Drawing.Size(542, 246);
            this.Adder_prod_Grid.TabIndex = 1;
            // 
            // Name_Prod
            // 
            this.Name_Prod.Location = new System.Drawing.Point(95, 286);
            this.Name_Prod.Name = "Name_Prod";
            this.Name_Prod.Size = new System.Drawing.Size(100, 20);
            this.Name_Prod.TabIndex = 2;
            // 
            // Price_prod
            // 
            this.Price_prod.Location = new System.Drawing.Point(263, 286);
            this.Price_prod.Name = "Price_prod";
            this.Price_prod.Size = new System.Drawing.Size(106, 20);
            this.Price_prod.TabIndex = 3;
            // 
            // Prod_Category
            // 
            this.Prod_Category.Location = new System.Drawing.Point(428, 286);
            this.Prod_Category.Name = "Prod_Category";
            this.Prod_Category.Size = new System.Drawing.Size(106, 20);
            this.Prod_Category.TabIndex = 4;
            // 
            // Prod_provider
            // 
            this.Prod_provider.Location = new System.Drawing.Point(593, 286);
            this.Prod_provider.Name = "Prod_provider";
            this.Prod_provider.Size = new System.Drawing.Size(106, 20);
            this.Prod_provider.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Наименование товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стоимость товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер Категории";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер Поставщика";
            // 
            // Add_prod_button
            // 
            this.Add_prod_button.Location = new System.Drawing.Point(584, 382);
            this.Add_prod_button.Name = "Add_prod_button";
            this.Add_prod_button.Size = new System.Drawing.Size(184, 23);
            this.Add_prod_button.TabIndex = 13;
            this.Add_prod_button.Text = "Изменить цену продукта";
            this.Add_prod_button.UseVisualStyleBackColor = true;
            this.Add_prod_button.Click += new System.EventHandler(this.Add_prod_button_Click);
            // 
            // All_order_button
            // 
            this.All_order_button.Location = new System.Drawing.Point(394, 382);
            this.All_order_button.Name = "All_order_button";
            this.All_order_button.Size = new System.Drawing.Size(184, 23);
            this.All_order_button.TabIndex = 12;
            this.All_order_button.Text = "Все заказы покупаетля";
            this.All_order_button.UseVisualStyleBackColor = true;
            this.All_order_button.Click += new System.EventHandler(this.All_order_button_Click);
            // 
            // Delete_product_button
            // 
            this.Delete_product_button.Location = new System.Drawing.Point(202, 382);
            this.Delete_product_button.Name = "Delete_product_button";
            this.Delete_product_button.Size = new System.Drawing.Size(186, 23);
            this.Delete_product_button.TabIndex = 11;
            this.Delete_product_button.Text = "Удалить продукт";
            this.Delete_product_button.UseVisualStyleBackColor = true;
            this.Delete_product_button.Click += new System.EventHandler(this.Delete_product_button_Click);
            // 
            // Osnova_Button
            // 
            this.Osnova_Button.Location = new System.Drawing.Point(29, 382);
            this.Osnova_Button.Name = "Osnova_Button";
            this.Osnova_Button.Size = new System.Drawing.Size(167, 23);
            this.Osnova_Button.TabIndex = 10;
            this.Osnova_Button.Text = "Главная";
            this.Osnova_Button.UseVisualStyleBackColor = true;
            this.Osnova_Button.Click += new System.EventHandler(this.Osnova_Button_Click);
            // 
            // rabotaDataSet
            // 
            this.rabotaDataSet.DataSetName = "RabotaDataSet";
            this.rabotaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // last_orderBindingSource
            // 
            this.last_orderBindingSource.DataMember = "last_order";
            this.last_orderBindingSource.DataSource = this.rabotaDataSet;
            // 
            // last_orderTableAdapter
            // 
            this.last_orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.last_orderTableAdapter = this.last_orderTableAdapter;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.providerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.RabotaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // last_orderBindingNavigator
            // 
            this.last_orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.last_orderBindingNavigator.BindingSource = this.last_orderBindingSource;
            this.last_orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.last_orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.last_orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.last_orderBindingNavigatorSaveItem});
            this.last_orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.last_orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.last_orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.last_orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.last_orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.last_orderBindingNavigator.Name = "last_orderBindingNavigator";
            this.last_orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.last_orderBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.last_orderBindingNavigator.TabIndex = 14;
            this.last_orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // last_orderBindingNavigatorSaveItem
            // 
            this.last_orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.last_orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("last_orderBindingNavigatorSaveItem.Image")));
            this.last_orderBindingNavigatorSaveItem.Name = "last_orderBindingNavigatorSaveItem";
            this.last_orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.last_orderBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.last_orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.last_orderBindingNavigatorSaveItem_Click);
            // 
            // Adding_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.last_orderBindingNavigator);
            this.Controls.Add(this.Add_prod_button);
            this.Controls.Add(this.All_order_button);
            this.Controls.Add(this.Delete_product_button);
            this.Controls.Add(this.Osnova_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prod_provider);
            this.Controls.Add(this.Prod_Category);
            this.Controls.Add(this.Price_prod);
            this.Controls.Add(this.Name_Prod);
            this.Controls.Add(this.Adder_prod_Grid);
            this.Controls.Add(this.Adding_Button);
            this.Name = "Adding_Prod";
            this.Text = "Adding_Prod";
            this.Load += new System.EventHandler(this.Adding_Prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Adder_prod_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_orderBindingNavigator)).EndInit();
            this.last_orderBindingNavigator.ResumeLayout(false);
            this.last_orderBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adding_Button;
        private System.Windows.Forms.DataGridView Adder_prod_Grid;
        private System.Windows.Forms.TextBox Name_Prod;
        private System.Windows.Forms.TextBox Price_prod;
        private System.Windows.Forms.TextBox Prod_Category;
        private System.Windows.Forms.TextBox Prod_provider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_prod_button;
        private System.Windows.Forms.Button All_order_button;
        private System.Windows.Forms.Button Delete_product_button;
        private System.Windows.Forms.Button Osnova_Button;
        private RabotaDataSet rabotaDataSet;
        private System.Windows.Forms.BindingSource last_orderBindingSource;
        private RabotaDataSetTableAdapters.last_orderTableAdapter last_orderTableAdapter;
        private RabotaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator last_orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton last_orderBindingNavigatorSaveItem;
    }
}