using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DocSubType
    {
        public int DocSubTypeId { get; set; }
        public int DocTypeId { get; set; }
        public string DocSubTypeText { get; set; }

    }
}