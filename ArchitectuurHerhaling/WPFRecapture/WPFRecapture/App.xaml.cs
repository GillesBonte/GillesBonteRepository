using System.Configuration;
using System.Data;
using System.Windows;

namespace WPFRecapture
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            View.GameView view = new View.GameView();
            ViewModel.GameViewModel viewModel = new ViewModel.GameViewModel();

            view.DataContext = viewModel;
            view.Show();
        }
    }

}
