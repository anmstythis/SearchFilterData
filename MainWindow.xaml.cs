﻿using System;
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

namespace prct4_dataset
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PageFrame.Content = new staffPage();
        }

        private void staffButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new staffPage();
        }

        private void postButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new postPage();
        }

        private void corpButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new corpusPage();
        }
    }
}
