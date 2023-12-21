using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Adding_Prod : Form
    {
        public Adding_Prod()
        {
            InitializeComponent();

            var cs = "Host=localhost;Database=Rabota;Username=postgres;Password=1234";
            var con = new NpgsqlConnection(cs);
            con.Open();

            // Устанавливаем схему поиска
            string searchPathSql = "SET search_path TO \"Rab\"";
            var setSearchPathCmd = new NpgsqlCommand(searchPathSql, con);
            setSearchPathCmd.ExecuteNonQuery();


            string Selecter = "Select * from product";
            var Selecter_Work = new NpgsqlCommand(Selecter, con);

            var adapter = new NpgsqlDataAdapter(Selecter_Work);
            var dataTable = new DataTable();

            adapter.Fill(dataTable);

            Adder_prod_Grid.DataSource = dataTable;

            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Adding_Button_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Database=Rabota;Username=postgres;Password=1234";
            var con = new NpgsqlConnection(cs);
            con.Open();

            string searchPathSql = "SET search_path TO \"Rab\"";
            var setSearchPathCmd = new NpgsqlCommand(searchPathSql, con);
            setSearchPathCmd.ExecuteNonQuery();

            string Name_product = Convert.ToString(Name_Prod.Text);
            int price_product = Convert.ToInt32(Price_prod.Text);
            int category_id = Convert.ToInt32(Prod_Category.Text);
            int provider_id = Convert.ToInt32(Prod_provider.Text);

            string selectSql = "CALL add_product('" + Name_product + "'," + price_product + "," + category_id + "," + provider_id + ");";

            var selectCmd = new NpgsqlCommand(selectSql, con);
            selectCmd.ExecuteNonQuery();


            string Selecter = "Select * from product";
            var Selecter_Work = new NpgsqlCommand(Selecter, con);

            var adapter = new NpgsqlDataAdapter(Selecter_Work);
            var dataTable = new DataTable();

            adapter.Fill(dataTable);

            Adder_prod_Grid.DataSource = dataTable;

            con.Close();
        }

        private void Add_prod_button_Click(object sender, EventArgs e)
        {
            From_Price_Update forma_update = new From_Price_Update();
            this.Hide();
            forma_update.Show();
        }

        private void All_order_button_Click(object sender, EventArgs e)
        {
            ALL_Form all_forms = new ALL_Form();
            this.Hide();
            all_forms.Show();
        }

        private void Delete_product_button_Click(object sender, EventArgs e)
        {
            Delete_Form forma_delete = new Delete_Form();
            this.Hide();
            forma_delete.Show();
        }

        private void Osnova_Button_Click(object sender, EventArgs e)
        {
            Form1 osnova = new Form1();
            this.Hide();
            osnova.Show();
        }

        private void last_orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.last_orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rabotaDataSet);

        }

        private void Adding_Prod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rabotaDataSet.last_order". При необходимости она может быть перемещена или удалена.
            this.last_orderTableAdapter.Fill(this.rabotaDataSet.last_order);

        }
    }
}
