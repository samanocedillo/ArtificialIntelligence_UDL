//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnowDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Objecto
    {
        public int Id_Obj { get; set; }
        public string Nombre { get; set; }
        public string Definicion { get; set; }
    
        public virtual Animado Animado { get; set; }
        public virtual Color Color { get; set; }
    }
}
