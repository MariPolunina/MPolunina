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
        public int Freepoints
        {
            get
            {
                return (int)GetValue(ValueFreePoints);
            }
            set
            {
                SetValue(ValueFreePoints, value);
                DoProperty("Freepoints");
            }
        }
        public int Point
        {
            get
            {
                return (int)GetValue(Value);
            }
            set
            {
                SetValue(Value, value);
                DoProperty("Point");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public static DependencyProperty Value = DependencyProperty.Register("Point", typeof(int), typeof(Plus_Minus));
        private void Plus(object o, RoutedEventArgs e)
        {
          if (Freepoints >0)
            {
                Point++;
               Freepoints--;
           }
        }
        private void Minus(object o, RoutedEventArgs e)
        {
            if ((Freepoints < 10)&&(Point>5))
            {
                Point--;
                Freepoints++;
            }
        }
        public void DoProperty(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public Plus_Minus()
        {
            InitializeComponent();
            DataContext = this;    
        }
      
    }
}
