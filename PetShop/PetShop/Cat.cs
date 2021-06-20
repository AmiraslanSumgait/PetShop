using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProgram
{
    class Cat
    {
        public string NickName { get; set; }
        public double Age { get; set; }
        public string Gender { get; set; }
        public double Energy { get; set; }
        public double Price { get; set; }
        public int MealQuantity { get; set; }
        public void Eat(int mealquantity)
        {
            
            if (MealQuantity < mealquantity)
            {
               Console.WriteLine($"This cat dont have {mealquantity} meals ");
            }
            else
            {
                Energy += mealquantity * 3;
                Price += mealquantity / 2;
                if (Energy > 100) Energy = 100;
                MealQuantity -= mealquantity;
            }
            
        }
        public void Sleep()
        {
            Energy += 40;
            if (Energy > 100) Energy = 100;

        }
        public void Play()
        {
            Energy -= 25;
            if (Energy <= 0)
            {
                Energy = 0;
                Sleep();
            }

        }
        public void Show()
        {
            Console.WriteLine($"Nickname:{NickName}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Gender:{Gender}");
            Console.WriteLine($"Energy:{Energy}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"MealQuantity:{MealQuantity}");
        }
    }
}
