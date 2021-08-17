using System;
using System.Collections.Generic;
using System.Text;
using Entitiy_layer;

namespace b_Business_layer
{
    public class Business_User
    {
        public int sumarAños(Entity_User user) {
            user.Age = (user.Age + 10);
            return user.Age;
        }

        public Boolean mayorEdad(Entity_User user) {
            if (user.Age >= 18) {
                return true;
            } else {
                return false;
            }
        }
    }
}
