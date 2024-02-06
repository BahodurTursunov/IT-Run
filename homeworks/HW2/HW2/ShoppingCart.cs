using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class ShoppingCart : Product
    {
        public int Count { get; set; } // здесь должен стоять апи для кнопки добавление товара
        public int CartId { get; set; } // id корзины
        public int ProductId { get; set; }
        public double Price { get; set; }

        public void CountOfProduct(int count, double price) // метод подсчитывающий количество товаров и возвращающий итоговую цену /// подсчетом занимается client со стороны фронта
        {
            Count = count;
            Price = price;
        }
    }
}
