﻿using NVVM.ViewModels.PageViewModels;
using NVVM.ViewModels.WindowViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NVVM.Views.Windows;
public partial class GetAllCarView : Window
{
    public GetAllCarView()
    {
        InitializeComponent();
       DataContext = new GetAllCarViewModel();
    }
}