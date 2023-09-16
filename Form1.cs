using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SendCMD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                connectionString = "datasource=sindre.ninja;database=csharp;port=3306;username=#########;password=###############";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand mcd;
                string c = textBox_cmd.Text;
                string s;
                s = "INSERT INTO `command` (`sqlcmd`) VALUES ('" + c + "');";
                connection.Open();
                cmd = new MySqlCommand(s, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                connection.CloseAsync();
            }
            catch {}

        }
    }
}
