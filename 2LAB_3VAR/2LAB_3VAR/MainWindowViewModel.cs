using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace _2LAB_3VAR
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        public string nickname { get; set; }
        public List<string> HeroClass { get; set; }
        public String SelectedHeroClass
        {
            get
            {
                return _SelectedHeroClass;
            }
            set
            {
                _SelectedHeroClass = value;
                DoProperty("SelectedHeroClass");
            }
                
        }
        private String _SelectedHeroClass;
        public int _force
        {
            get
            {
                return force;
            }
            set
            {
                force = value;
                DoProperty("force");
                DoProperty("_force");
            }
        }
        private int force;
        public int _adroitness
        {
            get
            {
                return adroitness;
            }
            set
            {
                adroitness = value;
                DoProperty("adroitness");
                DoProperty("_adroitness");
            }
        }
        private int adroitness;
        public int _intellingence
        {
            get
            {
                return intellingence;
            }
            set
            {
                intellingence = value;
                DoProperty("intellingence");
                DoProperty("_intellingence");
            }
                }
        private int intellingence;
        public int _luck
        {
            get
            {
                return luck;
            }
            set
            {
                luck = value;
                DoProperty("luck");
                DoProperty("_luck");
            }
        }
        private int luck;
        private int freePoint;
        public int _freePoint
        {
            get
            {
                return freePoint;
            }
            set
            {
                freePoint = value;
                DoProperty("freePoint");
                DoProperty("_freePoint");
            }
        }
        public ICommand Creationhero { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void DoProperty(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public MainWindowViewModel()
        {
            HeroClass = new List<string>
            {
                "Воин",
                "Маг",
                "Разбойник",
                "Жрец",
                "Палладин",
                "Лучник"
            };
            _force =_intellingence=_adroitness=_luck= 5;
           _freePoint = 10;
            Creationhero = new CreationHero();     
        }
    }
}
