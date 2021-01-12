using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ZooZoo.Domain;
using ZooZoo.EntityFramework;
using ZooZoo.ViewModel;
using static ZooZoo.Domain.Models.DietClassification;

namespace ZooZoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ZoosListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
























        public void UpdateZooAnimalList(string zooName, string animalName)
        {
            try
            {
                using (var dbContext = new ZooZooDbContext())
                {
                    var zoo = dbContext.Zoos.Single(z => z.Name.Equals(zooName));
                    var animal = dbContext.Animals.Single(a => a.Name.Equals(animalName));
                    bool alreadyListed = false;
                    if (zoo.Animals.Contains(animal))
                    {
                        alreadyListed = true;
                        MessageBox.Show($"{animal.Name} is already listed at the {zoo.Name} zoo.");
                    }
                    else if (alreadyListed == false)
                    {
                        zoo.Animals.Add(animal);
                        dbContext.SaveChangesAsync();
                        MessageBox.Show($"{animal.Name} has been listed at the {zoo.Name} zoo.");
                    }
                }
            }
            catch
            {
                MessageBox.Show($"{zooName} zoo or {animalName} does not exist within the database.");
            }
        }

        public void UpdateAnimalClassification(string animalName, DietClassificationEnum newDietClassification)
        {
            using (var dbContext = new ZooZooDbContext())
            {
                bool animalExists = false;
                var animals = dbContext.Animals.ToList();

                foreach (var animal in animals)
                {
                    if (animal.Name.Equals(animalName) && animal.DietClassification != newDietClassification)
                    {
                        animalExists = true;
                        animal.DietClassification = newDietClassification;
                        dbContext.SaveChangesAsync();
                        MessageBox.Show($"{animal.Name}'s diet classification has been changed to {newDietClassification.ToString()}.");
                    }
                    else if (animal.Name.Equals(animalName) && animal.DietClassification == newDietClassification)
                    {
                        animalExists = true;
                        MessageBox.Show($"{animal.Name}'s diet classification is already set to {newDietClassification.ToString()}.");
                    }
                }

                if (!animalExists)
                {
                    MessageBox.Show($"{animalName} does not exist.");
                }
            }
        }

        public void UpdateAnimalDescription(string animalName, string newDescription)
        {
            using (var dbContext = new ZooZooDbContext())
            {
                bool animalExists = false;
                var animals = dbContext.Animals.ToList();

                foreach (var animal in animals)
                {
                    if (animal.Name.Equals(animalName))
                    {
                        animalExists = true;
                        animal.Description = newDescription;
                        dbContext.SaveChangesAsync();
                        MessageBox.Show($"{animalName}'s description has been updated.");
                    }
                }

                if (!animalExists)
                {
                    MessageBox.Show($"{animalName} does not exist.");
                }
            }
        }

        public void UpdateZooName(string oldZooName, string newZooName)
        {
            using (var dbContext = new ZooZooDbContext())
            {
                bool zooExists = false;
                var zoos = dbContext.Zoos.ToList();

                foreach (var zoo in zoos)
                {
                    if (zoo.Name.Equals(oldZooName))
                    {
                        zooExists = true;
                        zoo.Name = newZooName;
                        dbContext.SaveChangesAsync();
                        MessageBox.Show($"{oldZooName}'s name has been changed to {newZooName}.");
                    }
                }

                if (!zooExists)
                {
                    MessageBox.Show($"{oldZooName} does not exist.");
                }
            }
        }

        public void UpdateAnimalName(string oldAnimalName, string newAnimalName)
        {
            using (var dbContext = new ZooZooDbContext())
            {
                bool animalExists = false;
                var animals = dbContext.Animals.ToList();

                foreach (var animal in animals)
                {
                    if (animal.Name.Equals(oldAnimalName))
                    {
                        animalExists = true;
                        animal.Name = newAnimalName;
                        dbContext.SaveChangesAsync();
                        MessageBox.Show($"{oldAnimalName}'s name has been changed to {newAnimalName}.");
                    }
                }

                if (!animalExists)
                {
                    MessageBox.Show($"{oldAnimalName} does not exist.");
                }
            }
        }

        public void DeleteZoo(string zooName)
        {
            using (var dbContext = new ZooZooDbContext())
            {
                bool zooExists = false;
                var zoos = dbContext.Zoos.ToList();

                foreach (var zoo in zoos)
                {
                    if (zoo.Name.Equals(zooName))
                    {
                        zooExists = true;
                        dbContext.Zoos.Remove(zoo);
                        dbContext.SaveChangesAsync();
                        MessageBox.Show(zoo.Name + " has been deleted.");
                    }
                }

                if (!zooExists)
                {
                    MessageBox.Show(zooName + " does not exist.");
                }
            }
        }

        public void DeleteAnimal(string animalName)
        {
            using (var dbContext = new ZooZooDbContext())
            {
                bool animalExists = false;
                var animals = dbContext.Animals.ToList();

                foreach (var animal in animals)
                {
                    if (animal.Name.Equals(animalName))
                    {
                        animalExists = true;
                        dbContext.Animals.Remove(animal);
                        dbContext.SaveChangesAsync();
                        MessageBox.Show(animal.Name + " has been deleted.");
                    }
                }

                if (!animalExists)
                {
                    MessageBox.Show(animalName + " does not exist.");
                }
            }
        }

        public void CreateZoo(string zooName)
        {
            using (var dbContext = new ZooZooDbContext())
            {
                Zoo newZoo = new Zoo { Name = zooName };
                dbContext.Zoos.Add(newZoo);
                dbContext.SaveChangesAsync();
                MessageBox.Show($"{zooName} has been created.");
            }
        }

        public void CreateAnimal(string animalName, string animalDescription, DietClassificationEnum dietClassification)
        {
            using (var dbContext = new ZooZooDbContext())
            {

                Animal newAnimal = new Animal
                { Name = animalName, Description = animalDescription, DietClassification = dietClassification };
                dbContext.Animals.Add(newAnimal);
                dbContext.SaveChangesAsync();
                MessageBox.Show($"{animalName} has been created.");
            }
        }
    }
}
