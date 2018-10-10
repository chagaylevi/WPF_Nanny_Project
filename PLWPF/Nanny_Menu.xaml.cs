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


/// <summary>
/// this interface deal with the user
/// </summary>
namespace PLWPF
{

    /// <summary>
    /// this class convert a value to other value(from string to int and from int to string)
    /// </summary>
    public class convertId : IValueConverter
    {
        public object Convert(object value, Type type, object par, CultureInfo cultureInfo)
        {
            if (value == null || (int?)value == 0) return "";
            return ((int)value).ToString();
        }
        public object ConvertBack(object value, Type type, object par, CultureInfo cultureInfo)
        {
            if ((string)value == "" || (string)value == null) return 0;
            return int.Parse((string)value);
        }
    }

    /// <summary>
    /// Interaction logic for Nanny_Menu.xaml
    /// </summary>
    public partial class Nanny_Menu : Window
    {
        BE.Nanny nanny;
        BL.BL_imp bl;

        /// <summary>
        /// build fun for the class/window pf add a new nanny
        /// </summary>
        public Nanny_Menu()
        {
            errorMwsagges = new List<string>();
            InitializeComponent();
            bl = new BL.BL_imp();
            nanny = new BE.Nanny();
            this.update_nanny.IsEnabled = false;
            this.DataContext = nanny;
        }

        /// <summary>
        /// ctor for updates nanny
        /// </summary>
        /// <param name="update_nanny">nanny we send to update</param>
        public Nanny_Menu(BE.Nanny update_nanny)
        {
            errorMwsagges = new List<string>();
            InitializeComponent();
            bl = new BL.BL_imp();
            this.add_nanny.IsEnabled = false;
            nanny = update_nanny;
            this.FloorUpDown.Value = nanny.floor;
            this.max_age.Value = nanny.max_age;
            this.min_age.Value = nanny.min_age;
            this.YearsUpDown.Value = (int)nanny.years_of_experience;
            this.max_count.Value = nanny.max_of_children;
            this.idTextBox.IsEnabled = false;
            this.firstNameTextBox.IsEnabled = false;
            this.lastNameTextBox.IsEnabled = false;
            this.date_of_birthDatePicker.IsEnabled = false;
            this.DataContext = nanny;
        }

        /// <summary>
        /// button for add a nanny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_nanny_Click(object sender, RoutedEventArgs e)
        {
            if (errorMwsagges.Any())
            {
                string err = "Exaption:";
                foreach (var item in errorMwsagges)
                    err += "\n" + item;
                MessageBox.Show(err);
                return;
            }
            try
            {

                bl.addNanny(nanny);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("cheak your input..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// list of errors
        /// </summary>
        private List<string> errorMwsagges;

        /// <summary>
        /// button for update nanny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_nanny_Click(object sender, RoutedEventArgs e)
        {

            if (errorMwsagges.Any())
            {
                string err = "Exaption:";
                foreach (var item in errorMwsagges)
                    err += "\n" + item;
                MessageBox.Show(err);
                return;
            }

            try
            {

                bl.update_details_Nanny(nanny);
                nanny = new BE.Nanny();
                this.DataContext = nanny;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// display the list of errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errorMwsagges.Add(e.Error.Exception.Message);
            else
                errorMwsagges.Remove(e.Error.Exception.Message);
        }

        /// <summary>
        /// button for exit from the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
