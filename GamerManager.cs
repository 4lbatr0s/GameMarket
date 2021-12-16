using GameProject.Entities;
using System;

namespace GameProject
{
    public class GamerManager : IGamerService
    {

        //use validationservice.


        private UserValidationManager _userValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager; // DEPENDENCY INJECTION.  
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer))
            {
                Console.WriteLine("Kullanici dogrulandi.");
                Console.WriteLine("Kullanici eklendi!");
            }
               
            
        }

        public void Delete(Gamer gamer)
        {
            if(_userValidationManager.Validate(gamer))
            {
                Console.WriteLine("Kullanici dogrulandi..");
                Console.WriteLine("Kullanici silindi");
            }
                 
        }

        public void Update(Gamer gamer)
        {   if(_userValidationManager.Validate(gamer))
            {
                Console.WriteLine("Kullanici dogrulandi..");
                Console.WriteLine("Kullanici guncellendi!");
            }
                
        }
    }
}
