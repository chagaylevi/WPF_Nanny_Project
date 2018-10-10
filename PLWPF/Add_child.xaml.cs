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
using BE;

/// <summary>
/// this interface deal with the user
/// </summary>
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for Add_child.xaml
    /// </summary>
    public partial class Add_child : Window
    {
        BL.IBL bl;
        Child child;

        /// <summary>
        /// build function of the class/window for add child
        /// </summary>
        public Add_child()
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            update.IsEnabled = false;
            child = new BE.Child();
            DataContext = child;
        }

        /// <summary>
        /// build function which get a child  of the class/window for update 
        /// </summary>
        /// <param name="mychild">the child we get as parmeter</param>
        public Add_child(Child mychild)
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            this.add.IsEnabled = false;
            child = mychild;
            DataContext = child;
        }

        public Add_child(Mother mother)
        {
            id_motherTextBox.IsEnabled = false;
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            update.IsEnabled = false;
            DataContext = child;
        }

        /// <summary>
        /// button of add a child
        /// </summary>
        /// <param name="sender">object which operates the event</param>
        /// <param name="e"> event args</param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addChild(child);
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>
        /// button of update a child
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.update_detail_Child(child);
                child = new Child();
                this.DataContext = child;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
