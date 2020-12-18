using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    class LoadData
    {
        public void Load(ref List<Product> products, DataBase dataBase)
        {
            dataBase.Connect();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Product", dataBase.sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataBase.Disconnect();


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                products.Add(new Product(
                    dataTable.Rows[i][0].ToString(),
                    dataTable.Rows[i][4].ToString(),
                    Convert.ToBoolean(dataTable.Rows[i][3]),
                    dataTable.Rows[i][1].ToString()));
            }
        }
    }
}
