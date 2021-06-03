using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Entities;

namespace WebApplication2.Models
{
    public class ResponseGroup
    {
        public ResponseGroup(Group responseGroup)
        {
            Group_Number = responseGroup.Group_Number;
        }
        public int id_group { get; set; }
        public string Group_Number { get; set; }
    }
}