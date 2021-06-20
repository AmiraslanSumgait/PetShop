using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProgram
{
    class CatHouse
    {
        public Cat[] Cats { get; set; }
        public int CatCount { get; set; }
        public string Name { get; set; }
        public void AddCat(Cat cat)
        {
            Cats = Cats.Concat(new Cat[] { cat }).ToArray();
        }
        public void RemoveByNickname(string nickname)
        {
            int CatCount = Cats.Length - 1;
            Cat[] cats = new Cat[CatCount];
            for (int i = 0; i < CatCount; i++)
            {
                if (Cats[i].NickName != nickname)
                {
                    cats[i] = Cats[i];
                }

            }
            Cats = cats;
        }
        public void ShowCats()
        {
            foreach (var cat in Cats)
            {
                cat.Show();
                Console.Write("\n");
            }
        }
        public void ShowCatsMealsAndPrice()
        {
            double allCatPrices = 0;
            double allCatMealQuantity = 0;
            foreach (var cat in Cats)
            {
                allCatPrices += cat.Price;
                allCatMealQuantity += cat.MealQuantity;
            }
            Console.WriteLine($"Sum cat prices:{allCatPrices}");
            Console.WriteLine($"Sum cat mealquantity:{allCatMealQuantity}");
        }
    }
}
