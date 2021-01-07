using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using ZooZoo.Views;

namespace ZooZoo.ViewModel
{
    public class CreateZooViewModel : ViewModelBase
    {
        public CreateZooViewModel()
        {
            CreateZooNameButtonPressCmd = new RelayCommand(() => CreateZooNameButtonPress());
        }

        private void CreateZooNameButtonPress()
        {
            MessageBox.Show("Test");
        }
        public RelayCommand CreateZooNameButtonPressCmd { get; private set; }
    }
}
