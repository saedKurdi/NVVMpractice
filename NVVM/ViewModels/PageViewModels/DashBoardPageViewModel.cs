using NVVM.Commands;
using NVVM.Models;
using NVVM.Services;
using NVVM.ViewModels.WindowViewModels;
using NVVM.Views.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace NVVM.ViewModels.PageViewModels;
public class DashBoardPageViewModel : NotificationChangedService
{

    private ObservableCollection<Car>? cars;
    public ObservableCollection<Car> ? Cars { get => cars; set { cars = value;OnPropertyChanged(); } }


    private Car? car;
    public Car? Car { get => car; set { car = value;OnPropertyChanged(); } }


    public ICommand ? AddCommand { get; set; }
    public ICommand ? RemoveCommand { get; set; }
    public ICommand ? EditCommand { get; set; }
    public ICommand? GetAllCarCommand { get; set; }

    public DashBoardPageViewModel()
    {
         Car = new Car();

        Cars = new ObservableCollection<Car>()
        {
            new Car("KIA","OPTIMA",new DateTime(2012,2,2)),
            new Car("LAMBORGINI","SS",new DateTime(2010,3,11)),
            new Car("Mercedes","cls63",new DateTime(2022,11,2)),
            new Car("Mercedes","S500",new DateTime(2015,4,1)),
            new Car("BMW","M5",new DateTime(2019,1,11)),
        };

        AddCommand = new RelayCommand(AddCar,CanAddCar);
        RemoveCommand = new RelayCommand(RemoveCar, CanRemoveCar);
        EditCommand = new RelayCommand(EditCar, CanEditCar);
        GetAllCarCommand = new RelayCommand(GetAllCar, CanGetAllCar);
    }


    public void AddCar(object ? param)
    {
        Cars?.Add(Car!);
        Car = new Car();
    }

    public bool CanAddCar(object ? param)
    {
        if(Car!.Date != null && Car.Date != null && Car.Make != null && Car.Model != null) return true;
        return false;
    }



    public void RemoveCar(object? param)
    {
        int index = Convert.ToInt32(param);
        Cars?.RemoveAt(index);
    }

    public bool CanRemoveCar(object ? param)
    {
        int index = Convert.ToInt32(param);
        if (index != -1) return true;
        return false;
    }


    public void GetAllCar(object ? param)
    {
        var window = new GetAllCarView();
        window.DataContext = new GetAllCarViewModel(Cars);
        window.ShowDialog();
    }

    public bool CanGetAllCar(object ? param) => Cars!.Count > 0;



    public void EditCar(object? param)
    {
        int index = Convert.ToInt32(param);
        var editCarWindow = new EditCarView();
        editCarWindow.DataContext = new EditCarViewModel(Cars![index]);
        editCarWindow.ShowDialog();
    }

    public bool CanEditCar(object ? param)
    {
        int index = Convert.ToInt32(param);
        if(index != -1) return true;
        return false;
    }
}


