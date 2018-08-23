//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreSys
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViaPago
    {
        public int Id { get; set; }
        public Nullable<int> BancoId { get; set; }
        public Nullable<int> ViaTipoID { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Estado { get; set; }
        public string Referencia { get; set; }
        public Nullable<decimal> MontoPago { get; set; }
    
        public virtual Banco Banco { get; set; }
        public virtual ViaTipo ViaTipo { get; set; }
        public virtual ViaPago ViaPago1 { get; set; }
        public virtual ViaPago ViaPago2 { get; set; }
    }
}
