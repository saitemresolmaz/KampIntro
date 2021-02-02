using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class ValidationManager : IValidationService
    {

        public bool Validate(Gamer gamer)
        {

            if (gamer.TcNo == "26118673466" && gamer.Name == "Koray" && gamer.Surname == "Bıçak" && gamer.BirthOfDay == "27.05.1996")
            {
                return true;

            }
            return false;
        }
    }
}
