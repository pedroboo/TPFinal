using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin;
using Xamarin.Forms;
using TPFinal;

namespace TPFinal.Model
{

    public class Mercadoria
    {

        
        public class mercadoria{
        
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public String NmMercadoria { get; set; }
        Double PesoMercadoria { get; set; }
        String NmProdutor { get; set; }
        String EMailProdutor { get; set; }
        String NCM { get; set; }

    }

    }



}
