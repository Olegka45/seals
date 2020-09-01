using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Seal
{
    class connectionTODB
    {
        //string connectString = "server=localhost;user=root;database=PLOMBS;port=3306;password=1945";
        MySqlConnection myConnection = new MySqlConnection("server=localhost;user=root;database=PLOMBS;port=3306;password=1945");
        public void connectionCreate()
        {
            myConnection.Open();
        }

        public void Execute(string query)
        {
            
            try
            {

                MySqlCommand command = new MySqlCommand(query, myConnection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (query == "")
                {
                    MessageBox.Show("");
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void connectionClose()
        {
            myConnection.Close();
        }
    }
}