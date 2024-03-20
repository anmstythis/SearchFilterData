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
    /// Логика взаимодействия для postPage.xaml
    /// </summary>
    public partial class postPage : Page
    {
        public staffpostTableAdapter post = new staffpostTableAdapter();
        corpusPage Corpus = new corpusPage();
        public postPage()
        {
            InitializeComponent();
            PostDgr.ItemsSource = post.GetData();
            filterCbx.ItemsSource = Corpus.corp.GetData();
            filterCbx.DisplayMemberPath = "title";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            PostDgr.ItemsSource = post.SearchDataBy(srch.Text);
        }

        private void filterButton_Click(object sender, RoutedEventArgs e)
        {
            if (filterCbx.SelectedItem != null)
            {
                var id = (int)(filterCbx.SelectedItem as DataRowView).Row[0];
                PostDgr.ItemsSource = post.FilterDataBy(id);
            }
        }
    }
}
