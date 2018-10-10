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
using System.Globalization;
using BE;

/// <summary>
/// this interface deal with the user
/// </summary>
namespace PLWPF
{

    /// <summary>
    /// this class convert a value to other value(from string to double and from double to string)
    /// </summary>
    class convertSalary : IValueConverter
    {
        public object Convert(object value, Type type, object par, CultureInfo cultureInfo)
        {
            if (value == null || (double)value == 0) return "";
            return ((double)value).ToString();
        }
        public object ConvertBack(object value, Type type, object par, CultureInfo cultureInfo)
        {
            if ((string)value == "") return 0;
            return double.Parse((string)value);
        }

    }
    /// <summary>
    /// Interaction logic for Contract_Menu.xaml
    /// </summary>
    public partial class Contract_Menu : Window
    {
        Nanny nanny = new Nanny();
        BL.BL_imp bl;
        Contract contract;
        Mother mother = new Mother();
        public double payments;

        /// <summary>
        /// build function of the class/window for add a contract
        /// </summary>
        /// <param name="temp_nanny">nanny in the contract</param>
        /// <param name="temp_mother">nother in the contract</param>
        public Contract_Menu(Nanny temp_nanny, Mother temp_mother)
        {
            InitializeComponent();
            bl = new BL.BL_imp();
            signing_a_contractCheckBox.IsEnabled = false;
            this.sign_nanny.IsEnabled = false;
            this.cancel_nanny.IsEnabled = false;
            contract = new Contract();
            nanny = temp_nanny;
            mother = temp_mother;
            contract.name_nanny = nanny.firstName;
            contract.name_mother = mother.firstName;
            contract.MotherAddress = mother.address;
            this.name_mother.Text = mother.firstName;
            contract.id_mother = mother.id;
            contract.id_nanny = nanny.id;
            contract.MotherAddress = mother.address;
            contract.per_hour = nanny.hourly_rate;
            contract.per_month = nanny.monthly_rate;
            contract.NannyAddres = nanny.address;
            this.DataContext = contract;
        }

        /// <summary>
        /// build function of the class/window for update a contract
        /// </summary>
        /// <param name="mycontract">this contract will dispaly for updating</param>
        public Contract_Menu(Contract mycontract)
        {
            InitializeComponent();
            this.sign_mom.IsEnabled = false;
            signing_a_contractCheckBox.IsEnabled = false;
            this.checking.IsEnabled = false;
            bl = new BL.BL_imp();
            contract = new Contract();
            contract = mycontract;
            this.DataContext = contract;
        }

        /// <summary>
        /// button of mother's confirm  for the contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sign_mom_Click(object sender, RoutedEventArgs e)
        {
            nanny.MyContract.Add(contract);
            this.Close();
        }

        /// <summary>
        /// button for a nanny's cancel for the contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, RoutedEventArgs e)
        {

            nanny.MyContract.RemoveAll(x => x.id_child == contract.id_child);
            this.Close();
        }

        /// <summary>
        /// button for nanny's confirm for add a contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sign_nanny_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addContract(contract);
                //we remove it from the private list of nanny and send it to data source
                nanny.MyContract.RemoveAll(x => x.id_child == contract.id_child);
            }
            catch (FormatException)
            {
                MessageBox.Show("בדוק את הקלט");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        /// <summary>
        /// calculate the payment and other things
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_payment(object sender, RoutedEventArgs e)
        {
            try
            {
                contract = bl.CheckContract(contract, mother, nanny, bl.getChild(contract.id_child));
                this.payment.Text = contract.payment.ToString();
                name_childTextBox.Text = contract.name_child;
                dateOfBirthing.Text = contract.dateOfBirth.ToLongDateString();
                this.DataContext = contract;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// button for a update a contract
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_(object sender, RoutedEventArgs e)
        {
            bl.update_detail_Contract(contract);
            this.Close();
        }
    }
}
