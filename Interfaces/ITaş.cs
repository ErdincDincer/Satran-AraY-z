using SatrançAraYüz.Entities;
using SatrançAraYüz.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrançAraYüz.Interfaces
{
    public interface ITaş
    {
        TaşTipleri TaşTipleri { get; }
        TaşRenkleri TaşRenkleri { get; set; }
        Lokasyon Lokasyon { get; set; }
        string ResimYolu { get;}
        void İlerle(Yön Yön);
    }
}
