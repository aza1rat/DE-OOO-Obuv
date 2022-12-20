using OOO_Obuv.ClassesEntity;
using OOO_Obuv.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Obuv
{
    public partial class FormChangeProduct : Form
    {
        private Product selectedProduct;
        public FormChangeProduct()
        {
            InitializeComponent();
            GetStatementsFromDB();
            PictureBoxProduct.Image = Resources.picture;
        }

        public FormChangeProduct(string article)
        {
            InitializeComponent();
            TextBoxArticle.Enabled = false;
            GetStatementsFromDB();
            selectedProduct = Helper.DBModel.Product.Where(product => product.ProductArticle == article).First();
            TextBoxArticle.Text = selectedProduct.ProductArticle;
            TextBoxName.Text = selectedProduct.ProductName;
            TextBoxCost.Text = selectedProduct.ProductCost.ToString();
            TextBoxDiscount.Text = selectedProduct.ProductDiscount.ToString();
            TextBoxMaxDiscount.Text = selectedProduct.ProductMaxDiscount.ToString();
            TextBoxInStock.Text = selectedProduct.ProductQuantityInStock.ToString();
            TextBoxDescription.Text = selectedProduct.ProductDescription;
            ComboBoxCategory.SelectedItem = Helper.DBModel.Category.Where(item => 
            item.CategoryID == selectedProduct.ProductCategory).First();
            ComboBoxManufacturer.SelectedItem = Helper.DBModel.Manufacturer.Where(item => 
            item.ManufacturerID == selectedProduct.ProductManufacturer).First();
            ComboBoxProvider.SelectedItem = Helper.DBModel.Provider.Where(item =>
            item.ProviderID == selectedProduct.ProductProvider).First();
            ComboBoxUnit.SelectedItem = Helper.DBModel.Unit.Where(item =>
            item.UnitID == selectedProduct.ProductUnit).First();
            if (selectedProduct.ProductImage != null)
            {
                MemoryStream ms = new MemoryStream(selectedProduct.ProductImage);
                Bitmap bitmap = (Bitmap)Image.FromStream(ms);
                PictureBoxProduct.Image = bitmap;
            }
            else
                PictureBoxProduct.Image = (Bitmap)Resources.picture;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetStatementsFromDB()
        {
            
            ComboBoxCategory.DataSource = Helper.DBModel.Category.ToList();
            ComboBoxCategory.DisplayMember = "CategoryName";
            ComboBoxCategory.SelectedIndex = 0;
            ComboBoxProvider.DataSource = Helper.DBModel.Provider.ToList();
            ComboBoxProvider.DisplayMember = "ProviderName";
            ComboBoxProvider.SelectedIndex = 0;
            ComboBoxManufacturer.DataSource = Helper.DBModel.Manufacturer.ToList();
            ComboBoxManufacturer.DisplayMember = "ManufacturerName";
            ComboBoxManufacturer.SelectedIndex = 0;
            ComboBoxUnit.DataSource = Helper.DBModel.Unit.ToList();
            ComboBoxUnit.DisplayMember = "UnitName";
            ComboBoxUnit.SelectedIndex = 0;
        }

        private Product CheckValidate()
        {
            Product changeProduct = new Product();
            int discount = -1;
            int maxDiscount = -1;
            if (String.IsNullOrEmpty(TextBoxArticle.Text))
                return null;
            if (String.IsNullOrEmpty(TextBoxName.Text))
                return null;
            if (String.IsNullOrEmpty(TextBoxCost.Text))
                return null;
            if (String.IsNullOrEmpty(TextBoxInStock.Text))
                return null;
            if (String.IsNullOrEmpty(TextBoxDescription.Text))
                return null;
            if (String.IsNullOrEmpty(TextBoxDiscount.Text))
                discount = 0;
            if (String.IsNullOrEmpty(TextBoxMaxDiscount.Text))
                maxDiscount = 0;
            try
            {
                changeProduct.ProductArticle = TextBoxArticle.Text;
                changeProduct.ProductDescription = TextBoxDescription.Text;
                changeProduct.ProductName = TextBoxName.Text;
                Category category = (Category)ComboBoxCategory.SelectedItem;
                changeProduct.ProductCategory = category.CategoryID;
                Manufacturer manufacturer = (Manufacturer)ComboBoxManufacturer.SelectedItem;
                changeProduct.ProductManufacturer = manufacturer.ManufacturerID;
                Provider provider = (Provider)ComboBoxProvider.SelectedItem;
                changeProduct.ProductProvider = provider.ProviderID;
                Unit unit = (Unit)ComboBoxUnit.SelectedItem;
                changeProduct.ProductUnit = unit.UnitID;

                double cost = Convert.ToDouble(TextBoxCost.Text);
                if (cost <= 0)
                    return null;
                int dotCost = TextBoxCost.Text.IndexOf(',');
                if (dotCost != -1 && TextBoxCost.Text.Length - dotCost - 1 > 2)
                    return null;
                changeProduct.ProductCost = (decimal)cost;
                if (discount != 0)
                {
                    discount = Convert.ToInt32(TextBoxDiscount.Text);
                    if (discount < 0 || discount >= 100)
                        return null;
                    changeProduct.ProductDiscount = discount;
                }
                if (maxDiscount != 0)
                {
                    maxDiscount = Convert.ToInt32(TextBoxMaxDiscount.Text);
                    if (maxDiscount < 0 || maxDiscount >= 100)
                        return null;
                    changeProduct.ProductMaxDiscount = maxDiscount;
                }
                int quantity = Convert.ToInt32(TextBoxInStock.Text);
                if (quantity <= 0)
                    return null;
                changeProduct.ProductQuantityInStock = quantity;
                if (discount > maxDiscount)
                    return null;                
            }
            catch
            {
                return null;
            }
            if (PictureBoxProduct.Image != Resources.picture)
            {
                MemoryStream ms = new MemoryStream();
                PictureBoxProduct.Image.Save(ms, PictureBoxProduct.Image.RawFormat);
                changeProduct.ProductImage = ms.ToArray();
            }
            return changeProduct;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Product product = CheckValidate();
            if (product == null)
                return;
            
            try
            {
                Helper.DBModel.Product.Add(product);
                Helper.DBModel.SaveChanges();
            }
            catch
            {
                return;
            }
            
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Product product = CheckValidate();
            if (product == null)
                return;
            try
            {
                Helper.DBModel.Entry(selectedProduct).CurrentValues.SetValues(product);
                Helper.DBModel.SaveChanges();
            }
            catch
            {
                return;
            }
            
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string file = dlg.FileName;
                PictureBoxProduct.Image = Image.FromFile(file);
            }
        }

        private void ButtonCancelImage_Click(object sender, EventArgs e)
        {
            PictureBoxProduct.Image = Resources.picture;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Product product = CheckValidate();
            if (product == null)
                return;
            try
            {
                Helper.DBModel.Product.Remove(product);
                Helper.DBModel.SaveChanges();
            }
            catch
            {
                return;
            }
            
        }
    }
}
