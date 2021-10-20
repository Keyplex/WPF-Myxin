using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для adminMenu.xaml
    /// </summary>
    public partial class adminMenu : Page
    {
        
        public adminMenu()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.Load.GoBack();
        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {

            //PageLoad.Load.Navigate(new adminMenu());
            //MessageBox.Show("Вы нажали изменили");
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            auth SelectedUser = (auth)dgUsers.SelectedItem;
            BaseConnect.BaseModel.auth.Remove(SelectedUser);
            BaseConnect.BaseModel.SaveChanges();
            MessageBox.Show("Выбранный пользователь удален");
            //dgUsers.ItemsSource = BaseConnect.BaseModel.auth.ToList();
        }

        private void btnSaveCahanges_Click(object sender, RoutedEventArgs e)
        {
            List<auth> LUserDB = BaseConnect.BaseModel.auth.ToList();
            List<auth> LUser = BaseConnect.BaseModel.auth.ToList();
            var Luser1 = LUserDB.Except(LUserDB);

            foreach (auth u in Luser1)
            {
                BaseConnect.BaseModel.auth.Remove(u);
            }

            foreach (auth u in LUser)
            {
                BaseConnect.BaseModel.auth.AddOrUpdate(u);
            }

            BaseConnect.BaseModel.SaveChanges();
            MessageBox.Show("Вы нажали сохранять");
        }

        private void btnClientList_Click(object sender, RoutedEventArgs e)
        {
            
            dgUsers.ItemsSource = BaseConnect.BaseModel.auth.ToList();
        }
    }
}
