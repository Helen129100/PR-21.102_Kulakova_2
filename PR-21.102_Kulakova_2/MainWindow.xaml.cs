using PR_21._102_Kulakova_2.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
using System.Xml;

namespace PR_21._102_Kulakova_2
{

    public partial class MainWindow : Window
    {
        public ObservableCollection<Teachers> Teachers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            using (var db = new Entities())
            {
                var data = db.Teachers.ToList();
                LoadData.ItemsSource = data;
            }
        }
       
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SortData(cbSort.Text);
        }
        private void SortData(string field)
        {
            if (string.IsNullOrEmpty(field))
            {
                return;
            }

            using (var db = new Entities())
            {
                List<Teachers> teachers;
                switch (field)
                {
                    case "Firstname":
                        teachers = db.Teachers.OrderBy(entity => entity.FirstName).ToList();
                        break;
                      case "Spec":
                        teachers = db.Teachers
                          .Join(db.Speciality, t => t.IdSpeciality, s => s.IdSpeciality, (t, s) => new { Teacher = t, SpecialtyName = s.Title })
                          .OrderBy(joined => joined.SpecialtyName)
                          .Select(joined => joined.Teacher)
                          .ToList();
                        break;
                    default:
                        teachers = db.Teachers.ToList();
                        break;
                }

            

                LoadData.ItemsSource = teachers;
            }
        }
      





        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
