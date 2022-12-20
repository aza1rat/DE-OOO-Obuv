namespace OOO_Obuv
{
    partial class FormCatalogue
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogue));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelNameForm = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelCatalogueUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelProductCountShow = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxCost = new System.Windows.Forms.ComboBox();
            this.ComboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DGVCatalogue = new System.Windows.Forms.DataGridView();
            this.ColumnImageProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnProductInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAddNewProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatalogue)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.586404F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.5397F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.936946F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.936946F));
            this.tableLayoutPanel1.Controls.Add(this.PictureBoxLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelNameForm, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonBack, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelCatalogueUser, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1365, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Image = global::OOO_Obuv.Properties.Resources.logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.PictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxLogo.MaximumSize = new System.Drawing.Size(55, 54);
            this.PictureBoxLogo.MinimumSize = new System.Drawing.Size(55, 54);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(55, 54);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // LabelNameForm
            // 
            this.LabelNameForm.AutoSize = true;
            this.LabelNameForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNameForm.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameForm.Location = new System.Drawing.Point(106, 0);
            this.LabelNameForm.Name = "LabelNameForm";
            this.LabelNameForm.Size = new System.Drawing.Size(984, 60);
            this.LabelNameForm.TabIndex = 1;
            this.LabelNameForm.Text = "Просмотр каталога";
            this.LabelNameForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonBack.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(1231, 2);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(131, 56);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelCatalogueUser
            // 
            this.LabelCatalogueUser.AutoSize = true;
            this.LabelCatalogueUser.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCatalogueUser.Location = new System.Drawing.Point(1097, 0);
            this.LabelCatalogueUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCatalogueUser.Name = "LabelCatalogueUser";
            this.LabelCatalogueUser.Size = new System.Drawing.Size(50, 21);
            this.LabelCatalogueUser.TabIndex = 3;
            this.LabelCatalogueUser.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 630);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1365, 60);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.LabelProductCountShow, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.DGVCatalogue, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1365, 570);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // LabelProductCountShow
            // 
            this.LabelProductCountShow.AutoSize = true;
            this.LabelProductCountShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelProductCountShow.Font = new System.Drawing.Font("Candara", 18F);
            this.LabelProductCountShow.Location = new System.Drawing.Point(4, 0);
            this.LabelProductCountShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelProductCountShow.Name = "LabelProductCountShow";
            this.LabelProductCountShow.Size = new System.Drawing.Size(1357, 57);
            this.LabelProductCountShow.TabIndex = 0;
            this.LabelProductCountShow.Text = "Показано";
            this.LabelProductCountShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.ComboBoxCost, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ComboBoxDiscount, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.ComboBoxCategory, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.TextBoxSearch, 7, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 61);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1357, 49);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label3.Location = new System.Drawing.Point(342, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 49);
            this.label3.TabIndex = 1;
            this.label3.Text = "Скидка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label4.Location = new System.Drawing.Point(680, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 49);
            this.label4.TabIndex = 2;
            this.label4.Text = "Категория";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label5.Location = new System.Drawing.Point(1018, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 49);
            this.label5.TabIndex = 3;
            this.label5.Text = "Поиск";
            // 
            // ComboBoxCost
            // 
            this.ComboBoxCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCost.Font = new System.Drawing.Font("Candara", 14.25F);
            this.ComboBoxCost.FormattingEnabled = true;
            this.ComboBoxCost.Items.AddRange(new object[] {
            "Возрастает",
            "Убывает"});
            this.ComboBoxCost.Location = new System.Drawing.Point(173, 4);
            this.ComboBoxCost.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCost.Name = "ComboBoxCost";
            this.ComboBoxCost.Size = new System.Drawing.Size(161, 37);
            this.ComboBoxCost.TabIndex = 4;
            this.ComboBoxCost.SelectedValueChanged += new System.EventHandler(this.ComboBoxCost_SelectedValueChanged);
            // 
            // ComboBoxDiscount
            // 
            this.ComboBoxDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDiscount.Font = new System.Drawing.Font("Candara", 14.25F);
            this.ComboBoxDiscount.FormattingEnabled = true;
            this.ComboBoxDiscount.Items.AddRange(new object[] {
            "Все диапазоны",
            "0 - 10%",
            "11 - 14%",
            "> 15%"});
            this.ComboBoxDiscount.Location = new System.Drawing.Point(511, 4);
            this.ComboBoxDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxDiscount.Name = "ComboBoxDiscount";
            this.ComboBoxDiscount.Size = new System.Drawing.Size(161, 37);
            this.ComboBoxDiscount.TabIndex = 5;
            this.ComboBoxDiscount.SelectedValueChanged += new System.EventHandler(this.ComboBoxCost_SelectedValueChanged);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategory.Font = new System.Drawing.Font("Candara", 14.25F);
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(849, 4);
            this.ComboBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(161, 37);
            this.ComboBoxCategory.TabIndex = 6;
            this.ComboBoxCategory.SelectedValueChanged += new System.EventHandler(this.ComboBoxCost_SelectedValueChanged);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSearch.Font = new System.Drawing.Font("Candara", 14.25F);
            this.TextBoxSearch.Location = new System.Drawing.Point(1187, 4);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(166, 36);
            this.TextBoxSearch.TabIndex = 7;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // DGVCatalogue
            // 
            this.DGVCatalogue.AllowUserToAddRows = false;
            this.DGVCatalogue.AllowUserToDeleteRows = false;
            this.DGVCatalogue.BackgroundColor = System.Drawing.Color.White;
            this.DGVCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCatalogue.ColumnHeadersVisible = false;
            this.DGVCatalogue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImageProduct,
            this.ColumnProductInfo,
            this.ColumnDiscount});
            this.DGVCatalogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCatalogue.Location = new System.Drawing.Point(4, 118);
            this.DGVCatalogue.Margin = new System.Windows.Forms.Padding(4);
            this.DGVCatalogue.Name = "DGVCatalogue";
            this.DGVCatalogue.ReadOnly = true;
            this.DGVCatalogue.RowHeadersWidth = 51;
            this.DGVCatalogue.Size = new System.Drawing.Size(1357, 391);
            this.DGVCatalogue.TabIndex = 2;
            this.DGVCatalogue.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCatalogue_CellDoubleClick);
            // 
            // ColumnImageProduct
            // 
            this.ColumnImageProduct.HeaderText = "";
            this.ColumnImageProduct.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnImageProduct.MinimumWidth = 125;
            this.ColumnImageProduct.Name = "ColumnImageProduct";
            this.ColumnImageProduct.ReadOnly = true;
            this.ColumnImageProduct.Width = 125;
            // 
            // ColumnProductInfo
            // 
            this.ColumnProductInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 10F);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnProductInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnProductInfo.HeaderText = "";
            this.ColumnProductInfo.MinimumWidth = 6;
            this.ColumnProductInfo.Name = "ColumnProductInfo";
            this.ColumnProductInfo.ReadOnly = true;
            // 
            // ColumnDiscount
            // 
            this.ColumnDiscount.HeaderText = "";
            this.ColumnDiscount.MinimumWidth = 125;
            this.ColumnDiscount.Name = "ColumnDiscount";
            this.ColumnDiscount.ReadOnly = true;
            this.ColumnDiscount.Width = 125;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.ButtonAddNewProduct, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 516);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1359, 51);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // ButtonAddNewProduct
            // 
            this.ButtonAddNewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAddNewProduct.Font = new System.Drawing.Font("Candara", 14.25F);
            this.ButtonAddNewProduct.Location = new System.Drawing.Point(456, 3);
            this.ButtonAddNewProduct.Name = "ButtonAddNewProduct";
            this.ButtonAddNewProduct.Size = new System.Drawing.Size(447, 45);
            this.ButtonAddNewProduct.TabIndex = 4;
            this.ButtonAddNewProduct.Text = "Добавить товар";
            this.ButtonAddNewProduct.UseVisualStyleBackColor = true;
            this.ButtonAddNewProduct.Click += new System.EventHandler(this.ButtonAddNewProduct_Click);
            // 
            // FormCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 690);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCatalogue";
            this.Text = "Каталог товаров";
            this.Load += new System.EventHandler(this.FormCatalogue_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatalogue)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelNameForm;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LabelProductCountShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxCost;
        private System.Windows.Forms.ComboBox ComboBoxDiscount;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DataGridView DGVCatalogue;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImageProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscount;
        private System.Windows.Forms.Label LabelCatalogueUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button ButtonAddNewProduct;
    }
}

