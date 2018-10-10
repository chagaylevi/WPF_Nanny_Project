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
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {

        BE.Mother temp = new BE.Mother();

        /// <summary>
        /// build fun for class/window to display the mother the options
        /// </summary>
        /// <param name="mother"></param>
        public Options(BE.Mother mother)
        {
            InitializeComponent();
            temp = mother;
        }

        /// <summary>
        /// button for search nannies aroundings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void around_nannies_button(object sender, RoutedEventArgs e)
        {
            new Results(temp, 0, 0).ShowDialog();
            this.Close();

        }

        /// <summary>
        /// button for search suit nannies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suit_nannies_button(object sender, RoutedEventArgs e)
        {
            new Results(temp, 1, 0).ShowDialog();
            this.Close();
        }

    }
}
