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
    
    public partial class Pago
    {
        public int Id { get; set; }
        public Nullable<int> CuotaId { get; set; }
        public Nullable<int> PrestamoId { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> Capital { get; set; }
        public Nullable<decimal> Interes { get; set; }
        public Nullable<decimal> Mora { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> CuotasPagadas { get; set; }
        public Nullable<int> CuotasPendientes { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> ViaPagoId { get; set; }
        public Nullable<int> UsuarioId { get; set; }
    }
}
