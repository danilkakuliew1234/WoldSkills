
namespace Test
{
    partial class Product
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductImage
            // 
            this.ProductImage.Location = new System.Drawing.Point(17, 13);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(255, 159);
            this.ProductImage.TabIndex = 0;
            this.ProductImage.TabStop = false;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.productName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productName.Location = new System.Drawing.Point(13, 175);
            this.productName.MaximumSize = new System.Drawing.Size(255, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(152, 22);
            this.productName.TabIndex = 1;
            this.productName.Text = "@product__name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.price.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.price.Location = new System.Drawing.Point(13, 220);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(67, 22);
            this.price.TabIndex = 2;
            this.price.Text = "@price";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.price);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.ProductImage);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(288, 260);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label price;
    }
}
