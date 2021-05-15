using System;
using System.Collections.Generic;
using System.Text;
using Example.Catalogos.Entities.Model;
namespace Example.Catalogos.DataAccess.DAO.Catalogos
{
    class Datos
    {
        public static List<CatalogosModel> datos = new List<CatalogosModel>()
        {
            new CatalogosModel { Id = 1, FirstName = "Ingrid", LastName = "Mendoza", Email = "ingrid.mendoza@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 2, FirstName = "Arleth", LastName = "Mendoza", Email = "arleth.mendoza@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 3, FirstName = "Veronica", LastName = "Cabrera", Email = "veronica.cabrera@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 4, FirstName = "Neftali", LastName = "Mendoza", Email = "neftali.mendoza@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 5, FirstName = "Alejandro", LastName = "Ojeda", Email = "alejandro.ojeda@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 6, FirstName = "Jorge", LastName = "Morales", Email = "jorge.morales@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 7, FirstName = "Arturo", LastName = "Miranda", Email = "arturo.miranda@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 8, FirstName = "Benjamin", LastName = "Galindo", Email = "benjamin.galindo@axity.com", Birthdate = DateTime.Now },
        };
    }
}
