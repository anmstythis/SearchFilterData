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

namespace prct4_entity_framework
{
    /// <summary>
    /// Логика взаимодействия для staffPage.xaml
    /// </summary>
    public partial class staffPage : Page
    {
        neoCorpEntities neodb = new neoCorpEntities();
        public staffPage()
        {
            InitializeComponent();
            StaffDgr.ItemsSource = neodb.staff.ToList();
            filterCbx.ItemsSource = neodb.staffpost.ToList();
            filterCbx.DisplayMemberPath = "postname";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            StaffDgr.ItemsSource = neodb.staff.ToList().Where(text => text.firstname.Contains(srch.Text) ||
            text.surname.Contains(srch.Text) || 
            text.middlename.Contains(srch.Text));
        }

        private void filterButton_Click(object sender, RoutedEventArgs e)
        {
            if (filterCbx.SelectedItem != null)
            {
                var selected = filterCbx.SelectedItem as staffpost;
                StaffDgr.ItemsSource = neodb.staff.ToList().Where(item => item.post_ID == selected.ID_post);
            }
        }
    }
}
