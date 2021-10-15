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
    /// Логика взаимодействия для PageUsersLisl.xaml
    /// </summary>
    public partial class PageUsersLisl : Page
    {
        List<users> users;
        public PageUsersLisl()
        {
            InitializeComponent();
            users = BaseConnect.BaseModel.users.ToList();
            //lbUsersList.ItemsSource = BaseConnect.BaseModel.users.ToList();
            lbUsersList.ItemsSource = users;
        }


        private void lbTraits_Loaded(object sender, RoutedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            //lb.Items.Add("Проверка связи");
            int index = Convert.ToInt32(lb.Uid);
            lb.ItemsSource = BaseConnect.BaseModel.users_to_traits.Where(x => x.id_user == index).ToList();
            lb.DisplayMemberPath = "traits.trait";
        }

        private void lbUsersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            int OT = Convert.ToInt32(txtOT.Text);
            int DO = Convert.ToInt32(txtDO.Text);
            List<users> lu1 = users.Skip(OT).Take(DO - OT).ToList(); // skip - пропустить определенное количество записей , take - выбрать определенное количество записей
            lbUsersList.ItemsSource = lu1;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lbUsersList.ItemsSource = users; //в качестве источника данных новый список
        }

        private void btnReset_Click_1(object sender, RoutedEventArgs e)
        {
            PageLoad.Load.GoBack();
        }
    }
}
