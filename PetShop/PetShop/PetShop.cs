using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProgram
{
    class PetShop
    {
        public CatHouse[] CatHouses { get; set; }
        public int CatHouseCount { get; set; }
        public void AddCatHouse(CatHouse cathouse)
        {
            CatHouses = CatHouses.Concat(new CatHouse[] { cathouse }).ToArray();
        }
        public void DeleteCatHouse(string name)
        {
            int CatHouseCount = CatHouses.Length - 1;
            CatHouse[] catHouses = new CatHouse[CatHouseCount];
            for (int i = 0; i < CatHouseCount; i++)
            {
                if (CatHouses[i].Name != name)
                {
                    catHouses[i] = CatHouses[i];
                }

            }
            CatHouses = catHouses;
        }
        public void showCatHouses()
        {
            foreach (var cathouse in CatHouses)
            {
                Console.WriteLine($"Cathouse Name:------{ cathouse.Name}------\n");
                cathouse.ShowCats();
                Console.Write("\n");
            }
        }
    }
}
