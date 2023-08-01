using ControlesTipoVista.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ControlesTipoVista.ViewModel
{
    public class ListViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Propiedad para ejemplo de Picker

        private Robot selectedRobot;

        public Robot SelectedRobot
        {
            get
            {
                return selectedRobot;
            }
            set
            {
                if(selectedRobot != value)
                {
                    selectedRobot = value;
                    OnPropertyChanged(nameof(SelectedRobot));
                    OnPropertyChanged("SelectedRobotIndex");
                }
            }
        }

        ObservableCollection<object> selectedRobots;

        public ObservableCollection<object> SelectedRobots
        {
            get
            {
                return selectedRobots;
            }
            set
            {
                if(selectedRobots!= value)
                {
                    selectedRobots = value;
                }
            }
        }

        //public int SelectedRobotIndex
        //{
        //    get
        //    {
        //        return Robots.IndexOf(SelectedRobot);
        //    }
        //}

        private List<Robot> _robots;

        public List<Robot> Robots
        {
            get
            {
                return _robots;
            }
            set
            {
                _robots = value;
                OnPropertyChanged(nameof(Robots));

            }
        }
        //Propiedades para manejar el nombre actual y previo de los elementos

        private Robot previousRobot;
        public Robot PreviousRobot
        {
            get { return previousRobot; }
            set
            {
                previousRobot = value;
                OnPropertyChanged(nameof(PreviousRobot));
            }
        }

        private Robot currentRobot;
        public Robot CurrentRobot
        {
            get { return currentRobot; }
            set
            {
                currentRobot = value;
                OnPropertyChanged(nameof(CurrentRobot));
            }
        }

        public ICommand ItemChangedCommand => new Command<Robot>((item) =>
        {
            PreviousRobot = CurrentRobot;
            CurrentRobot = item;
        });

        //Propiedades para manejar la posición

        private int previousPosition;
        public int PreviousPosition
        {
            get { return previousPosition; }
            set
            {
                previousPosition = value;
                OnPropertyChanged(nameof(PreviousPosition));
            }
        }

        private int currentPosition;
        public int CurrentPosition
        {
            get { return currentPosition; }
            set
            {
                currentPosition = value;
                OnPropertyChanged(nameof(CurrentPosition));
            }
        }

        public ICommand PositionChangedCommand => new Command<int>((position) =>
        {
            PreviousPosition = CurrentPosition;
            CurrentPosition = position;
        });

       
        //public List<RobotGroup> Robots { get; private set; } = new List<RobotGroup>();

        //public int TotalGroups
        //{
        //    get
        //    {
        //        return Robots.Count;
        //    }
        //}
        public ListViewModel()
        {
            Robots = new List<Robot>
            {
                 new Robot {Nombre = "Robot 1", Imagen = "dotnet_bot.png", Peso = 25.5, Details="Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "LogoMaui", Imagen = "dotnet_bot.png", Peso = 10.5, Details="Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "Robot 3", Imagen = "dotnet_bot.png", Peso = 20.5, Details="Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "LogoMaui", Imagen = "dotnet_bot.png", Peso = 25.5, Details="Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "Robot 5", Imagen = "dotnet_bot.png", Peso = 10.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "Robot 6", Imagen = "dotnet_bot.png", Peso = 20.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "LogoMaui", Imagen = "dotnet_bot.png", Peso = 25.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "Robot 8", Imagen = "dotnet_bot.png", Peso = 10.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "LogoMaui", Imagen = "dotnet_bot.png", Peso = 20.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},

            };

            //selectedRobot = Robots.Skip(2).FirstOrDefault();
            //SelectedRobots = new ObservableCollection<object>()
            //{
            //    Robots[1], Robots[2], Robots[3]            
            //};

            //Robots.Add(new RobotGroup("Robots", new List<Robot>
            //{
            //    new Robot
            //    {
            //        Nombre = "Robot Primario",
            //        Imagen = "dotnet_bot.png",
            //        Peso = 23.2,
            //        Details = "Este es el robot primario mas importante"
            //    },
            //    new Robot
            //{
            //    Nombre = "Robot Secundario",
            //    Imagen = "dotnet_bot.png",
            //    Peso = 53.2,
            //    Details = "Este es el robot Secundario mas importante"
            //}
            //}));

            //Robots.Add(new RobotGroup("Logos", new List<Robot>
            //{
            //    new Robot
            //{
            //    Nombre = "Logo Ejecutivo",
            //    Imagen = "dotnet_bot.png",
            //    Peso = 23.2,
            //    Details = "Este es el Logo ejecutivo mas importante"
            //},
            // new Robot
            //{
            //    Nombre = "Logo Enterprise",
            //    Imagen = "dotnet_bot.png",
            //    Peso = 53.2,
            //    Details = "Este es el robot Enterprise mas importante"
            //}
            //}));

            //Robots.Add(new RobotGroup("Grupo Robots abandonados", new List<Robot>
            //{

            //}));
        }
    }
}
