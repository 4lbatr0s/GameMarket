using GameProject.Entities;

namespace GameProject
{
    interface ISellService
    {
        public void Add(Sell sell, Game game, Gamer gamer);
        public void Delete(Sell sell, Game game, Gamer gamer);
        public void Update(Sell sell, Game game, Gamer gamer);
    }
}