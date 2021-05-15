// <summary>
// <copyright file="CatalogosDao.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Example.Catalogos.DataAccess.DAO.Catalogos
{
    using Example.Catalogos.Entities.Context;
    using Example.Catalogos.Entities.Model;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Class Catalogos Dao
    /// </summary>
    public class CatalogosDao : ICatalogosDao
    {
        private readonly IDatabaseContext databaseContext;
        List<CatalogosModel> datos = Datos.datos;
      
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogosDao"/> class.
        /// </summary>
        /// <param name="databaseContext">DataBase Context</param>
        public CatalogosDao(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<CatalogosModel>> GetAllCatalogosAsync()
        {
            return this.datos;
        }

        /// <inheritdoc/>
        public async Task<CatalogosModel> GetCatalogosAsync(int id)
        {
            return this.datos.Find(user => user.Id == id);
        }

        /// <inheritdoc/>
        public async Task<bool> InsertCatalogos(CatalogosModel model)
        {
            this.datos.Add(model);
            return this.datos.Exists(x => x.Id == model.Id); ;
        }

        /// <inheritdoc/>
        public async Task<bool> UpdateCatalogos(CatalogosModel model)
        {
            int index = this.datos.FindIndex(x => x.Id == model.Id);
            this.datos[index] = model;
            return this.datos[index] == model ? true : false;
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteCatalogos(int id)
        {
            return this.datos.Remove(this.datos.Find(user => user.Id == id));
        }

        /// <summary>
        /// List of Catalogoss.
        /// </summary>
        /// <returns>IEnumerable Catalogoss.</returns>
        public IEnumerable<CatalogosModel> GetAllCatalogos()
        {
            return new List<CatalogosModel>()
            {
                new CatalogosModel { Id = 1, FirstName = "Alejandro", LastName = "Ojeda", Email = "alejandro.ojeda@axity.com", Birthdate = DateTime.Now },
                new CatalogosModel { Id = 2, FirstName = "Jorge", LastName = "Morales", Email = "jorge.morales@axity.com", Birthdate = DateTime.Now },
                new CatalogosModel { Id = 3, FirstName = "Arturo", LastName = "Miranda", Email = "arturo.miranda@axity.com", Birthdate = DateTime.Now },
                new CatalogosModel { Id = 4, FirstName = "Benjamin", LastName = "Galindo", Email = "benjamin.galindo@axity.com", Birthdate = DateTime.Now },
            };
        }
    }
}
