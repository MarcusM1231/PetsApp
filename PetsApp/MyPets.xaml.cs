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

namespace PetsApp
{
    /// <summary>
    /// Displays a list of your pets 
    /// </summary>
    public partial class MyPets : Window
    {
        public MyPets()
        {
            InitializeComponent();

            ShowPets();
        }

        //Shows a list of pets on the screen when you have 1
        // or more
        public void ShowPets()
        {
            if (MyListOfPets.Pets.Count == 0)
            {
                NoPetsLabel.Visibility = Visibility.Visible;
            }
            else
            {
                NoPetsLabel.Visibility = Visibility.Hidden;

                foreach (Pet pet in MyListOfPets.Pets)
                {
                    Button newBtn = new Button()
                    {
                        Content = pet.petImage + " " + pet.name,
                        Tag = pet
                    };
                    newBtn.Click += new RoutedEventHandler(newBtn_Click);
                    sp.Children.Add(newBtn);
                }
            }

        }

        //Takes you to the details of the pet
        void newBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("You clicked on the {0}. button.", (sender as Button).Tag));
            PetDetails details = new PetDetails((Pet)(sender as Button).Tag);
            details.Show();
            this.Close();
        }

        //Returns you to home screen
        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
