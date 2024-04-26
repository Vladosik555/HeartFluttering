﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization;
using HeartFluttering.Resources.Localization.EditingForms;
using NLog;

namespace HeartFluttering
{
    public partial class EditingForm : Form
    {
        public User user;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public EditingForm()
        {
            InitializeComponent();
            logger.Info("Инициализация данных");
        }
        /// <summary>
        /// Кнопка для закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Закрытие приложения");
            Application.Exit();
        }
        /// <summary>
        /// Кнопка для сворачивания приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Сворачивание приложения");
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// При нажатии на строку имени, подсказка пропадает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text.Equals(InscriptionsEditing.StringIsEmpty))
            {
                nameField.Text = string.Empty;
                nameField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки имени, подсказка появляется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text.Equals(string.Empty))
            {
                nameField.ForeColor = Color.Gray;
                nameField.Text = InscriptionsEditing.StringIsEmpty;
            }
        }
        /// <summary>
        /// При нажатии на строку фамилии, подсказка пропадает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text.Equals(InscriptionsEditing.StringIsEmpty))
            {
                surnameField.Text = string.Empty;
                surnameField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки фамилии, подсказка появляется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text.Equals(string.Empty))
            {
                surnameField.ForeColor = Color.Gray;
                surnameField.Text = InscriptionsEditing.StringIsEmpty;
            }
        }
        /// <summary>
        /// При нажатии на строку даты рождения, подсказка пропадает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void birhdayField_Enter(object sender, EventArgs e)
        {
            if (birhdayField.Text.Equals(InscriptionsEditing.StringIsEmpty))
            {
                birhdayField.Text = string.Empty;
                birhdayField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки даты рождения, подсказка появляется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void birhdayField_Leave(object sender, EventArgs e)
        {
            if (birhdayField.Text.Equals(string.Empty))
            {
                birhdayField.ForeColor = Color.Gray;
                birhdayField.Text = InscriptionsEditing.StringIsEmpty;
            }
        }
        /// <summary>
        /// При нажатии на строку города, подсказка пропадает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cityField_Enter(object sender, EventArgs e)
        {
            if (cityField.Text.Equals(InscriptionsEditing.StringIsEmpty))
            {
                cityField.Text = string.Empty;
                cityField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки города, подсказка появляется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cityField_Leave(object sender, EventArgs e)
        {
            if (cityField.Text.Equals(string.Empty))
            {
                cityField.ForeColor = Color.Gray;
                cityField.Text = InscriptionsEditing.StringIsEmpty;
            }
        }
        /// <summary>
        /// При нажатии на строку почты, подсказка пропадает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text.Equals(InscriptionsEditing.StringIsEmpty))
            {
                emailField.Text = string.Empty;
                emailField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки почты, подсказка появляется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text.Equals(string.Empty))
            {
                emailField.ForeColor = Color.Gray;
                emailField.Text = InscriptionsEditing.StringIsEmpty;
            }
        }
        /// <summary>
        /// При нажатии на строку номера телефона, подсказка пропадает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberField_Enter(object sender, EventArgs e)
        {
            if (numberField.Text.Equals(InscriptionsEditing.StringIsEmpty))
            {
                numberField.Text = string.Empty;
                numberField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки номера телефона, подсказка появляется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberField_Leave(object sender, EventArgs e)
        {
            if (numberField.Text.Equals(string.Empty))
            {
                numberField.ForeColor = Color.Gray;
                numberField.Text = InscriptionsEditing.StringIsEmpty;
            }
        }
        /// <summary>
        /// Возвращения на главную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            CurrentUser.currentUser = user;
            logger.Trace("Переход в главную форму");
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
        /// <summary>
        /// Кнопка для редактирования пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redactionButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var person = context.Users.FirstOrDefault(r => r.Id.Equals(user.Id));
                    logger.Info("Получение текущего пользователя из базы данных");
                    if (person == null)
                    {
                        MessageBox.Show(InscriptionsEditing.UserNotFound);
                        return;
                    }
                    if (nameField.Text == string.Empty && nameField.Text.Equals(InscriptionsEditing.StringIsEmpty))
                    {
                        MessageBox.Show(InscriptionsEditing.Name);
                        return;
                    }
                    if (surnameField.Text == string.Empty && surnameField.Text.Equals(InscriptionsEditing.StringIsEmpty))
                    {
                        MessageBox.Show(InscriptionsEditing.Surname);
                    }

                    foreach (char letter in nameField.Text)
                    {
                        if (!Char.IsLetter(letter))
                        {
                            MessageBox.Show(InscriptionsEditing.LetterInName);
                            return;
                        }
                    }
                    logger.Warn("Проверка имени на корректные символы");
                    person.Name = nameField.Text;
                    foreach (char letter in surnameField.Text)
                    {
                        if (!Char.IsLetter(letter))
                        {
                            MessageBox.Show(InscriptionsEditing.LetterInSurname);
                            return;
                        }
                    }
                    logger.Warn("Проверка фамилии на корректные символы");
                    person.Surname = surnameField.Text;
                    DateTime time = birhdayField.Value;
                    int yearOld = time.Year;
                    int yearNow = DateTime.Now.Year;
                    if ((yearNow - yearOld) < 18)
                    {
                        MessageBox.Show(InscriptionsEditing.Youth);
                        return;
                    }
                    if ((yearNow - yearOld) > 120)
                    {
                        MessageBox.Show(InscriptionsEditing.Old);
                        return;
                    }
                    logger.Info("Проверка на корректный возраст");
                    DateTime birth = new DateTime(time.Year, time.Month, time.Day);
                    person.DateOfBirth = birth.ToString();
                    if (cityField.Text == string.Empty && cityField.Text.Equals(InscriptionsEditing.StringIsEmpty))
                    {
                        MessageBox.Show(InscriptionsEditing.City);
                    }
                    AllCities Allcities = new AllCities();
                    if (!Allcities.getCities().Contains(cityField.Text.ToLower()))
                    {
                        MessageBox.Show(InscriptionsEditing.CityNotExist);
                        return;
                    }
                    logger.Warn("Проверка на существующий город");
                    person.City = cityField.Text;

                    if (sexMenButton.Checked)
                    {
                        person.Sex = 1;
                    }
                    if (sexWomenButton.Checked)
                    {
                        person.Sex = 0;
                    }
                    if (emailField.Text == string.Empty && emailField.Text.Equals(InscriptionsEditing.StringIsEmpty))
                    {
                        person.Mail = null;
                    }
                    person.Mail = emailField.Text;
                    string number = numberField.Text;
                    if (number != string.Empty)
                    {
                        foreach (char numb in number)
                        {
                            if (!Char.IsNumber(numb))
                            {
                                MessageBox.Show(InscriptionsEditing.NumsInPhone);
                                return;
                            }
                        }
                    }
                    else
                    {
                        person.Number = null;
                    }
                    logger.Warn("Проверка номера на корректный номер");
                    person.Number = number;
                    HomeForm homeForm = new HomeForm();
                    CurrentUser.currentUser = person;
                    logger.Debug("Изменение текущего пользователя в базу данных после изменение полей");
                    context.SaveChanges();
                    logger.Trace("Открытие главной формы");
                    this.Hide();
                    homeForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка в подключении к базе данных");
            }
        }
    }
}
