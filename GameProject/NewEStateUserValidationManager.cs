using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Devlet dedi ki artık Mernisten Sorgulama yapmıyoruz. Yeni E Devlet sisteminden yapacağız.
    class NewEStateUserValidationManager : IValidationService

    {
        public bool Validate(Gamer gamer)
        {
            return true;  //test amaçlı doğrulama başarılı dönsün dedik.
        }
    }
}
