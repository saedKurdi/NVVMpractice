using NVVM.Commands;
using NVVM.Models;
using NVVM.Services;
using NVVM.Views.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace NVVM.ViewModels.WindowViewModels;

public class EditCarViewModel : NotificationChangedService
{

    string ? make;
    string ? model;
    DateTime ?date;


    Car? gelen_car;
    Car? edit_car;


    public string ? Make { get => make; set { make = value;OnPropertyChanged(); } }
    public string? Model { get => model; set { model = value; OnPropertyChanged(); } }
    public DateTime? Date { get => date; set { date = value; OnPropertyChanged(); } }


    public Car? GelenCar { get => gelen_car;set { gelen_car = value;OnPropertyChanged(); } }
    public Car ? EditCar { get => edit_car; set { edit_car = value;OnPropertyChanged(); } } 



    public ICommand? SaveCommand { get; set; }
    public ICommand ? CancelCommand {  get; set; }

  

    public EditCarViewModel(Car ? car)
    {
        GelenCar = car;

        EditCar = new Car(GelenCar?.Make, GelenCar?.Model, GelenCar?.Date);

        SaveCommand = new RelayCommand(Save, CanSave);
        CancelCommand = new RelayCommand(Cancel, CanCancel);
    }


    public void Save(object ? param)
    {
        GelenCar!.Make = EditCar!.Make;
        GelenCar.Model = EditCar.Model;
        GelenCar.Date = EditCar.Date;
       
        MessageBox.Show("SAVED !");
        var view = param as EditCarView;
        if (view != null) view.Close() ;
    }

    public bool CanSave(object? param) => EditCar!.Make != null && EditCar.Model != null && EditCar.Date!= null;



    public void Cancel(object? param)
    {
        var view = param as EditCarView;
        if (view != null) view.Close();
    }

    public bool CanCancel(object? param) => true;

}
