using Newtonsoft.Json;
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
using WpfApplication1.Controller;
using WpfApplication1.Model;

namespace WpfApplication1.Views
{
    /// <summary>
    /// Interaction logic for BranchSelect.xaml
    /// </summary>
    public partial class BranchSelect : Window
    {
        public BranchSelect()
        {
            InitializeComponent();
            var branches = ApiController.Get<Branch>("Branch").Result;
            branchSelector.ItemsSource = branches;
        }

        private void Click_Click(object sender, RoutedEventArgs e)
        {
            var ID = ((Branch)branchSelector.SelectedItem).BranchID;
            var temp = ApiController.Get<AllBranchData>("Branch", new KeyValuePair<string, object>("BranchID", ID)).Result;
            var temp1 = JsonConvert.DeserializeObject<List<BranchProducts>>(ApiController.Post<List<BranchProducts>>("Branch", null, new KeyValuePair<string, object>("BranchID", ID)).Result);
            var temp2 = JsonConvert.DeserializeObject<List<EmployeeInWorkingPlace>>(ApiController.Put<List<EmployeeInWorkingPlace>>("Branch", null, new KeyValuePair<string, object>("BranchID", ID)).Result);
            var temp3 = JsonConvert.DeserializeObject<KeyValuePair<int,int>>(ApiController.Delete<KeyValuePair<int,int>>("Branch", new KeyValuePair<string, object>("BranchID", ID)).Result);

            var dic = new Dictionary<int, int>();
            foreach (var item in temp1)
            {
                dic.Add(item.ProductBarCode, item.Quntity);
            }
            var lis = new List<int>();
            foreach (var item in temp2)
            {
                lis.Add(item.EmployeeID);
            }
            new BranchWindow(temp.First(), dic, lis, temp3.Key, temp3.Value).Show();         
        }
    }
}
