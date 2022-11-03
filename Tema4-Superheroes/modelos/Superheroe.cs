using System.Collections.Generic;
using System.ComponentModel;

namespace Tema4_Superheroes.modelos
{
    public class Superheroe : INotifyPropertyChanged
    {
        private string nombre;
        private string imagen;
        private bool vengador;
        private bool xmen;
        private bool heroe;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    NotifyPropertyChanged("Nombre");
                }
            }
        }

        public string Imagen
        {
            get => imagen;
            set
            {
                if (imagen != value)
                {
                    imagen = value;
                    NotifyPropertyChanged("Imagen");
                }
            }
        }

        public bool Vengador
        {
            get => vengador;
            set
            {
                if (vengador != value)
                {
                    vengador = value;
                    NotifyPropertyChanged("Vengador");
                }
            }
        }

        public bool Xmen
        {
            get => xmen;
            set
            {
                if (xmen != value)
                {
                    xmen = value;
                    NotifyPropertyChanged("Xmen");
                }
            }
        }

        public bool Heroe
        {
            get => heroe;
            set
            {
                if (heroe != value)
                {
                    heroe = value;
                    NotifyPropertyChanged("Heroe");
                }
            }
        }

        public Superheroe(){}

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
    }
}