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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZooZoo.Domain;
using ZooZoo.Domain.Models;
using ZooZoo.EntityFramework;

namespace ZooZoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using (var db = new ZooZooDbContext())
            {

                /*
                //Get Single course which need to update  
                Animal desAnimal = db.Animals.Single(a => a.Id == 1);
                //Zoo desZoo = db.Zoos.Find(1);
                //Field which will be update  
                desAnimal.Zoos.Add(new Zoo {Id = 1});
                // executes the appropriate commands to implement the changes to the database
                */
                IQueryable<Animal> animals = db.Animals;
                var filteredAnimals = animals.Where(a => a.Id == 1);

                IQueryable<Zoo> zoos = db.Zoos;
                var filteredZoos = zoos.ToList().Where(z => z.Id == 1);
                Zoo desiredZoo = filteredZoos.First();

                foreach (var animal in filteredAnimals)
                {
                    animal.Zoos.Add(desiredZoo);

                    MessageBox.Show("Complete!");
                    MessageBox.Show($"Id: {animal.Id} Name: {animal.Name} Zoos: {animal.Zoos}");
                }

                db.SaveChangesAsync();

            }
            InitializeComponent();
        }
    }
}
