using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureTraining.Models
{
    public class freepass
    {
        public string id { get; set; }
        public string code { get; set; }

        public freepass(string id, string code)
        {
            this.id = id;
            this.code = code;
        }
    }
}