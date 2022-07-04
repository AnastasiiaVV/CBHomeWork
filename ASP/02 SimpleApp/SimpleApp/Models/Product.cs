using System;
using System.Collections.Generic;
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
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
    }
}
