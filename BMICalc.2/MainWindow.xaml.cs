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

namespace BMICalc._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public class Customer
        {
            public string lastName { get; set; }
            public string firstName { get; set; }
            public string phoneNumber { get; set; }
            public int heightInches { get; set; }
            public int weightLbs { get; set; }
            public int custBMI { get; set; }
            public string statusTitle { get; set; }
        }




        public MainWindow()
        {
            InitializeComponent();
        }


        #region Exit
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XPhoneBox.Text = "";
            XFirstNameBox.Text = "";
            XLastNameBox.Text = "";
            XHeightBox.Text = "";
            XWeightibsBox.Text = "";
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        private void submit_Click(object sender, RoutedEventArgs e)
        {

            Customer customer1 = new Customer();

            customer1.lastName = XLastNameBox.Text;
            customer1.firstName = XFirstNameBox.Text;
            customer1.phoneNumber = XPhoneBox.Text;

            int currentWeight = 0;
            int currentHeight = 0;
            Int32.TryParse(XWeightibsBox.Text, out currentWeight);
            Int32.TryParse(XHeightBox.Text, out currentHeight);
            customer1.weightLbs = currentWeight;
            customer1.heightInches = currentHeight;

            int bmi;
            bmi = 703 * customer1.weightLbs / (customer1.heightInches * customer1.heightInches);
            customer1.custBMI = bmi;

            string yourBMIStatus = "NA";
            customer1.statusTitle = yourBMIStatus;

            MessageBox.Show($"The customers name is {XFirstNameBox.Text} {XLastNameBox.Text} and they can be reached at {XPhoneBox.Text}. They're height is {XHeightBox.Text}. " +
                $"Their weight is {XWeightibsBox.Text}. Their BMI is {bmi}");

        }




    }
}
