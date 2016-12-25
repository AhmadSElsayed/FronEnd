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
using System.Windows.Shapes;
using WpfApplication1.Model;

namespace WpfApplication1.Views
{
    /// <summary>
    /// Interaction logic for Branch.xaml
    /// </summary>
    public partial class BranchWindow : Window
    {
        public BranchWindow(AllBranchData Data, Dictionary<int, int> Product, List<int>Employee, int Products, int Employees)
        { 
            InitializeComponent();

            branchID.Text = Data.BranchID.ToString();
            name.Text = Data.Name.ToString();
            location.Text = Data.Location.ToString();
            profit.Text = Data.Profit.ToString();
            sales.Text = Data.Sales.ToString();

            productBarCode.ItemsSource = Product;
            productBarCode.DisplayMemberPath = "Key";
            productBarCode.SelectedValuePath = "Value";

            employeeID.ItemsSource = Employee;

            products.Text = Products.ToString();
            employees.Text = Employees.ToString();
        }

        private void productBarCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            quntity.Text = ((ComboBox)sender).SelectedValue.ToString();
        }
    }
}
