﻿using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGumi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Tetel> tetelek = new ObservableCollection<Tetel>();

        List<String> atmerok = new List<String>() { "R10", "R12", "R13", "R14", "R15", "R16", "R17", "R18", "R19", "R20", "R21", "R22", "R23" };
        public MainWindow()
        {
            InitializeComponent();
            dgTetelek.ItemsSource = tetelek;
            FelveszDemoAdatokat();

        }

        private void FelveszDemoAdatokat()
        {
            tetelek.Add(new Tetel("nyári", 205, 55, "R16", 4));
            tetelek.Add(new Tetel("téli", 235, 55, "R18", 8));
            tetelek.Add(new Tetel("téli", 205, 55, "R16", 2));
        }

    }
}