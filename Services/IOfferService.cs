using GameProject.Entities;

namespace GameProject
{
    public interface IOfferService
    {
        public void CreateOffer(Sell sell, Gamer gamer, Game game);
    }
}
