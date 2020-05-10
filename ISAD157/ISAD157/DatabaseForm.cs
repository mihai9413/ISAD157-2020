using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ISAD157

{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            

            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                DBConnect.USER_NAME + ";" + "PASSWORD=" +
                DBConnect.PASSWORD + ";" + "SslMode=" +
                DBConnect.SslMode + ";";

           
            using (MySqlConnection connection =
                new MySqlConnection(connectionString))
            {
               
                string query = "SELECT * FROM ISAD157_MMares.facebook_users";
                string query1 = "SELECT * FROM ISAD157_MMares.facebook_friendships";
                string query2 = "SELECT * FROM ISAD157_MMares.workplace";
                string query3 = "SELECT * FROM ISAD157_MMares.universities";
                string query4 = "SELECT * FROM ISAD157_MMares.messages";

                connection.Open();

               
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                MySqlCommand cmd4 = new MySqlCommand(query4, connection);



                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);
                MySqlDataAdapter sqlDA1 = new MySqlDataAdapter(cmd1);
                DataTable friendsDataTable = new DataTable();
                sqlDA1.Fill(friendsDataTable);
                MySqlDataAdapter sqlDA2 = new MySqlDataAdapter(cmd2);
                DataTable workDataTable = new DataTable();
                sqlDA2.Fill(workDataTable);
                MySqlDataAdapter sqlDA3 = new MySqlDataAdapter(cmd3);
                DataTable uniDataTable = new DataTable();
                sqlDA3.Fill(uniDataTable);
                MySqlDataAdapter sqlDA4 = new MySqlDataAdapter(cmd4);
                DataTable messagesDataTable = new DataTable();
                sqlDA4.Fill(messagesDataTable);

                dataGridViewUser.DataSource = userDataTable;
                dataGridViewFriends.DataSource = friendsDataTable;
                dataGridViewWork.DataSource = workDataTable;
                dataGridViewUni.DataSource = uniDataTable;
                dataGridViewMessage.DataSource = messagesDataTable;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
