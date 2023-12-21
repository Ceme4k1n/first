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
    public partial class From_Price_Update : Form
    {
        public From_Price_Update()
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

            Uppdater_Grid.DataSource = dataTable;

            con.Close();

        }

        public void Price_Update_Click(object sender, EventArgs e)
        {
            var cs = "Host=localhost;Database=Rabota;Username=postgres;Password=1234";
            var con = new NpgsqlConnection(cs);
            con.Open();

            // Устанавливаем схему поиска
            string searchPathSql = "SET search_path TO \"Rab\"";
            var setSearchPathCmd = new NpgsqlCommand(searchPathSql, con);
            setSearchPathCmd.ExecuteNonQuery();

            int id_1 = Convert.ToInt32(Get_Id_Box.Text);
            int price_prod = Convert.ToInt32(Get_New_Price_Box.Text);

            // Выбираем данные из таблицы "product"
            string selectSql = "CALL update_product_price("+id_1+", "+price_prod+");";
            var selectCmd = new NpgsqlCommand(selectSql, con);
            selectCmd.ExecuteNonQuery();


            string Selecter = "Select * from product";
            var Selecter_Work = new NpgsqlCommand(Selecter, con);

            var adapter = new NpgsqlDataAdapter(Selecter_Work);
            var dataTable = new DataTable();

            adapter.Fill(dataTable);

            Uppdater_Grid.DataSource = dataTable;

            con.Close();
        }

        private void Osnova_Button_Click(object sender, EventArgs e)
        {
            Form1 osnova = new Form1();
            this.Hide();
            osnova.Show();
        }

        private void Delete_product_button_Click(object sender, EventArgs e)
        {
            Delete_Form forma_delete = new Delete_Form();
            this.Hide();
            forma_delete.Show();
        }

        private void All_order_button_Click(object sender, EventArgs e)
        {
            ALL_Form all_forms = new ALL_Form();
            this.Hide();
            all_forms.Show();
        }

        private void Add_prod_button_Click(object sender, EventArgs e)
        {
            Adding_Prod New_Prod = new Adding_Prod();
            this.Hide();
            New_Prod.Show();
        }
    }
}
