using OOO_Obuv.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Obuv
{
    public partial class FormCatalogue : Form
    {
        private List<ClassesEntity.Product> products;
        public FormCatalogue()
        {
            InitializeComponent();
        }

        private void FormCatalogue_Load(object sender, EventArgs e)
        {
            if (Helper.CurrentUser is null)
                LabelCatalogueUser.Text = "";
            else
                LabelCatalogueUser.Text = Helper.CurrentUser.Surname + "\n" +
                    Helper.CurrentUser.Name + "\n" +
                    Helper.CurrentUser.Patronymic;
            if (Helper.CurrentUser is null || Helper.CurrentUser.Role != User.UserRole.Администратор)
            {
                ButtonAddNewProduct.Enabled = false;
                ButtonAddNewProduct.Visible = false;
            }
            else
            {
                ButtonAddNewProduct.Enabled = true;
                ButtonAddNewProduct.Visible = true;
            }
            ComboBoxCategory.Items.Clear();
            ComboBoxCategory.Items.Add("Все категории");
            foreach (ClassesEntity.Category category in Helper.DBModel.Category)
            {
                ComboBoxCategory.Items.Add(category.CategoryName);
            }
            ComboBoxCost.SelectedIndex = 0;
            ComboBoxCategory.SelectedIndex = 0;
            ComboBoxDiscount.SelectedIndex = 0;



        }

        private void UpdateGrid()
        {
            DGVCatalogue.Rows.Clear();
            foreach (ClassesEntity.Product product in products)
            {
                if (!(IsHaveLetter(product.ProductName, TextBoxSearch.Text)))
                    continue;
                int viewID = DGVCatalogue.Rows.Add();
                DGVCatalogue.Rows[viewID].Height = 120;
                if (product.ProductImage != null)
                {
                    MemoryStream ms = new MemoryStream(product.ProductImage);
                    Bitmap bitmap = (Bitmap)Image.FromStream(ms);
                    DGVCatalogue.Rows[viewID].Cells[0].Value = bitmap;
                }
                else
                    DGVCatalogue.Rows[viewID].Cells[0].Value = (Bitmap)Resources.picture;
                DGVCatalogue.Rows[viewID].Cells[0].Tag = product.ProductArticle;
                DGVCatalogue.Rows[viewID].Cells[1].Value += "Наименование товара: " + product.ProductName +
                    Environment.NewLine + "Описание: " + Environment.NewLine + product.ProductDescription +
                    Environment.NewLine + "Производитель: " + product.Manufacturer.ManufacturerName +
                    Environment.NewLine + "Цена: " + product.ProductCost;
                if (product.ProductDiscount != null || product.ProductDiscount > 0)
                    DGVCatalogue.Rows[viewID].Cells[1].Value += Environment.NewLine + "Стоимость со скидкой: " +
                    ((double)product.ProductCost - ((double)product.ProductCost *
                    ((double)product.ProductDiscount / 100)));
                DGVCatalogue.Rows[viewID].Cells[2].Value = "Скидка: " + product.ProductDiscount + "%";
                if (product.ProductDiscount > 15)
                    DGVCatalogue.Rows[viewID].DefaultCellStyle.BackColor = Color.FromArgb(127,255,0);
            }
            LabelProductCountShow.Text = $"Показано {DGVCatalogue.RowCount} из {Helper.DBModel.Product.Count()}";
        }

        private bool IsHaveLetter(string str, string letters)
        {
            if (String.IsNullOrEmpty(str))
                return true;
            return str.Contains(letters);
        }

        private int GetCategoryID(string value)
        {
            var category = Helper.DBModel.Category.Where(c => c.CategoryName == value).First();
            return category.CategoryID;
        }

        private void ComboBoxCost_SelectedValueChanged(object sender, EventArgs e)
        {
            GetFromDB();

        }

        private void GetFromDB2()
        {
            if (ComboBoxCategory.SelectedItem is null || ComboBoxCost.SelectedItem == null || ComboBoxDiscount.SelectedItem == null)
                return;
            List<string> parameters = new List<string>();
            String sqlCommand = "SELECT * FROM Product ";
            if (ComboBoxCategory.SelectedItem.ToString() != "Все категории")
                parameters.Add("ProductCategory = " + GetCategoryID(ComboBoxCategory.SelectedItem.ToString()) + " ");
            if (ComboBoxDiscount.SelectedItem.ToString() != "Все диапазоны")
            {
                switch (ComboBoxDiscount.SelectedItem.ToString())
                {
                    case "0 - 10%": parameters.Add("ProductDiscount <= 10 "); break;
                    case "11 - 14%": parameters.Add("ProductDiscount > 10 AND ProductDiscount <= 14 "); break;
                    case "> 15%": parameters.Add("ProductDiscount > 14 "); break;
                }
            }
            if (parameters.Count > 0)
            {
                sqlCommand += "WHERE ";
                for (int i = 0; i < parameters.Count; i++)
                {
                    sqlCommand += parameters[i];
                    if (i != parameters.Count - 1)
                        sqlCommand += "AND ";
                }
            }
            
            switch (ComboBoxCost.SelectedItem.ToString())
            {
                case "Возрастает": sqlCommand += "ORDER BY ProductCost ASC"; break;
                case "Убывает": sqlCommand += "ORDER BY ProductCost DESC"; break;
            }

            products = Helper.DBModel.Product.SqlQuery(sqlCommand).ToList();
            UpdateGrid();
        }

        private void GetFromDB()
        {
            if (ComboBoxCategory.SelectedItem is null || ComboBoxCost.SelectedItem == null || ComboBoxDiscount.SelectedItem == null)
                return;
            string sqlCommand = "SELECT * FROM Product WHERE ";
            if (ComboBoxCategory.SelectedItem.ToString() != "Все категории")
                sqlCommand += "ProductCategory = " + GetCategoryID(ComboBoxCategory.SelectedItem.ToString()) + " AND ";
            switch (ComboBoxDiscount.SelectedItem.ToString())
            {
                case "0 - 10%": sqlCommand += "ProductDiscount <= 10 "; break;
                case "11 - 14%": sqlCommand += "ProductDiscount > 10 AND ProductDiscount <= 14 "; break;
                case "> 15%": sqlCommand += "ProductDiscount > 14 "; break;
                default:
                    if (ComboBoxCategory.SelectedItem.ToString() != "Все категории")
                        sqlCommand = sqlCommand.Substring(0, sqlCommand.Length - 4);
                    else
                        sqlCommand = sqlCommand.Substring(0, sqlCommand.Length - 6);
                    break;
            }
            switch (ComboBoxCost.SelectedItem.ToString())
            {
                case "Возрастает": sqlCommand += "ORDER BY ProductCost ASC"; break;
                case "Убывает": sqlCommand += "ORDER BY ProductCost DESC"; break;
            }
            products = Helper.DBModel.Product.SqlQuery(sqlCommand).ToList();
            UpdateGrid();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetFromDB();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVCatalogue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (Helper.CurrentUser is null || Helper.CurrentUser.Role != User.UserRole.Администратор)
                return;
            FormChangeProduct formChangeProduct = new FormChangeProduct(DGVCatalogue.Rows[e.RowIndex].Cells[0].Tag.ToString());
            this.Hide();
            formChangeProduct.ShowDialog();
            this.Show();
            FormCatalogue_Load(null, null);
        }

        private void ButtonAddNewProduct_Click(object sender, EventArgs e)
        {
            FormChangeProduct formChangeProduct = new FormChangeProduct();
            this.Hide();
            formChangeProduct.ShowDialog();
            this.Show();
            FormCatalogue_Load(null, null);
        }
    }
}
