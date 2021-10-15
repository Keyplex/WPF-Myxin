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
using System.IO;
using Microsoft.Win32;
using Первый_проект.Программа;

namespace Первый_проект
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frmMain.Navigate(new LogPar());
            PageLoad.Load = frmMain;
            //frmMain.Navigate(new Page1());
            BaseConnect.BaseModel = new Entities1();


        }
        

        //private void Button_Click(object sender, RoutedEventArgs e) //Записать 
        //{

        //    string path = @"Text.txt";
        //    string dop = "";
        //    if (chbKind.IsChecked == true)
        //    {
        //        dop += (chbKind.Content) + ";";
        //    }
        //    if (chbCommunicate.IsChecked == true)
        //    {
        //        dop += (chbCommunicate.Content) + ";";
        //    }
        //    if (chbModest.IsChecked == true)
        //    {
        //        dop += (chbModest.Content) + ";";
        //    }

        //    //FileInfo f1 = new FileInfo(path);
        //    //using (StreamWriter sw = f1.AppendText())
        //    //{
        //    //    //sw.WriteLine("Hello");
        //    //    sw.WriteLine(txtName.Text);
        //    //    sw.WriteLine(DataRozh.Text);
        //    //    ListBoxItem li = (ListBoxItem)Vibrat.SelectedItem;
        //    //    sw.WriteLine(li.Content);//это почти тоже, что и text
        //    //    sw.WriteLine(dop);
        //    //}
        //    using (BinaryWriter sw = new BinaryWriter(File.Open(path, FileMode.Append)))
        //    {
        //        sw.Write(txtName.Text);
        //        sw.Write(DataRozh.Text);
        //        //ListBoxItem li = (ListBoxItem)Vibrat.SelectedItem;
        //        //sw.WriteLine(li.Content);//это почти тоже, что и text
        //        ListBoxItem li = (ListBoxItem)Vibrat.SelectedItem;
        //        //sw.Write(li.);
        //        sw.Write(dop);
        //    }


        //    //надо создавать отдельно элемент списка. типа listboxitem и уже у него есть свойство text. вроде в каком-то из моих видео есть это
        //    //StreamReader sr = f1.OpenText();
        //}

        private void Button_Click_1(object sender, RoutedEventArgs e) //Прочитать
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
