using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPFinal;
using TPFinal.Model;

using Android.App;
using Android.Util;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TPFinal.Droid.Resources.DataBase
{
    class database
    {
        //local do banco de dados
        public string pastaDados = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool CriarBancoDeDados()
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pastaDados, "Mercadoria.db")))
                {
                    conexao.CreateTable<Mercadoria>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite ex PV", ex.Message);
                return false;
            }
        }

        public bool InserirMercadoria(Mercadoria mercadoria)
        {

            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pastaDados, "mercadoria.db")))
                {
                    conexao.Insert(mercadoria);

                    return true;

                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite ex AR", ex.Message);
                return false;
            }

        }

        public List<Mercadoria> GetMercadorias()
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pastaDados, "mercadoria.db")))
                {

                    return conexao.Table<Mercadoria>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite ex TULLER", ex.Message); return null;
            }
        }

         public bool AtualizarMercadoria (Mercadoria mercadoria)
         {
             try
             {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pastaDados, "mercadoria.db"))){


                    conexao.Query<Mercadoria>("UPDATE Mercadoria set NmMercadoria =?, PesoMercadoria =?, NmProdutor =?," +
                         "EMa/ilProdutor=?, NCM = ? where id = ?", mercadoria) ;
                     return true;
                 }
             }catch (SQLiteException ex)
             {
                 Log.Info("SQLite ex Nos", ex.Message);
                return false; 
            }
         }


        public bool DeletarMercadoria(Mercadoria mercadoria)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pastaDados, "mercadoria.db")))
                {
                    conexao.Delete(mercadoria);
                    return true;

                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLITE Mosqueteiro", ex.Message);
                return false;
            }
        }

        public bool GetMercadoria(Mercadoria Id)//seleciona Mercadoria pelo Id
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pastaDados, "mercadoria.db")))
                {

                    conexao.Query<Mercadoria>("Select * From Mercadoria where Id =?", Id);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLite ex ,", ex.Message);
                return false;
            }

        }
    }
}