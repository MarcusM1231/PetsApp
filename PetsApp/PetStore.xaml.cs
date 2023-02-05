using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PetsApp
{
    /// <summary>
    /// Pet Store window for the app where users can select their pet and 
    /// choose a name for them.
    /// </summary>
    public partial class PetStore : Window
    {
        private Pet pet;
        public PetStore()
        {
            InitializeComponent();
            CountLabel.Content = $"You Purchased {MyListOfPets.Pets.Count} Pet(s)";
        }

        //Button event to handle selecting fish pet
        private void GetDog_Click(object sender, RoutedEventArgs e)
        {
            if (PetName.Text == "")
            {
                MessageBox.Show("Please give the dog a name!");
            }
            else
            {
                pet = new Dog(PetName.Text);
                AddPetToList(pet);
            }
        }

        //Button event to handle selecting cat pet
        private void GetCat_Click(object sender, RoutedEventArgs e)
        {
            if (PetName.Text == "")
            {
                MessageBox.Show("Please give the cat a name!");
            }
            else
            {
                pet = new Cat(PetName.Text);
                AddPetToList(pet);
            }
        }

        //Button event to handle selecting plant pet
        private void GetPlant_Click(object sender, RoutedEventArgs e)
        {
            if (PetName.Text == "")
            {
                MessageBox.Show("Please give the plant a name!");
            }
            else
            {
                pet = new Plant(PetName.Text);
                AddPetToList(pet);
            }
        }

        //Button event to handle selecting fish pet
        private void GetFish_Click(object sender, RoutedEventArgs e)
        {
            if (PetName.Text == "")
            {
                MessageBox.Show("Please give the fish a name!");
            }
            else
            {
                pet = new Fish(PetName.Text);
                AddPetToList(pet);
            }

        }

        //Button event to send you back to the home
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        //Adds pet to your list of pet and starts the timer 
        public void AddPetToList(Pet pet)
        {
            MyListOfPets.Pets.Add(pet);
            pet.timer.Start();
            PetName.Text = "";

            Task.Run(() =>
            {
                App.Current.Dispatcher.Invoke(() =>
                {
                    CountLabel.Content = $"You Purchased {MyListOfPets.Pets.Count} Pet(s)";
                });
            });

        }
    }
}
