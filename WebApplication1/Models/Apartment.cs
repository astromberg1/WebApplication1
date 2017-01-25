using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
    {


        public class Apartment
        {

        public Guid ID { get; set; }

        public  string omrade { get; set; }

        public string Gatuadress { get; set; }


        public int byggar { get; set; }

        public string storlek { get; set; }

        public decimal ytakvm { get; set; }

        public string vaning { get; set; }

        public int Hyra_per_man { get; set; }

        public bool hiss_finns { get; set; }

        public DateTime tilltrade { get; set; }

        public DateTime skapad { get; set; }

        public DateTime uppdaterad { get; set; }

        public string upplagdav { get; set; }

        public Apartment()
            {
            this.ID = Guid.NewGuid();

            }

        }


    }