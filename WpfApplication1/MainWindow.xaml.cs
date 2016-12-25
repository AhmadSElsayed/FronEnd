using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WpfApplication1.Controller;
using WpfApplication1.Views;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new BranchSelect().Show();
            Close();
        }
    }
}
