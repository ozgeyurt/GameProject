using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void Buy(Sale sale)
        {
            Console.WriteLine(sale.GameName + "oyunu" + " " + sale.UserName + " " + "kullanıcısı tarafından" + " " + sale.GamePrice + "TL karşılığı satın alındı");
        }
    }
}
