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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for listoptions.xaml
    /// </summary>
    public partial class listoptions : Window
    {
        BL.IBL bl;
        public listoptions(string str)
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            switch (str)
            {
                case "הצג את כל המטפלות":
                    myuriel.ItemsSource = bl.NannyList();
                    break;
                case "הצג את כל האמהות":
                    myuriel.ItemsSource = bl.MotherList();
                    break;
                case "הצג את כל החוזים":
                    myuriel.ItemsSource = bl.ContractList();
                    break;
                case "הצג את כל הילדים":
                    myuriel.ItemsSource = bl.ChildList();
                    break;
                default:
                    break;
            }
        }
    }
}
