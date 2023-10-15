using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.Programs.Module_5
{

    internal class Task_5_2_1
    {
        private class City
        {
            public City(string name, long population)
            {
                Name = name;
                Population = population;
            }

            public string Name { get; set; }
            public long Population { get; set; }
        }

        public static void CitiesTask()
        {
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            var shortNameCities = russianCities.Where(city => city.Name.Length <= 10).OrderBy(city => city.Name.Length);
            foreach (var city in shortNameCities) Console.WriteLine(city.Name);
        }
    }
}
