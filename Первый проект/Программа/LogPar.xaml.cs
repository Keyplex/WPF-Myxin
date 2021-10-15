using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Первый_проект.Программа
{
    /// <summary>
    /// Логика взаимодействия для LogPar.xaml
    /// </summary>
    public partial class LogPar : Page
    {
        public LogPar()
        {
            InitializeComponent();            
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
             
            //PageLoad.Load.Navigate(new  Page1());
            //BaseConnect.BaseModel = new SQL();
            try
            {
                auth CurrentUser = BaseConnect.BaseModel.auth.FirstOrDefault(x => x.login == txtLogin.Text && x.password == txtPasswor.Password);             
                if (CurrentUser != null)
                {
                    switch(CurrentUser.role)
                    {
                        case 1:
                            MessageBox.Show("Вы вошли как администратор");
                            PageLoad.Load.Navigate(new adminMenu());
                            break;
                        case 2:
                        default:
                            MessageBox.Show("Вы вошли как обычный пользователь");
                            PageLoad.Load.Navigate(new Page1(CurrentUser));
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя нет");
                }
            }
            catch
            {
                MessageBox.Show("Какая-то неизвестная ошибка");
            }

        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.Load.Navigate(new registr());
        }

        private void PageUrersList_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                auth CurrentUser = BaseConnect.BaseModel.auth.FirstOrDefault(x => x.login == txtLogin.Text && x.password == txtPasswor.Password);
                if (CurrentUser != null)
                {
                    switch (CurrentUser.role)
                    {
                        case 1:
                            MessageBox.Show("Вы вошли как администратор");
                            PageLoad.Load.Navigate(new PageUsersLisl());
                            break;
                        case 2:
                        default:
                            MessageBox.Show("Вы вошли как обычный пользователь");
                            PageLoad.Load.Navigate(new Page1(CurrentUser));
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Такого пользователя нет");
                }
            }
            catch
            {
                MessageBox.Show("Какая-то неизвестная ошибка");
            }
        }
    }
}
