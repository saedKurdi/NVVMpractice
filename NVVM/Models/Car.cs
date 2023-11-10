using NVVM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVVM.Models;
public class Car : NotificationChangedService
{
    private string? make;
    private string? model;
    private DateTime? date;


    public string? Make { get => make; set { make = value;OnPropertyChanged(); }  }
    public string? Model { get => model; set { model = value;OnPropertyChanged(); } }
    public DateTime? Date { get => date; set { date = value;OnPropertyChanged(); } }


    public Car(string ? make , string ? model ,DateTime? date ){Make = make; Model = model; Date = date;}
    public Car()
    {
        Make = "";
        Model = "";
        Date = null;
    }

    public override string ToString()
    => $"{Make} - {Model}  -  {Date}";
   
}
