//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZzukBotAuthenticationServer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class core_voters
    {
        public int vid { get; set; }
        public int vote_date { get; set; }
        public int tid { get; set; }
        public decimal member_id { get; set; }
        public short forum_id { get; set; }
        public string member_choices { get; set; }
        public string ip_address { get; set; }
        public int poll { get; set; }
    }
}