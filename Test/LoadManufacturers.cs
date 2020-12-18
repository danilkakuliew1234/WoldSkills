using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test
{
    class LoadManufacturers
    {
        public void LoadManufacturer(ref ComboBox List, DataBase dataBase)
        {
            dataBase.Connect();
            
            SqlCommand sqlCommand = new SqlCommand("SELECT Name FROM Manufacturer", dataBase.sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataBase.Disconnect();

            for(int i = 0; i < dataTable.Rows.Count; i++)
                List.Items.Add(dataTable.Rows[i][0].ToString());
        }
    }
}
