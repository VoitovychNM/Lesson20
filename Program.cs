using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson20
{
    class Program
    {
        static Random rnd = new Random();


        static void Main(string[] args)
        {
            #region LINQ for int

            //var collection = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    collection.Add(i);
            //}


            //var result = from item in collection
            //             where item < 5 
            //             select item;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result2 = collection.Where(item => item < 5);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            
            #region LINQ for myClass
            //var collection = new List<Product>();
            //for (int i = 0; i < 10; i++)
            //{
            //    var product = new Product()
            //    {
            //        Name = "product " + i,
            //        Energy = rnd.Next(10, 500)
            //    };
            //    collection.Add(product);

            //}
            //// тут ми пишемо через отакі ряди
            //var result = from item in collection
            //             where item.Energy < 200 && item.Name == "product 1"
            //             select item;
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n\n\n");

            ////*********
            //// а тут пишемо через крапочку ******ОТАК ЧАСТІШЕ ВИКОРИСТОВУЮТЬ*********
            //// ще називають форму "за допомогою розширення"
            ////*********
            //var result2 = collection.Where(item => item.Energy < 200);
            //foreach(var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            
            
            
            
            
            var product = new List<Product>();
            for (int i = 0; i < 10; i++) 
            {
                var p = new Product()
                {
                    Name = "prodyct " + i,
                    Energy = rnd.Next(10, 500)
                };
                product.Add(p);
            }

            foreach (var item in product)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n");
            //////////////////
            #region SELECT
            // Використання SELECT як перетворення одного типу в інший
            // тобто тут ми свторили нову колекцію з яка буде вміщати 
            // в себе тільки значення поля Energy тобіто тільки числа

            //var SelectCollection = product.Select(product => product.Energy);

            //foreach (var item in SelectCollection)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            //////////////////


            // сортуваня через OrderBy
            #region OrderBy
            //var orderbyCollection = product.OrderBy(product => product.Energy);
            //foreach (var item in orderbyCollection)
            //{
            //    Console.WriteLine(item);
            //}

            // також ми можемо використовувати декілька сортувань
            // для цього ми використовуємо ThenBy
            // Descending означає що сортуємо в оберненому порядку

            //var orderbyCollection = product.OrderBy(product => product.Energy)
            //                               .ThenBy(product => product.Name);
            //foreach (var item in orderbyCollection)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //групування через GroupBy _____________________на тому і закінчив,,,,,,,,,,,,,,.
            //
            // 58:00
            //

            var groupbyCollection = product.GroupBy(product => product.Energy);
            foreach(var group in groupbyCollection)
            {
                Console.WriteLine();
                foreach(var item in group)
                {

                }
            }
        }
    }
}
