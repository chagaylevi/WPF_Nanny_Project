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
using System.Collections.ObjectModel;
using System.Globalization;
using BE;
using System.Threading;

namespace PLWPF
{
    /// <summary>
    /// class for the data template
    /// </summary>
    public class myResult
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string address { set; get; }
        public string name { set; get; }
        public int? id { set; get; }
        public int? num_of_contract { set; get; }
        public double payment { set; get; }
        public DateTime date_of_begin { set; get; }
        public DateTime date_of_end { set; get; }
        public DateTime date_of_birth { set; get; }
        public int? id_child { set; get; }
    }



    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        Mother temp_mom = new Mother();
        BL.BL_imp bl;

        /// <summary>
        /// build fun for class/window ,get parmeters to how to build the window
        /// </summary>
        /// <param name="mother">mother of child</param>
        /// <param name="num">num for choose the current option</param>
        /// <param name="id">id of nanny</param>
        public Results(Mother mother, int num, int id)
        {
            InitializeComponent();
            bl = new BL.BL_imp();
            temp_mom = mother;

            try
            {
                if (num == 1)
                {
                    this.listNannies.DataContext = bl.properList(mother);
                }
                if (num == 0)
                {
                    this.listNannies.DataContext = bl.Nannies_around(mother);
                }
                if (num == 2)
                {
                    foreach (Contract item in bl.getNanny(id).MyContract)
                    {
                        new Contract_Menu(item).Show();
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("בדוק את הקלט");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///  build fun for class/window ,get parmeters to how to build the window
        /// </summary>
        /// <param name="n">num for choose option</param>
        public Results(int n)
        {
            InitializeComponent();
            bl = new BL.BL_imp();
            switch (n)
            {
                case 1:
                    this.nannies_mothers.DataContext = bl.NannyList();
                    break;
                case 2:
                    this.nannies_mothers.DataContext = bl.MotherList();
                    break;
                case 3:
                    this.children.DataContext = bl.ChildList();
                    this.nannies_mothers.DataContext = bl.NannyList();
                    break;
                case 4:
                    this.contracts.DataContext = bl.ContractList();
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// button for see the contract, the tag identify the specific nanny 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sign(object sender, RoutedEventArgs e)
        {
            try
            {
                Button b = sender as Button;
                int id = (int)b.Tag;
                new Contract_Menu(bl.getNanny(id), temp_mom).ShowDialog();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}
