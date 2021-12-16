using GameProject.Entities;
using System;

namespace GameProject
{
    public class UserValidationManager : IUserValitadion
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.FirstName=="Serhat" && gamer.LastName == "Oner" &&  gamer.BirthYear == 1950 &&  gamer.IdentityNumber == 2131231)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
