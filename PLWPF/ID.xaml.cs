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

/// <summary>
/// this interface deal with the user
/// </summary>
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for ID.xaml
    /// </summary>
    public partial class ID : Window
    {
        private string mystr;
        BL.BL_imp bl;

        /// <summary>
        /// build function for the class/window to know which get a string which contatins info what to do
        /// </summary>
        /// <param name="str">information</param>
        public ID(string str)
        {
            if (str == "contract")
            {
                label_contract.Visibility = Visibility.Visible;
                label.Visibility = Visibility.Collapsed;
            }
            InitializeComponent();
            bl = new BL.BL_imp();
            mystr = str;
        }

        /// <summary>
        /// button for the many options we do regars to the string we get as parmeter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            BE.Mother mother = new BE.Mother();
            int _id;
            try
            {
                _id = int.Parse(this.textBox.Text);
                switch (mystr)
                {
                    case "nanny":
                        bl.removeNanny(_id);
                        break;
                    case "mother":
                        bl.removeMother(_id);
                        break;
                    case "contract":
                        bl.removeContract(_id);
                        break;
                    case "child":
                        bl.removeChild(_id);
                        break;
                    case "updateChild":
                        new Add_child(bl.getChild(_id)).ShowDialog();
                        break;
                    case "update_mother":
                        new Add_mother(bl.getMother(_id)).ShowDialog();
                        break;
                    case "update_nanny":
                        new Nanny_Menu(bl.getNanny(_id)).ShowDialog();
                        break;
                    case "search_nannies":
                        if (bl.NannyList().Count == 0) throw new Exception("מצטערים אין כרגע מטפלות במערכת");
                        new Options(bl.getMother(_id)).ShowDialog();
                        break;
                    case "check_con":
                        if (bl.getNanny(_id).MyContract.Count == 0) throw new Exception("אין חוזים לחתימה בשלב זה");
                        new Results(null, 2, _id);
                        break;
                    default:
                        break;

                }
                mystr = "";
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
