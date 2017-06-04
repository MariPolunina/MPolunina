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
        public static string nickname { get; set; }
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
        private static String _SelectedHeroClass;
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
        private static int force;
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
        private static int adroitness;
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
        private static int intellingence;
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
        private static int luck;
        private int freePoint;
        public int FreePoints
        {
            get
            {
                return freePoint;
            }
            set
            {
                freePoint = value;
                DoProperty("freePoint");
                DoProperty("FreePoints");
            }
        }
        public ICommand Creationhero { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void DoProperty(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public static void InsertDataBase()
        {
            TableHero Hero1 = new TableHero(nickname, _SelectedHeroClass, force, intellingence, adroitness, luck);
            heroDataBaseEntities Context = new heroDataBaseEntities();
            Context.TableHero.Add(Hero1);
            Context.SaveChangesAsync();
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
            FreePoints = 10;
            Creationhero = new CreationHero();     
        }
    }
}
