using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TPFinal.Droid.Resources
{
    class Mercadoria
    {
        public class mercadoria
        {
            [PrimaryKey, AutoIncrement]
            public int id { set; get; }
            public String NmMercadoria { get; set; }
            public Double PesoMercadoria { get; set; }
            public String NmFornecedor { get; set; }
            public String EmailFornecedor { get; set; }



        }
    }
}
