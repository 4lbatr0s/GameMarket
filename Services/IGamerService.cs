using GameProject.Entities;

namespace GameProject
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
             
    }
}
