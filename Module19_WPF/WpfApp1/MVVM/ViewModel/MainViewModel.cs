﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Core;

namespace WpfApp1.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand FamillyViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public FamillyViewModel FamillyVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            FamillyVM = new FamillyViewModel();
            CurrentView = HomeVM;


            HomeViewCommand = new RelayCommand(o => 
                {
                    CurrentView = HomeVM;
                });
            
            FamillyViewCommand = new RelayCommand(o => 
                {
                    CurrentView = FamillyVM;
                });
        }
    }
}
