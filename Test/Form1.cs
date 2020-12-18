using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
        private DataBase dataBase = null;
        private LoadData loadData = null;
        private SortProduct sortProduct = null;
        private LoadManufacturers loadManufacturers = null;

        public Form1()
        {
            InitializeComponent();
            dataBase = new DataBase("Server=localhost\\SQLEXPRESS;Database=Shop;Trusted_Connection=True;");
            loadData = new LoadData();
            sortProduct = new SortProduct();
            loadManufacturers = new LoadManufacturers();
            ProductGrid.RowStyles[0].SizeType = SizeType.AutoSize;
            ProductGrid.ColumnCount = 2;


            if (dataBase.CheckConnection())
            {
                loadData.Load(ref products, dataBase);
                GenerateProduct();
                loadManufacturers.LoadManufacturer(ref ManufacturerList, dataBase);
            }
        }
        public void GenerateProduct()
        {
            ProductGrid.RowCount = products.Count / 2;
            ProductGrid.Height = ProductGrid.RowCount * products[0].Height;
            for (int i = 0; i < products.Count; i++)
                ProductGrid.Controls.Add(products[i]);
            for (int i = 0; i < ProductGrid.RowCount; i++)
                ProductGrid.RowStyles[i].Height = products[0].Height;
        }

        private void ProductSort_OnValueChanged(object sender, EventArgs e)
        {
            sortProduct.ProductsSort(ref products, ref ProductGrid, dataBase, ProductSort.Text);
        }
    }
}
