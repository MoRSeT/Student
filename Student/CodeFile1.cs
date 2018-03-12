using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ProductList : IEnumerable
    {
        private List<Product> car; // список с объектами класса Car 
        public int Length // свойство : количество объектов класса Car в коллекции List<T> 
        {
            get { return car.Count; }
        }

        // выделяем емкость для списка  
        public ProductList(int size)
        {
            car = new List<Product>(size);
        }

        // добавление элемента в коллекцию. 
        public void AddItem()
        {
            Product item = new Product();
            item.Input();
            car.Add(item);
        }

        // удаление элемента из коллекции по заданной позиции 
        public void RemoveItem(int pos)
        {
            car.RemoveAt(pos);
        }

        public Product this[int index]
        {
            get { return car[index]; }
            set { car[index] = value; }
        }

        // возвращаем перечислитель. 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return car.GetEnumerator();

        }
    }
}
