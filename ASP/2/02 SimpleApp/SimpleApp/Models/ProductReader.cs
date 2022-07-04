using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Models
{
    //Одним из ключевых компонентов паттерна MVC являются модели.
    //Ключевая задача моделей - описание структуры и логики используемых данных.

    //Как правило, все используемые сущности в приложении выделяются в отдельные
    //модели, которые и описывают структуру каждой сущности. В зависимости от 
    //задач и предметной области мы можем выделить различное количество моделей
    //в приложении.

    //Все модели оформляются как обычные классы на языке C#.
    public class ProductReader
    {
        private readonly string path = "App_Data/data.txt";

        public List<Product>  ReadFromFile()
        {

            // Сводка: ReadAllLines
            // Открывает текстовый файл, читает все строки файла, а затем закрывает файл.
            //
            // Параметры:
            //   дорожка:
            // Файл, который нужно открыть для чтения.
            //
            // Возврат:
            // Строковый массив, содержащий все строки файла.
            string[] lines = File.ReadAllLines(path);

            List<Product> result = new List<Product>();
            foreach (string line in lines)
            {
                //lines[0] = 1, Mobile Phone, 600
                string[] items = line.Split(','); /*1 Mobile Phone 600*/

                Product product = new Product();
                // Сводка: Trim
                // Удаляет все начальные и конечные символы пробела из текущей строки.
                //
                // Возврат:
                // Строка, которая остается после удаления всех символов пробела из
                // начало и конец текущей строки. Если невозможно обрезать символы из
                // текущий экземпляр, метод возвращает текущий экземпляр без изменений.
                product.Id = Convert.ToInt32(items[0].Trim());
                product.Name = items[1].Trim();
                product.Price = Convert.ToDouble(items[2].Trim());
                product.Description = items[3].Trim();
                product.Count = Convert.ToInt32(items[4].Trim());
                product.Category = items[5].Trim();
                result.Add(product);
            }

            return result;
        }
    }
}
