using GameProject.Entities;

namespace GameProject
{
    public class SellManager : ISellService
    {
        private IOfferService _offerService;
        private IUserValitadion _userValitadion;

        public SellManager(IOfferService offerService, IUserValitadion userValitadion) //offer is a service.
        {
            _offerService = offerService;
            _userValitadion = userValitadion;
        }

        public void Add(Sell sell, Game game, Gamer gamer)
        {
            try
            {
                if (_userValitadion.Validate(gamer))
                {
                    _offerService.CreateOffer(sell, gamer, game);
                    System.Console.WriteLine("Satis yapildi!");
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                
            }
             
        }

        public void Delete(Sell sell, Game game, Gamer gamer)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Sell sell, Game game, Gamer gamer)
        {
            throw new System.NotImplementedException();
        }
    }
}