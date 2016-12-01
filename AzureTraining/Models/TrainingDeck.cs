using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureTraining.Models
{
    public class TrainingDeck
    {
        public string name { get; set; }
        public string url { get; set; }

        public TrainingDeck(string name, string url)
        {
            this.name = name;
            this.url = url;
        }
    }
}