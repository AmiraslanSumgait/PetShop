using System;

namespace PetShopProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat
            {
                NickName = "Tigger",
                Age = 2,
                Energy = 30,
                Gender = "Male",
                Price = 350,
                MealQuantity = 35

            };
            Cat cat2 = new Cat
            {
                NickName = "Muffin",
                Age = 1.5,
                Energy = 65,
                Gender = "Female",
                Price = 230,
                MealQuantity = 30

            };
            Cat cat3 = new Cat
            {
                NickName = "Sylvester",
                Age = 1,
                Energy = 20,
                Gender = "Male",
                Price = 440,
                MealQuantity = 20

            };
            //Cat Methods**************************
            cat3.Play();//The cat loses 25 energy while playing.When cat energy is 0  should go to sleep 
           // cat3.Eat(4);//We send the quantity of meals to the Eat method.The price per meal increases by 0.5, the energy increases by 3.
           // cat3.Sleep();//When a cat sleeps, its energy increases by 40
            cat3.Show();
            //CatHouse methods**********************
            CatHouse cathouse1 = new CatHouse
            {
                Cats = new Cat[] { cat1, cat2 },
                Name = "Maya Nook"

            };
            //cathouse1.AddCat(cat3);
            //cathouse1.RemoveByNickname("Sylvester");
            // cathouse1.ShowCats();
            //cathouse1.ShowCatsMealsAndPrice();
            //PetShop methods**********************
            PetShop petshop = new PetShop
            {
                CatHouses = new CatHouse[] { cathouse1 }
            };
            // petshop.showCatHouses();
            //petshop.DeleteCatHouse("Maya Nook");     
        }
    }
}
