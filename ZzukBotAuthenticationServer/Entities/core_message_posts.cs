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
    
    public partial class core_message_posts
    {
        public int msg_id { get; set; }
        public int msg_topic_id { get; set; }
        public Nullable<int> msg_date { get; set; }
        public string msg_post { get; set; }
        public string msg_post_key { get; set; }
        public decimal msg_author_id { get; set; }
        public string msg_ip_address { get; set; }
        public int msg_is_first_post { get; set; }
    }
}