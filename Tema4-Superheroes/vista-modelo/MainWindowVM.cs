using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema4_Superheroes.modelos;

namespace Tema4_Superheroes.vista_modelo
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private Superheroe heroeActual;

        public Superheroe HeroeActual
        {
            get => heroeActual;
            set
            {
                heroeActual = value;
                NotifyPropertyChanged("HeroeActual");
            }
        }

        private int numeroActual;

        public int NumeroActual
        {
            get => numeroActual;
            set
            {
                numeroActual = value;
                NotifyPropertyChanged("NumeroActual");
            }
        }

        private int totalHeroes;

        public int TotalHeroes
        {
            get => totalHeroes;
            set
            {
                totalHeroes = value;
                NotifyPropertyChanged("TotalHeroes");
            }
        }

        private readonly List<Superheroe> listaSuperheroes = Superheroe.GetSamples();

        public MainWindowVM()
        {
            HeroeActual = listaSuperheroes[0];
            NumeroActual = 1;
            TotalHeroes = listaSuperheroes.Count;
        }

        public void Avanzar()
        {
            if (NumeroActual < TotalHeroes)
            {
                NumeroActual++;
                HeroeActual = listaSuperheroes[NumeroActual - 1];
            }
        }

        public void Retroceder()
        {
            if (NumeroActual > 1)
            {
                NumeroActual--;
                HeroeActual = listaSuperheroes[NumeroActual - 1];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}