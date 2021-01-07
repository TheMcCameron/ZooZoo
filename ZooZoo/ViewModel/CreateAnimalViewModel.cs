using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using ZooZoo.Views;

namespace ZooZoo.ViewModel
{
    public class CreateAnimalViewModel : ViewModelBase
    {
        public CreateAnimalViewModel()
        {
            CreateAnimalNameButtonPressCmd = new RelayCommand(() => CreateAnimalNameButtonPress());
        }

        private void CreateAnimalNameButtonPress()
        {
            MessageBox.Show("Test");
        }
        public RelayCommand CreateAnimalNameButtonPressCmd { get; private set; }
    }
}
