using System;
using System.Collections.Generic;

namespace OneCloudNet.Models
{
    public class Domain
    {
        public Int32 ID { get; set; }

        public String Name { get; set; }

        public String TechName { get; set; }

        public String State { get; set; }

        public List<DomainRecord> LinkedRecords { get; set; } 
    }
}