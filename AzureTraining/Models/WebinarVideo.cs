using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureTraining.Models
{
    public class WebinarVideo
    {
        public string name { get; set; }
        public string url { get; set; }
        public string desc { get; set; }

        public WebinarVideo(string name, string url, string desc)
        {
            this.name = name;
            this.url = url;
            this.desc = desc;
        }
    }
}