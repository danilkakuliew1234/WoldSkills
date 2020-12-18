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
    public partial class Product : UserControl
    {
        public Product(string productName, string productPrice, bool isActive, string imagePath)
        {
            InitializeComponent();
            this.productName.Text = productName;
            this.price.Text = productPrice += " руб";
            if (!isActive)
                BackColor = Color.Silver;
            ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductImage.Load($".//{imagePath}");
        }
    }
}
