using System.Configuration;
using System.Data;
using System.Windows;

namespace BasicMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
           base.OnStartup(e);
            Views.UserView view = new Views.UserView();
            ViewModels.UserViewModel viewModel = new ViewModels.UserViewModel();
            view.DataContext = viewModel;
            view.Show();
        }
    }

}
