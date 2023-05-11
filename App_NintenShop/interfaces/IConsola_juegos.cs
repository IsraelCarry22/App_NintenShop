using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_NintenShop
{
    internal interface IConsola_juegos
    {
        string TITLE { get; set; }
        string GENERE { get; set; }
        string CREATORS { get; set; }
        int PRICE { get; set; }
        int QUANTITY { get; set; }
        string ToString();
        string Ticket();
    }
}