using GameProject.Entities;

namespace GameProject
{
    interface IGameService
    {
         void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
