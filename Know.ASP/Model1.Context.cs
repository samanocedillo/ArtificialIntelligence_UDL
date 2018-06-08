﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Know.ASP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbConocimientoEntities : DbContext
    {
        public dbConocimientoEntities()
            : base("name=dbConocimientoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Objecto> Objecto { get; set; }
        public virtual DbSet<Animado> Animado { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
    
        public virtual ObjectResult<Nullable<int>> spConocimiento(Nullable<int> opc, string nombre, string def, string col, string ani, string gen, Nullable<int> cont)
        {
            var opcParameter = opc.HasValue ?
                new ObjectParameter("Opc", opc) :
                new ObjectParameter("Opc", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var defParameter = def != null ?
                new ObjectParameter("Def", def) :
                new ObjectParameter("Def", typeof(string));
    
            var colParameter = col != null ?
                new ObjectParameter("Col", col) :
                new ObjectParameter("Col", typeof(string));
    
            var aniParameter = ani != null ?
                new ObjectParameter("Ani", ani) :
                new ObjectParameter("Ani", typeof(string));
    
            var genParameter = gen != null ?
                new ObjectParameter("Gen", gen) :
                new ObjectParameter("Gen", typeof(string));
    
            var contParameter = cont.HasValue ?
                new ObjectParameter("Cont", cont) :
                new ObjectParameter("Cont", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spConocimiento", opcParameter, nombreParameter, defParameter, colParameter, aniParameter, genParameter, contParameter);
        }
    }
}