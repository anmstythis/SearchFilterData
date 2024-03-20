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
    /// Логика взаимодействия для postPage.xaml
    /// </summary>
    public partial class postPage : Page
    {
        neoCorpEntities neodb = new neoCorpEntities();
        public postPage()
        {
            InitializeComponent();
            PostDgr.ItemsSource = neodb.staffpost.ToList();
            filterCbx.ItemsSource = neodb.corpus.ToList();
            filterCbx.DisplayMemberPath = "title";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            PostDgr.ItemsSource = neodb.staffpost.ToList().Where(post => post.postname.Contains(srch.Text));
        }

        private void filterButton_Click(object sender, RoutedEventArgs e)
        {
            if (filterCbx.SelectedItem != null)
            {
                var selected = filterCbx.SelectedItem as corpus;
                PostDgr.ItemsSource = neodb.staffpost.ToList().Where(item => item.corp_ID == selected.ID_corp);
            }
        }
    }
}
