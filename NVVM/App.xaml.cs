using NVVM.ViewModels.WindowViewModels;
using NVVM.Views.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NVVM;
public partial class App : Application
{
    private void Main(object sender, StartupEventArgs e)
    {
        var mainView = new MainView();
        mainView.DataContext = new MainViewModel();
        mainView.ShowDialog();
    }
}
