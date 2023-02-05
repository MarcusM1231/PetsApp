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
using System.Windows.Threading;

namespace PetsApp
{
    /// <summary>
    /// Interaction logic for PetDetails.xaml
    /// </summary>
    public partial class PetDetails : Window
    {
        private Pet thisPet;
        private string selectedFood = "";
        private string selectedInteraction;

        private List<string> foodOptions = new List<string> { "Bacon Snack", "Dry Dog Food", "Tuna", "Dry Cat Food", "Water", "Plant food", "Fish Food" };
        private List<string> interactOptions = new List<string> { "Pet", "Rub Belly", "Play", "Ignore", "Scold", "Play Music", "Tap on Glass" };

        public PetDetails(Pet pet)
        {
            InitializeComponent();

            thisPet = pet;

            PetName.Content = thisPet.name;
            PetHappiness.Content = thisPet.happiness;
            PetHunger.Content = thisPet.hunger;
            PetImage.Content = thisPet.petImage;

            pet.timer.Tick += Timer_Tick;

            IntializeDropdown();

        }

        //Populates the dropdown with values from the 
        //lists above
        public void IntializeDropdown()
        {
            foreach (string food in foodOptions)
            {
                FoodSelect.Items.Add(food);
            }

            foreach (string interact in interactOptions)
            {
                InteractionSelect.Items.Add(interact);
            }
        }


        //Updates the screen when there is a change in the
        //happiness or hunger
        public void UpdateScreen()
        {
            Task.Run(() =>
            {
                App.Current.Dispatcher.Invoke(() =>
                {
                    PetHappiness.Content = thisPet.happiness;
                    PetHunger.Content = thisPet.hunger;

                });
            });
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        //Feeds the pet from the selected dropdown
        private void FeedPet_Click(object sender, RoutedEventArgs e)
        {
            selectedFood = FoodSelect.Text;

            if (selectedFood != "")
            {
                thisPet.Feed(selectedFood);

                UpdateScreen();
            }
            else
            {
                MessageBox.Show("Select a food to feed your pet");
            }
        }

        private void InteractPet_Click(object sender, RoutedEventArgs e)
        {
            selectedInteraction = InteractionSelect.Text;

            if (selectedInteraction != "")
            {
                thisPet.Interaction(selectedInteraction);
                UpdateScreen();
            }
            else
            {
                MessageBox.Show("Select an action to interact with your pet");
            }

        }

        //Removes pet from the list of your pets
        private void RemovePet_Click(object sender, RoutedEventArgs e)
        {

            MyListOfPets.Pets.Remove(thisPet);
            ReturnToMyPets();

            System.Diagnostics.Debug.WriteLine(MyListOfPets.Pets.Count);


        }

        //Returns to your pets
        private void MyPets_Click(object sender, RoutedEventArgs e)
        {
            ReturnToMyPets();
        }

        private void ReturnToMyPets()
        {
            MyPets myListOfPets = new MyPets();
            myListOfPets.Show();
            this.Close();
        }
    }
}
