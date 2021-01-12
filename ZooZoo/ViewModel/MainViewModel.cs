using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using ZooZoo.Domain;
using ZooZoo.Views;
using System.Linq;
using ZooZoo.EntityFramework;
using System.Collections.ObjectModel;
using System.Windows;

namespace ZooZoo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>

        //TODO:
        //These Lists may need to be changed to ObservableCollections.
        public List<Zoo> AllZoos 
        {
            get 
            {
                using (var dbContext = new ZooZooDbContext())
                {
                    return dbContext.Set<Zoo>().ToList();
                }
            }
        }
        public List<Animal> AllAnimals
        {
            get
            {
                using (var dbContext = new ZooZooDbContext())
                {
                    return dbContext.Set<Animal>().ToList();
                }
            }
        }

        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            CreateZooButtonPressCmd = new RelayCommand(() => CreateZooButtonPress());
            CreateAnimalButtonPressCmd = new RelayCommand(() => CreateAnimalButtonPress());
        }

        private void CreateZooButtonPress()
        {
            CreateZooWindow createZooWindow = new CreateZooWindow();
            createZooWindow.Show();
        }
        private void CreateAnimalButtonPress()
        {
            CreateAnimalWindow createAnimalWindow = new CreateAnimalWindow();
            createAnimalWindow.Show();
        }
        public RelayCommand CreateAnimalButtonPressCmd { get; private set; }
        public RelayCommand CreateZooButtonPressCmd { get; private set; }
    }
}