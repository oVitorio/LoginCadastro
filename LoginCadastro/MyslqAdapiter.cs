using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginCadastro;

 internal class MyslqAdapiter
{



    public void sqlQuerryInsert(string table , string colluns, string values) { 
        string connStr = "server=localhost;user=root;database=logincadastro;port=3306;password=";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            conn.Open();
                // Perform database operations
                MyslqAdapiter adapiter = new MyslqAdapiter();
                string sql = $"INSERT INTO {table}({colluns}) values ({values}) ";
                MySqlCommand cmd = new MySqlCommand(sql,conn);

                cmd.ExecuteReader();
            }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());

        }
        conn.Close();
        Console.WriteLine("Done.");
    }


}
