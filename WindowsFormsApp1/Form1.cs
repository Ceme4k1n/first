using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var cs = "Host=localhost;Database=Rabota;Username=postgres;Password=1234";
            var con = new NpgsqlConnection(cs);
            con.Open();

            // Устанавливаем схему поиска
            string searchPathSql = "SET search_path TO \"Rab\"";
            var setSearchPathCmd = new NpgsqlCommand(searchPathSql, con);
            setSearchPathCmd.ExecuteNonQuery();

            // Выбираем данные из таблицы "product"
            string selectSql = "Select * from product";
            var selectCmd = new NpgsqlCommand(selectSql, con);

            var adapter = new NpgsqlDataAdapter(selectCmd);
            var dataTable = new DataTable();

            adapter.Fill(dataTable);

            Product_View.DataSource = dataTable;


        }

        private void Adding_Product_Click(object sender, EventArgs e)
        {
            Adding_Prod New_Prod = new Adding_Prod();
            this.Hide();
            New_Prod.Show();
        }

        private void Price_adding_Click(object sender, EventArgs e)
        {
            From_Price_Update forma_update = new From_Price_Update();
            this.Hide();
            forma_update.Show();
        }

        private void View_all_Orders_Click(object sender, EventArgs e)
        {
            ALL_Form all_forms = new ALL_Form();
            this.Hide();
            all_forms.Show();
        }

        private void Product_Delete_Click(object sender, EventArgs e)
        {
            Delete_Form forma_delete = new Delete_Form();
            this.Hide();
            forma_delete.Show();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rabotaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rabotaDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.rabotaDataSet.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rabotaDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.rabotaDataSet.category);

        }

        private void Error_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
