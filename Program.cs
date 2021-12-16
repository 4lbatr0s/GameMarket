using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManger = new GamerManager(new UserValidationManager()); //gamerManager instance çalışmak için bir UserValidationManager(Yani Servis)'e ihtiyaç duyuyor.
            gamerManger.Add(new Gamer { 
            
                FirstName="Serhat",
                LastName = "Oner",
                BirthYear = 1950,
                GamerId = 12312,
                IdentityNumber = 00293993939
            });

                
            SellManager sellManager= new SellManager(new OfferManager(), new UserValidationManager());
                sellManager.Add(new Sell
                {
                    Id = 193912830

                 },
                new Game
                {
                    Genre = "First Player",
                    Name = "GTAV",
                    Price = 100
                },
                new Gamer
                {
                    FirstName = "Serhat",
                    LastName = "Oner",
                    BirthYear = 1950,
                    GamerId = 2131231,
                    IdentityNumber = 2131231
                });
           
            


        }
    }
}
