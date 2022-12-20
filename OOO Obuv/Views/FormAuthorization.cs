using OOO_Obuv.ClassesEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Obuv
{
    public partial class FormAuthorization : Form
    {
        private string captchaValue = null;
        private int secondsForCapthca = 0;
        public FormAuthorization()
        {
            InitializeComponent();
            Helper.DBModel = new Model();
            try
            {
                Helper.DBModel.Database.Connection.Open();
                MessageBox.Show("Успешное подключение к БД", 
                    "Статус соединения", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Произошла ошибка при подключении к БД. Текст ошибки : {ex.Message} ({ex.Number})",
                    "Статус соединения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string GenerateCaptcha(int length)
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string generated = "";
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int gettedSymbols = random.Next(0, symbols.Length - 1);
                generated += symbols[gettedSymbols];
            }
            return generated;
        }

        private void DrawCaptcha(string captcha)
        {
            int fontsize = 18;
            int placeX = 0;
            int placeY = 0;
            Random random = new Random();
            Bitmap bitmap = new Bitmap(PictureBoxCaptcha.Width, PictureBoxCaptcha.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font("Georgia", fontsize);
            graphics.Clear(Color.White);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < captcha.Length; i++)
            {
                placeX = random.Next(placeX + fontsize / 2, placeX + fontsize * 2);
                placeY = random.Next(0, bitmap.Height - fontsize * 2);
                graphics.DrawString(captcha[i].ToString(), font, Brushes.Black, placeX, placeY);
                graphics.DrawLine(Pens.Black, placeX, placeY, random.Next(placeX, bitmap.Width), random.Next(placeY, bitmap.Height));

            }
            graphics.Flush();
            PictureBoxCaptcha.Image = bitmap;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAuthorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Helper.DBModel.Database.Connection.Close();
            MessageBox.Show("Успешное отключение от БД",
                "Статус соединения",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Application.Exit();
        }

        private void SetCaptcha()
        {
            ButtonLogIn.Enabled = false;
            ButtonGuest.Enabled = false;
            TimerCaptcha.Start();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            if (captchaValue != null && TextBoxCaptcha.Text != captchaValue)
            {
                SetCaptcha();
                return;
            }
            string login = TextBoxLogin.Text;
            string password = TextBoxPassword.Text;
            var findedUser = Helper.DBModel.User.Where(user =>
                user.UserLogin == login && user.UserPassword == password)
                .FirstOrDefault();

            if (findedUser == null) 
            {
                MessageBox.Show("Неверный логин или пароль", 
                    "Ошибка авторизации", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                SetCaptcha();
                return;
            }
            var userRole = Helper.DBModel.Role.Where(role =>
                role.RoleId == findedUser.UserRole)
                .First();
            User.UserRole enumRole = User.GetRole(userRole.RoleName);
            Helper.CurrentUser = new User(
                findedUser.UserId,
                findedUser.UserLastName,
                findedUser.UserFirstName,
                findedUser.UserPatronymic,
                enumRole
                );
            MessageBox.Show(
                "Успешный вход в систему",
                "Авторизация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            FormCatalogue formCatalogue = new FormCatalogue();
            this.Hide();
            formCatalogue.ShowDialog();
            TextBoxLogin.Text = "";
            TextBoxPassword.Text = "";
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formSelectUser = new Form1();
            formSelectUser.dataGridView1.DataSource = Helper.DBModel.User.ToList();
            formSelectUser.Show();
        }

        private void TimerCaptcha_Tick(object sender, EventArgs e)
        {
            secondsForCapthca++;
            if (secondsForCapthca == 10)
            {
                captchaValue = GenerateCaptcha(4);
                DrawCaptcha(captchaValue);
                ButtonLogIn.Enabled = true;
                ButtonGuest.Enabled = true;
                secondsForCapthca = 0;
                TimerCaptcha.Stop();
            }
        }

        private void ButtonGuest_Click(object sender, EventArgs e)
        {
            if (captchaValue != null && TextBoxCaptcha.Text != captchaValue)
            {

                SetCaptcha();
                return;
            }
            Helper.CurrentUser = null;
            MessageBox.Show(
                "Успешный вход в систему",
                "Авторизация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            FormCatalogue formCatalogue = new FormCatalogue();
            this.Hide();
            formCatalogue.ShowDialog();
            TextBoxLogin.Text = "";
            TextBoxPassword.Text = "";
            this.Show();


        }
    }
}
