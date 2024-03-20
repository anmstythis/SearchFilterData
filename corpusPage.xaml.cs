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
    /// Логика взаимодействия для corpusPage.xaml
    /// </summary>
    public partial class corpusPage : Page
    {
        neoCorpEntities neodb = new neoCorpEntities();
        public corpusPage()
        {
            InitializeComponent();
            CorpDgr.ItemsSource = neodb.corpus.ToList();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            CorpDgr.ItemsSource = neodb.corpus.ToList().Where(corp => corp.title.Contains(srch.Text) ||
            corp.speciality.Contains(srch.Text));
        }

    }
}
