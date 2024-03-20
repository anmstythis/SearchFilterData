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
using prct4_dataset.neoCorpDataSetTableAdapters;

namespace prct4_dataset
{
    /// <summary>
    /// Логика взаимодействия для corpusPage.xaml
    /// </summary>
    public partial class corpusPage : Page
    {
        public corpusTableAdapter corp = new corpusTableAdapter();
        public corpusPage()
        {
            InitializeComponent();
            CorpDgr.ItemsSource = corp.GetData();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            CorpDgr.ItemsSource = corp.SearchDataBy(srch.Text);
        }
    }
}
