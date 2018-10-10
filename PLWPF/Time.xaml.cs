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
using System.ComponentModel;
using BE;

namespace PLWPF
{

    /// <summary>
    /// Interaction logic for Time.xaml
    /// </summary>
    public partial class Time : UserControl, INotifyPropertyChanged
    {
        private bool[] works = new bool[6];
        private TimeSpan[,] time = new TimeSpan[6, 2];

        public bool[] Works
        {
            get => works;
            set
            {
                works = value;
                if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs("Works")); }
            }
        }

        public TimeSpan[,] Time1
        {
            get => time;
            set
            {
                time = value;
                if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs("Time1")); }
            }
        }

        public bool Works0 { get => works0; set { works0 = value; PropertyChanged(this, new PropertyChangedEventArgs("Works0")); } }

        private bool works0;

        public event PropertyChangedEventHandler PropertyChanged;
        public Time()
        {
            InitializeComponent();
            checkBox1.DataContext = Works0;
            checkBox2.DataContext = works[1];
            checkBox3.DataContext = works[2];
            checkBox4.DataContext = works[3];
            checkBox5.DataContext = works[4];
            checkBox6.DataContext = works[5];
        }
    }
}
