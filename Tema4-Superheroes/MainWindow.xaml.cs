using System.Windows;
using System.Windows.Input;
using Tema4_Superheroes.vista_modelo;

namespace Tema4_Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM vm = new MainWindowVM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void AnteriorImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            vm.Retroceder();
        }

        private void SiguienteImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            vm.Avanzar();
        }
    }
}