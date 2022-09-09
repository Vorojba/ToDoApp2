using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp2.Model;
using System.Text.Json;



namespace ToDoApp2.Services
{
    public  class CountryServise
    {
        // Создаем список для хранения данных из источника
        public static List<Country> countryList = new();
        // Метод GetFood() служит для извлечения и сруктурирования данных
        // в соответсвии с существующей моделью данных
        public static async Task<IEnumerable<Country>> GetCountry()
        {
            // Если список содержит какие-то элементы
            // то вернется последовательность с содержимым этого списка
            if (countryList?.Count > 0)
                return countryList;

            // В данном блоке кода осуществляется подключение, чтение
            // и дессериализация файла - источника данных
            using var stream = await FileSystem.OpenAppPackageFileAsync("Country.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            countryList = JsonSerializer.Deserialize<List<Country>>(contents);
            return countryList;

        }
    }
}
