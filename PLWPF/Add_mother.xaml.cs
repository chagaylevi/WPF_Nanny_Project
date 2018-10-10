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
    /// Interaction logic for Add_mother.xaml
    /// </summary>
    public partial class Add_mother : Window
    {
        BL.IBL bl;
        BE.Mother mother;

        /// <summary>
        /// build fun of the class/window of add mother
        /// </summary>
        public Add_mother()
        {
            InitializeComponent();
            mother = new BE.Mother();
            this.button1.IsEnabled = false;
            bl = BL.FactoryBL.getBL();
            this.button2.IsEnabled = false;
            DataContext = mother;
        }

        /// <summary>
        /// build fun of the class/window of update mother
        /// </summary>
        /// <param name="_mother">mother we send to update</param>
        public Add_mother(BE.Mother _mother)
        {
            bl = BL.FactoryBL.getBL();
            InitializeComponent();
            mother = _mother;
            this.button.IsEnabled = false;
            this.id_textBox.IsEnabled = false;
            DataContext = mother;
        }

        /// <summary>
        /// button for add a mother
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addMother(mother);
                MessageBox.Show("!הפרטים הוזנו בהצלחה");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Add_child_Click(object sender, RoutedEventArgs e)
        {
            bl.addMother(mother);
            Add_child child= new Add_child(mother);
            child.id_motherTextBox = id_textBox;
            child.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// if user puts to the text box text which is not correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void id_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            err1.Visibility = Visibility.Collapsed;
            long num;
            if (!long.TryParse(id_textBox.Text,out num)&&id_textBox.Text!="")
            {
                err1.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// if user puts to the text box text which is not correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            err2.Visibility = Visibility.Collapsed;
            long num;
            if (!long.TryParse(id_textBox.Text, out num) && id_textBox.Text != "")
            {
                err2.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// button for update a mother
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.update_detail_Mother(mother);
                mother = new BE.Mother();
                this.DataContext = mother;
                MessageBox.Show("!העדכון בוצע בהצלחה");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
