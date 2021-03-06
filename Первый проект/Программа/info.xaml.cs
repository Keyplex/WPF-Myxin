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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

        }
        public Page1(auth CurrentUser)
        {
            InitializeComponent();
            try
            {
                tbName.Text = CurrentUser.users.name;
                tbDR.Text = CurrentUser.users.dr.ToString("yyyy MMMM dd");
                tbGender.Text = CurrentUser.users.genders.gender;
                List<users_to_traits> LUTT = BaseConnect.BaseModel.users_to_traits.Where(x => x.id_user == CurrentUser.id).ToList();
                foreach(users_to_traits UT in LUTT)
                {
                    tbTraits.Text += UT.traits.trait + "; ";
                }
            }
            catch
            {
                MessageBox.Show("Информация о вас нет в системе");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PageLoad.Load.GoBack();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        } 

        //private void btnBack_Click(object sender, RoutedEventArgs e)
        //{
        //    PageLoad.Load.GoBack();
        //}
    }
}
