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

namespace PetsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PetStore store;
        private MyPets petWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Sends you to your house with your pets
        private void CheckPet_Click(object sender, RoutedEventArgs e)
        {
            petWindow = new MyPets();
            petWindow.Show();
            this.Close();
        }

        //Sends you to the pet store
        private void PetStore_Click(object sender, RoutedEventArgs e)
        {
            store = new PetStore();
            store.Show();
            this.Close();
        }
    }
}
