using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace PetsApp
{
    [Serializable]
    public abstract class Pet
    {
        public string name;
        public int happiness;
        public int hunger;
        protected int maxHunger;
        protected int maxHappiness;
        public string petImage;
        public DispatcherTimer timer = new DispatcherTimer();

        protected Pet()
        {
            timer.Interval = TimeSpan.FromMinutes(2);
            timer.Tick += Timer_Tick;
        }

        //Feeds the pet and updates happiness / hunger values
        public abstract void Feed(string food);

        //Interacts with the pet and updates happiness / hunger values
        public abstract void Interaction(string action);

        // Gets the status of the pet
        public abstract string GetStatus();

        private void Timer_Tick(object sender, EventArgs e)
        {
            hunger += 1;
            happiness -= 1;

            ManageValues();
        }
        // Manages values when happiness or hunger goes below or above max/min values
        protected void ManageValues()
        {
            if (happiness < 0)
            {
                happiness = 0;
            }

            if (hunger < 0)
            {
                hunger = 0;
            }

            if (happiness > maxHappiness)
            {
                happiness = maxHappiness;
            }

            if (hunger > maxHunger)
            {
                hunger = maxHunger;

            }
        }
    }

    //Dog Pet
    public class Dog : Pet
    {
        public Dog(string name)
        {
            this.name = name;
            happiness = 5;
            maxHappiness = 10;
            hunger = 2;
            maxHunger = 10;
            petImage = "🐕";
        }

        public override void Feed(string food)
        {

            switch (food)
            {
                case "Bacon Snack":
                    hunger = hunger / 2;
                    happiness += 1;
                    break;
                case "Dry Dog Food":
                    hunger = 0;
                    happiness += 1;
                    break;
                default:
                    happiness -= 2;
                    hunger += 2;
                    break;
            }
            ManageValues();
            timer.Stop();
            timer.Start();
        }

        public override void Interaction(string action)
        {
            if (happiness >= 0 && hunger < maxHunger)
            {
                switch (action)
                {
                    case "Rub belly":
                        hunger += 1;
                        happiness += 1;
                        break;
                    case "Play":
                        hunger += 3;
                        happiness += 2;
                        break;
                    case "Scold":
                        hunger += 2;
                        happiness -= 2;
                        break;
                    default:
                        happiness -= 2;
                        hunger += 2;
                        break;
                }
            }

            ManageValues();
        }

        public override string GetStatus()
        {
            string status = $"Name {name}; Happiness {happiness}; Hunger {hunger};";
            Console.WriteLine(status);
            return status;
        }
    }

    //Cat Pet
    public class Cat : Pet
    {
        public Cat(string name)
        {
            this.name = name;
            happiness = 4;
            maxHappiness = 5;
            hunger = 2;
            maxHunger = 8;
            petImage = "🐈";
        }

        public override void Feed(string food)
        {
            switch (food)
            {
                case "Tuna":
                    hunger = 0;
                    happiness += 3;
                    break;
                case "Dry Cat Food":
                    hunger = hunger / 2;
                    happiness += 1;
                    break;
                default:
                    happiness -= 2;
                    hunger += 2;
                    break;
            }
            ManageValues();
            timer.Stop();
            timer.Start();
        }

        public override void Interaction(string action)
        {
            if (happiness >= 0 && hunger < maxHunger)
            {
                switch (action)
                {
                    case "Pet":
                        Random random = new Random();

                        if (random.Next(2) == 0)
                        {
                            hunger += 1;
                            happiness += 1;
                        }
                        else
                        {
                            happiness -= 2;
                            hunger += 2;
                        }
                        break;
                    case "Ignore":
                        hunger += 1;
                        happiness += 2;
                        break;
                    case "Scold":
                        hunger += 2;
                        happiness -= 2;
                        break;
                    default:
                        happiness -= 2;
                        hunger += 2;
                        break;
                }
            }
            ManageValues();
        }

        public override string GetStatus()
        {
            return $"Name {name}; Happiness {happiness}; Hunger {hunger};";
        }
    }

    //Plant Pet
    public class Plant : Pet
    {
        public Plant(string name)
        {
            this.name = name;
            happiness = 2;
            maxHappiness = 5;
            hunger = 2;
            maxHunger = 6;
            petImage = "🌱";
            timer.Interval = TimeSpan.FromMinutes(1);

        }

        public override void Feed(string food)
        {

            switch (food)
            {
                case "Water":
                    hunger = hunger / 2;
                    happiness += 1;
                    break;
                case "Plant Food":
                    hunger = 0;
                    happiness += 1;
                    break;
                default:
                    happiness -= 2;
                    hunger += 2;
                    break;
            }
            ManageValues();
            timer.Stop();
            timer.Start();
        }


        public override void Interaction(string action)
        {
            if (happiness >= 0 && hunger < maxHunger)
            {
                switch (action)
                {
                    case "Talk":
                        hunger += 1;
                        happiness += 1;
                        break;
                    case "Play Music":
                        hunger += 1;
                        happiness += 2;
                        break;
                    case "Ignore":
                        hunger += 3;
                        happiness -= 3;
                        break;
                    default:
                        happiness -= 2;
                        hunger += 2;
                        break;
                }
            }
            ManageValues();
        }

        public override string GetStatus()
        {
            string status = $"Name {name}; Happiness {happiness}; Hunger {hunger};";
            Console.WriteLine(status);
            return status;
        }
    }

    //Fish Pet
    public class Fish : Pet
    {
        public Fish(string name)
        {
            this.name = name;
            happiness = 2;
            maxHappiness = 5;
            hunger = 2;
            maxHunger = 5;
            petImage = "🐟";
            timer.Interval = TimeSpan.FromMinutes(3);

        }

        public override void Feed(string food)
        {

            switch (food)
            {
                case "Fish Food":
                    hunger = 0;
                    happiness += 1;
                    break;
                default:
                    happiness -= 2;
                    hunger += 2;
                    break;
            }
            ManageValues();
            timer.Stop();
            timer.Start();
        }


        public override void Interaction(string action)
        {
            if (happiness >= 0 && hunger < maxHunger)
            {
                switch (action)
                {
                    case "Talk":
                        hunger += 1;
                        happiness += 1;
                        break;
                    case "Play Music":
                        hunger += 1;
                        happiness += 1;
                        break;
                    case "Tap on glass":
                        hunger += 3;
                        happiness -= 2;
                        break;
                    default:
                        happiness -= 2;
                        hunger += 2;
                        break;
                }
            }
            ManageValues();
        }

        public override string GetStatus()
        {
            string status = $"Name {name}; Happiness {happiness}; Hunger {hunger};";
            Console.WriteLine(status);
            return status;
        }
    }

}
