using System;
using System.Collections.Generic;
using System.Text;

namespace MaraCrawlerNet
{
    public class ResultClass
    {
        public string ID { get; set; }
        public int value { get; set; }
    }

    public class ShortResult
    {
        public string MARN { get; set; }
        public string Salutation { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Role { get; set; }
        public string Classfication { get; set; }
        public string Type { get; set; }
        public string EntityName { get; set; }
        public string BusinessName { get; set; }
        public string ABN { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Email1 { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string IsNoFee { get; set; }
        public int Secondary { get; set; }
        public string SanctionDate { get; set; }
        public string CeaseDate { get; set; }


    }
}
