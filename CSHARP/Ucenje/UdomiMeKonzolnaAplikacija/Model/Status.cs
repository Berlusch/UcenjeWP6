using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ucenje.UdomiMeKonzolnaAplikacija.Model.Pas;

namespace Ucenje.UdomiMeKonzolnaAplikacija.Model
{

    

    public class Status : Entitet
    {
        public string Naziv { get; set; } = "";
        

        public Status GetStatusByEnum(StatusEnum statusEnum)
        {
            return new Status
            {
                Naziv = statusEnum.ToString()  // Pretvaranje StatusEnum u string
                
            };
        }


    }
    
}


