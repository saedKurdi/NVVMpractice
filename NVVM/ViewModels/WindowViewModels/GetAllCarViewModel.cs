using NVVM.Models;
using NVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVVM.ViewModels.WindowViewModels;

public class GetAllCarViewModel : NotificationChangedService
{
    public ObservableCollection<Car>? cars;
    public ObservableCollection<Car>? Cars
    {
        get => cars;
        set { cars=value;OnPropertyChanged(); }
    }

    public GetAllCarViewModel()
    {
        Cars = new ObservableCollection<Car>();
    }

    public GetAllCarViewModel(ObservableCollection<Car> ? cars)
    {
        Cars = cars;
    }
}
