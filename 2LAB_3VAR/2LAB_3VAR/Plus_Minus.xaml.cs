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


namespace _2LAB_3VAR
{
    /// <summary>
    /// Логика взаимодействия для Plus_Minus.xaml
    /// </summary>
    public partial class Plus_Minus : UserControl, INotifyPropertyChanged
    {
        public static DependencyProperty ValueFreePoints = DependencyProperty.Register("Freepoints", typeof(int), typeof(Plus_Minus));
        public static DependencyProperty ValueProperty =
           DependencyProperty.Register("Value", typeof(byte), typeof(Plus_Minus));
        public byte Value
        {
            get
            {
                return (byte)GetValue(ValueProperty);
            }

            set
            {
                SetValue(ValueProperty, value);
                DoPropertyChanged("Value");
            }
        }

        public static DependencyProperty PointsProperty =
            DependencyProperty.Register("Points", typeof(byte), typeof(Plus_Minus));

        public byte Points
        {
            get
            {
                return (byte)GetValue(PointsProperty);
            }

            set
            {
                SetValue(PointsProperty, value);
                DoPropertyChanged("Points");
            }
        }

        private void MinusClick(object sender, RoutedEventArgs e)
        {
            if (Value > 5)
            {
                Value--;
                Points++;
            }
        }

        public Plus_Minus()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void PlusClick(object sender, RoutedEventArgs e)
        {
            if (Points > 0)
            {
                Value++;
                Points--;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
