using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TPFinal.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection() ;
    }
}
