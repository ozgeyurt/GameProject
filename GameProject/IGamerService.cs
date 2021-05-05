using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerService  //add update delete
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
