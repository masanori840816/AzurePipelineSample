using System;

namespace AzurePipelineSample.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}