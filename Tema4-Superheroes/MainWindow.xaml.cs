using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Tema4_Superheroes.modelos;

namespace Tema4_Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Superheroe> superheroes;

        public MainWindow()
        {
            InitializeComponent();
            superheroes = Superheroe.GetSamples();
            contenedorDockPanel.DataContext = superheroes;
        }

        private void AnteriorImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int contador = int.Parse(anteriorImage.Tag.ToString());
            if (contador >= 1 && contador <= 3)
            {
                if (contador == 1)
                {
                    numeroTextBlock.Text = "1/3";
                    anteriorImage.Tag = 1;
                    siguienteImage.Tag = 1;
                }
                else
                {
                    contador--;
                    numeroTextBlock.Text = $"{contador}/3";
                    anteriorImage.Tag = contador;
                    siguienteImage.Tag = contador;
                    contenedorDockPanel.DataContext = superheroes[contador - 1];
                }
            }
        }

        private void SiguienteImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int contador = int.Parse(siguienteImage.Tag.ToString());
            if (contador >= 1 && contador <= 3)
            {
                if (contador == 3)
                {
                    numeroTextBlock.Text = "3/3";
                    siguienteImage.Tag = 3;
                    anteriorImage.Tag = 3;
                }
                else
                {
                    contador++;
                    numeroTextBlock.Text = $"{contador}/3";
                    siguienteImage.Tag = contador;
                    anteriorImage.Tag = contador;
                    contenedorDockPanel.DataContext = superheroes[contador - 1];
                }
            }
        }
    }
}