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
    /// Логика взаимодействия для registr.xaml
    /// </summary>
    public partial class registr : Page
    {
        public registr()
        {
            InitializeComponent();
            listGenders.ItemsSource = BaseConnect.BaseModel.genders.ToList();//выбор источника данных 
            listGenders.SelectedValuePath = "id";//индексы пунктов списка
            listGenders.DisplayMemberPath = "gender";//то, что отображается для пользователя

            lbTarits.ItemsSource = BaseConnect.BaseModel.traits.ToList();
            lbTarits.SelectedValuePath = "id";
        }

        private void btnRecord_Click(object sender, RoutedEventArgs e)
        {
            auth LogPass = new auth() { login = txtLog.Text, password = txtPass.Password, role = 2 }; // создать новую запись
            BaseConnect.BaseModel.auth.Add(LogPass);//добавить в модель
            BaseConnect.BaseModel.SaveChanges();//сонхронизировать с сервером

            //создаем запись в таблице Users, соответствующую данной
            users User = new users() { name = txtName.Text, id = LogPass.id, gender = (int)listGenders.SelectedValue, dr = (DateTime)dpdr.SelectedDate };
            BaseConnect.BaseModel.users.Add(User);

            foreach(traits t in lbTarits.SelectedItems)
            {
                users_to_traits UTT = new users_to_traits();
                UTT.id_user = User.id;
                UTT.id_trait = t.id;
                BaseConnect.BaseModel.users_to_traits.Add(UTT);
            }
            BaseConnect.BaseModel.SaveChanges();
            MessageBox.Show("Данные записаны успешно");//обратная связь с пользователем
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PageLoad.Load.GoBack();
        }
    }
}
