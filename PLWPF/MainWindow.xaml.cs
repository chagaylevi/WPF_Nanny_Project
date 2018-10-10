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
using BE;

/// <summary>
/// this interface deal with the user
/// </summary>
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] str_nanny = new string[] { "הוספת מטפלת", "הסרת מטפלת", "עדכון פרטים", "אישור חוזה" };
        string[] str_mother = new string[] { "הוספת אמא", "הסרת אמא", "עדכון פרטי אמא", "הוספת ילד", "הסרת ילד", "עדכון פרטי ילד", "חיפוש מטפלת" };
        string[] str_options = new string[] { "הצג את כל האימהות", "הצג את כל המטפלות", "הצג את כל הילדים", "הצג את כל החוזים" };
        BL.IBL bl;
        /// <summary>
        /// build function of the main window, and initialize with some nannies mothers and children
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            listBox_nanny.ItemsSource = str_nanny;
            listBox_mother.ItemsSource = str_mother;
            listBox_options.ItemsSource = str_options;

            /*Mother mother1 = new Mother
            {
                address = "נחל יעלה 3 בית שמש",
                search_area = "נחל צאלים 8 בית שמש",
                count_of_children = 1,
                firstName = "orna",
                lastName = "zohar",
                signle_mother = false,
                id = 111111,
                phone = " 0504171895",
            };
            Mother mother2 = new Mother
            {
                address = "הרצל 134 בית שמש ",
                search_area = "נחל קטלב 5 בית שמש",
                count_of_children = 1,
                firstName = "ronit",
                lastName = "tzur",
                signle_mother = false,
                id = 222222,
                phone = " 0544171877"
            };
            Mother mother3 = new Mother
            {
                address = "נחל איילון 7 בית שמש",
                search_area = "נחל שמשון 9 בית שמש",
                count_of_children = 1,
                firstName = "orna",
                signle_mother = false,
                id = 333333,
                lastName = "zohar",
                phone = " 0504171895"
            };
            Mother mother4 = new BE.Mother
            {
                address = "נחל תמנה 5 בית שמש",
                comments = "good Nanny!!!",
                search_area = "נחל דולב 84 בית שמש",
                count_of_children = 2,
                firstName = "leha",
                signle_mother = true,
                id = 444444,
                lastName = "levy",
                phone = "0504171892"
            };
            for (int i = 0; i < 6; i++)
            {
                mother1.set_workdays(true, i);
                mother2.set_workdays(true, i);
                mother3.set_workdays(true, i);
                mother4.set_workdays(true, i);
                mother1.set_workhours(i, TimeSpan.Parse("08:00"), TimeSpan.Parse("14:00"));
                mother2.set_workhours(i, TimeSpan.Parse("08:00"), TimeSpan.Parse("14:00"));
                mother3.set_workhours(i, TimeSpan.Parse("08:00"), TimeSpan.Parse("14:00"));
                mother4.set_workhours(i, TimeSpan.Parse("08:00"), TimeSpan.Parse("14:00"));
            }//updating the hours that mothers need a nanny
            bl.addMother(mother1);
            bl.addMother(mother2);
            bl.addMother(mother3);
            bl.addMother(mother4);
            Child c1 = new Child
            {
                id_child = 111111,
                date_of_birth = DateTime.Parse("12/02/2015"),
                id_mother = 111111,
                name = "yosi",

            };
            Child c2 = new Child
            {
                id_child = 222222,
                date_of_birth = DateTime.Parse("12/02/2015"),
                id_mother = 111111,
                name = "yehuda",

            };
            Child c3 = new Child
            {
                id_child = 333333,
                date_of_birth = DateTime.Parse("12/02/2015"),
                id_mother = 222222,
                name = "yoram",
                special_needs = true,
                Has_Nanny = false
            };
            Child c4 = new Child
            {
                id_child = 444444,
                date_of_birth = DateTime.Parse("12/02/2015"),
                id_mother = 333333,
                name = "ishay",
                special_needs = true,
                Has_Nanny = false
            };
            Child c5 = new Child
            {
                id_child = 555555,
                date_of_birth = DateTime.Parse("12/02/2016"),
                id_mother = 444444,
                name = "ishay"
            };
            bl.addChild(c1);
            bl.addChild(c2);
            bl.addChild(c3);
            bl.addChild(c4);
            bl.addChild(c5);
            Nanny nanny1 = new Nanny
            {
                address = "נחל הבשור 4 בית שמש ",
                floor = 2,
                elevators = true,
                firstName = "chana",
                lastName = "levi",
                max_age = 4,
                id = 111111,
                years_of_experience = 5,
                phone = "0504444444",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2000,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1991"),
            };
            Nanny nanny2 = new Nanny
            {
                address = "גוש עציון",
                floor = 2,
                elevators = true,
                firstName = "Lea",
                lastName = "kaplan",
                max_age = 4,
                id = 222222,
                years_of_experience = 6,
                phone = "050443244",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2000,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1991"),
            };
            Nanny nanny3 = new Nanny
            {
                address = "שדרות בן זאב 8 בית שמש",
                floor = 2,
                elevators = true,
                firstName = "hen",
                lastName = "lev",
                max_age = 4,
                id = 333333,
                years_of_experience = 6,
                phone = "050443244",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2500,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1992"),
            };
            Nanny nanny4 = new Nanny
            {
                address = "שדרות בן זאב 8 בית שמש",
                floor = 2,
                elevators = true,
                firstName = "flora",
                lastName = "cohen",
                max_age = 4,
                id = 444444,
                years_of_experience = 6,
                phone = "050443244",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2500,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1992"),
            };
            Nanny nanny5 = new Nanny
            {
                address = "שדרות בן זאב 8 בית שמש",
                floor = 2,
                elevators = true,
                firstName = "rivka",
                lastName = "toledano",
                max_age = 4,
                id = 555555,
                years_of_experience = 6,
                phone = "050443244",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2500,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1992"),
            };
            for (int i = 0; i < 6; i++)
            {
                nanny2.set_workdays(true, i);
                nanny1.set_workdays(true, i);
                nanny3.set_workdays(true, i);
                nanny4.set_workdays(true, i);
                nanny5.set_workdays(true, i);
                nanny1.set_workhours(i, TimeSpan.Parse("08:23"), TimeSpan.Parse("14:00"));
                nanny2.set_workhours(i, TimeSpan.Parse("08:23"), TimeSpan.Parse("14:00"));
                nanny3.set_workhours(i, TimeSpan.Parse("08:23"), TimeSpan.Parse("14:00"));
                nanny4.set_workhours(i, TimeSpan.Parse("08:23"), TimeSpan.Parse("14:00"));
                nanny5.set_workhours(i, TimeSpan.Parse("08:23"), TimeSpan.Parse("14:00"));
            }//updating hours that nannies work
            bl.addNanny(nanny1);
            bl.addNanny(nanny2);
            bl.addNanny(nanny3);
            bl.addNanny(nanny4);
            bl.addNanny(nanny5);*/
        }

        /// <summary>
        /// event when mouse enter the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            listBox_nanny.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// event when mouse leave the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_nanny_MouseLeave(object sender, MouseEventArgs e)
        {
            listBox_nanny.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// event when mouse enter the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_nanny_MouseEnter(object sender, MouseEventArgs e)
        {
            listBox_nanny.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// event when mouse leave the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_nanny_MouseLeave(object sender, MouseEventArgs e)
        {
            listBox_nanny.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// event when the user choose one of the options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_nanny_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            switch (listBox_nanny.SelectedItem.ToString())
            {
                case "הוספת מטפלת":
                    new Nanny_Menu().ShowDialog();
                    break;
                case "הסרת מטפלת":
                    new ID("nanny").ShowDialog();
                    break;
                case "עדכון פרטים":
                    new ID("update_nanny").ShowDialog();
                    break;
                case "אישור חוזה":
                    new ID("check_con").ShowDialog();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// event when mouse enter the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_mother_MouseEnter(object sender, MouseEventArgs e)
        {
            listBox_mother.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// event when mouse leave the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_mother_MouseLeave(object sender, MouseEventArgs e)
        {
            listBox_mother.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// event when mouse enter the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_mother_MouseEnter(object sender, MouseEventArgs e)
        {

            listBox_mother.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// event when mouse leave the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_mother_MouseLeave(object sender, MouseEventArgs e)
        {
            listBox_mother.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// event when the user choose one of the options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_mother_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            switch (listBox_mother.SelectedItem.ToString())
            {
                case "הוספת אמא":
                    new Add_mother().ShowDialog();
                    break;
                case "הסרת אמא":
                    new ID("mother").ShowDialog();
                    break;
                case "עדכון פרטי אמא":
                    new ID("update_mother").ShowDialog();
                    break;
                case "הוספת ילד":
                    new Add_child().ShowDialog();
                    break;
                case "הסרת ילד":
                    new ID("child").ShowDialog();
                    break;
                case "עדכון פרטי ילד":
                    new ID("updateChild").ShowDialog();
                    break;
                case "חיפוש מטפלת":
                    new ID("search_nannies").ShowDialog();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// event when mouse enter the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_optiones_MouseEnter(object sender, MouseEventArgs e)
        {
            listBox_options.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// event when mouse leave the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_optiones_MouseLeave(object sender, MouseEventArgs e)
        {
            listBox_options.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// event when mouse enter the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_options_MouseEnter(object sender, MouseEventArgs e)
        {
            listBox_options.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// event when mouse leave the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_options_MouseLeave(object sender, MouseEventArgs e)
        {
            listBox_options.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// event when the user choose one of the options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_options_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            switch (listBox_options.SelectedItem.ToString())
            {
                case "הצג את כל האימהות":
                    new Results(2).Show();
                    break;
                case "הצג את כל המטפלות":
                    new Results(1).Show();
                    break;
                case "הצג את כל הילדים":
                    new Results(3).Show();
                    break;
                case "הצג את כל החוזים":
                    new Results(4).Show();
                    break;
                default:
                    break;
            }
        }
    }
}
