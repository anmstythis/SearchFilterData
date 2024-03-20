using System;
using System.Collections.Generic;
using System.Data;
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
using prct4_dataset.neoCorpDataSetTableAdapters;

namespace prct4_dataset
{
    /// <summary>
    /// Логика взаимодействия для staffPage.xaml
    /// </summary>
    public partial class staffPage : Page
    {
        staffTableAdapter staffinfo = new staffTableAdapter();
        postPage postName = new postPage();
        public staffPage()
        {
            InitializeComponent();
            StaffDgr.ItemsSource = staffinfo.GetData();
            filterCbx.ItemsSource = postName.post.GetData();
            filterCbx.DisplayMemberPath = "postname";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            StaffDgr.ItemsSource = staffinfo.SearchDataBy(srch.Text);
        }

        private void filterButton_Click(object sender, RoutedEventArgs e)
        {
            if (filterCbx.SelectedItem != null)
            {
                var id = (int)(filterCbx.SelectedItem as DataRowView).Row[0];
                StaffDgr.ItemsSource = staffinfo.FilterDataBy(id);
            }
        }
    }
}
