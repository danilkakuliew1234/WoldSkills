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
    class SortProduct
    {
        public void ProductsSort(ref List<Product> products, ref TableLayoutPanel ProductGrid, DataBase dataBase, string text)
        {
            products.Clear();
            ProductGrid.Controls.Clear();

            dataBase.Connect();

            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Product WHERE Title LIKE '%{text}%'", dataBase.sqlConnection);
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
                ProductGrid.Controls.Add(products[i]);
            }

            ProductGrid.ColumnCount = 2;
            ProductGrid.RowCount = products.Count / ProductGrid.ColumnCount + 1;

            if(ProductGrid.RowCount > 1)
                ProductGrid.Height = ProductGrid.RowCount * products[0].Height;
        }
    }
}
