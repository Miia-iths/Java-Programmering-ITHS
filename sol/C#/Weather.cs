using System;
using System.Globalization;
using System.Net.Security;
using System.Security.Cryptography;
using System.Transactions;

/*Hej, jag tar de på svenska för ovanlighetens skull,
tänkte nämna att // kommentarer är mer för mig.
Jag lägger dokumentationen i word dokumentet*/

namespace Weather
{
    class City
    {
        public string name;
        public int temperature;
        public City(string n, int t) //constructor 
        {
            name = n;
            temperature = t;
        }
        public string ToString() //to present the cities and temperatures
        {
            return "City: " + name + ", Temperature: " + temperature + "°C";
        }
    }
    class Program
    {
        static City InputCity() //method to take input from user
        {
            Console.Write("Enter city name: ");
            string inputName = Console.ReadLine();

            int inputTemp;

            Console.Write("Enter temperature °C: ");
            while (true) //added failsafe per instructions
            {
                if (!int.TryParse(Console.ReadLine(), out inputTemp))
                {
                    Console.Write("Invalid input. Please enter temperature, ex. [28]°C");
                    continue;
                }
                if (inputTemp < -100 || inputTemp > 100)
                {
                    Console.WriteLine("Extreme temperature input. Please enter a temperature in Celcius between -100°C and +100°C");
                    continue;
                }
                break;
            }
            
            City myCity = new City(inputName, inputTemp);
            return myCity;

           // Console.WriteLine(myCity.ToString());
        }

        static int LinearSearch(City[] cities, int numCities, int searchTemp)
        //linear searching method
        {
            for (int i = 0; i < numCities; i++) //going through all the cities one by one
            {
                if (cities [i].temperature == searchTemp)
                {
                    return i; //if match is found, return index
                }
            }
            return -1; //no match found, return -1
        }

        static void BubbleSort(City[] cities, int n)
        //bubble sorting method
        {
            for(int i = 0; i < n - 1; i++) //going through the cities but now to sort them
            {
                for(int j = 0; j < n - 1; j++)
                {
                    //if they aren't in order, change places
                    if (cities[j].temperature > cities[j + 1].temperature)
                    {
                        City temp = cities[j]; //save
                        cities[j] = cities[j + 1]; //change place
                        cities[j + 1] = temp; //change place
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            City [] cities = new City [4];
        
            for (int i = 0; i < 4; i++) //looping through 4 times for the assignment
            {
                cities [i] = InputCity(); //calling the input method
            }

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i].ToString()); //calling the print method before sorting
            }

            BubbleSort(cities, cities.Length); //calling the BubbleStort method

            Console.WriteLine("\nYour cities sorted by temperature:");
            foreach (City c in cities) //using foreach for variation
            {
                Console.WriteLine(c.ToString()); //calling print out after sorting
            }

            int inputSearchTemp;
            Console.Write("\nEnter temperature to search for: ");
            //asking for input for the linear search, with failsafe
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out inputSearchTemp))
                {
                    Console.Write("Invalid input. Try Again ;)");
                    continue;
                }
                break;
            }
            int matchCityIndex = LinearSearch(cities, cities.Length, inputSearchTemp);
            //calling linear search method

            if (matchCityIndex < 0) //controll for match
            {
                Console.WriteLine("There are no cities matching the temperature you entered");
            }
            else //if no match
            {
                Console.WriteLine($"City: {cities[matchCityIndex].name}");
            }
        }
    }
}
