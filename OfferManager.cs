using GameProject.Entities;
using System;
namespace GameProject
{
    public class OfferManager : IOfferService
    {

        public void CreateOffer(Sell sell, Gamer gamer, Game game)
        {
            try
            {
                if (gamer.GamerId == 2131231 && sell.Id == 193912830)
                {
                    if(game.Name == "GTAV")
                    {
                        Console.WriteLine("Kampanya uretiliyor...");
                        Console.WriteLine("{0}'nın aldığı oyun :{1}, yapılan indirim:%{2}, indirimli fiyat:{3} ", gamer.FirstName + gamer.LastName, game.Name, 20, game.Price * 0.8);
                        Console.WriteLine("Kampya uretildi...");
                    }
                    else
                    {
                        Console.WriteLine("Bu oyun icin indirim yok.");
                    }
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
