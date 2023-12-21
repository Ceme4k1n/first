namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Adding_Product = new System.Windows.Forms.Button();
            this.Price_adding = new System.Windows.Forms.Button();
            this.View_all_Orders = new System.Windows.Forms.Button();
            this.Product_Delete = new System.Windows.Forms.Button();
            this.rabotaDataSet = new WindowsFormsApp1.RabotaDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new WindowsFormsApp1.RabotaDataSetTableAdapters.categoryTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.RabotaDataSetTableAdapters.TableAdapterManager();
            this.categoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Product_View = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new WindowsFormsApp1.RabotaDataSetTableAdapters.productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingNavigator)).BeginInit();
            this.categoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Adding_Product
            // 
            this.Adding_Product.Location = new System.Drawing.Point(12, 128);
            this.Adding_Product.Name = "Adding_Product";
            this.Adding_Product.Size = new System.Drawing.Size(157, 60);
            this.Adding_Product.TabIndex = 0;
            this.Adding_Product.Text = "Добавить продукт";
            this.Adding_Product.UseVisualStyleBackColor = true;
            this.Adding_Product.Click += new System.EventHandler(this.Adding_Product_Click);
            // 
            // Price_adding
            // 
            this.Price_adding.Location = new System.Drawing.Point(12, 62);
            this.Price_adding.Name = "Price_adding";
            this.Price_adding.Size = new System.Drawing.Size(157, 60);
            this.Price_adding.TabIndex = 1;
            this.Price_adding.Text = "Изменить цену продукта";
            this.Price_adding.UseVisualStyleBackColor = true;
            this.Price_adding.Click += new System.EventHandler(this.Price_adding_Click);
            // 
            // View_all_Orders
            // 
            this.View_all_Orders.Location = new System.Drawing.Point(12, 194);
            this.View_all_Orders.Name = "View_all_Orders";
            this.View_all_Orders.Size = new System.Drawing.Size(157, 60);
            this.View_all_Orders.TabIndex = 2;
            this.View_all_Orders.Text = "Все заказы покупателя";
            this.View_all_Orders.UseVisualStyleBackColor = true;
            this.View_all_Orders.Click += new System.EventHandler(this.View_all_Orders_Click);
            // 
            // Product_Delete
            // 
            this.Product_Delete.Location = new System.Drawing.Point(12, 260);
            this.Product_Delete.Name = "Product_Delete";
            this.Product_Delete.Size = new System.Drawing.Size(157, 60);
            this.Product_Delete.TabIndex = 3;
            this.Product_Delete.Text = "Удалить продукт";
            this.Product_Delete.UseVisualStyleBackColor = true;
            this.Product_Delete.Click += new System.EventHandler(this.Product_Delete_Click);
            // 
            // rabotaDataSet
            // 
            this.rabotaDataSet.DataSetName = "RabotaDataSet";
            this.rabotaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.rabotaDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.last_orderTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.providerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.RabotaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoryBindingNavigator
            // 
            this.categoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoryBindingNavigator.BindingSource = this.categoryBindingSource;
            this.categoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categoryBindingNavigatorSaveItem});
            this.categoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoryBindingNavigator.Name = "categoryBindingNavigator";
            this.categoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoryBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.categoryBindingNavigator.TabIndex = 4;
            this.categoryBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // categoryBindingNavigatorSaveItem
            // 
            this.categoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoryBindingNavigatorSaveItem.Image")));
            this.categoryBindingNavigatorSaveItem.Name = "categoryBindingNavigatorSaveItem";
            this.categoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoryBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.categoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoryBindingNavigatorSaveItem_Click);
            // 
            // Product_View
            // 
            this.Product_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_View.Location = new System.Drawing.Point(246, 28);
            this.Product_View.Name = "Product_View";
            this.Product_View.Size = new System.Drawing.Size(542, 285);
            this.Product_View.TabIndex = 5;
            this.Product_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product_View_CellContentClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.rabotaDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Product_View);
            this.Controls.Add(this.categoryBindingNavigator);
            this.Controls.Add(this.Product_Delete);
            this.Controls.Add(this.View_all_Orders);
            this.Controls.Add(this.Price_adding);
            this.Controls.Add(this.Adding_Product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rabotaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingNavigator)).EndInit();
            this.categoryBindingNavigator.ResumeLayout(false);
            this.categoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adding_Product;
        private System.Windows.Forms.Button Price_adding;
        private System.Windows.Forms.Button View_all_Orders;
        private System.Windows.Forms.Button Product_Delete;
        private RabotaDataSet rabotaDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private RabotaDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private RabotaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton categoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView Product_View;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RabotaDataSetTableAdapters.productTableAdapter productTableAdapter;
    }
}

