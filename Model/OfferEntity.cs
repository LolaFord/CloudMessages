using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace CloudMessagesSample.Model
{
    /// <summary>
    /// Define an Offer entity for demonstrating the Table Service. For the purposes of the sample we use the 
    /// CIF key as the row key and channel as the partition key. In reality this would not be a good
    /// PK and RK combination as it would likely not be gauranteed to be unique which is one of the requirements for an entity. 
    /// <summary>
    public class OfferEntity:TableEntity
    {
        // Your entity type must expose a parameter-less constructor
        public OfferEntity() { }

        // Define the PK and RK
        public OfferEntity(string Channel, string CifKey)
        {
            this.PartitionKey = Channel;
            this.RowKey = CifKey;
        }

        //For any property that should be stored in the table service, the property must be a public property of a supported type that exposes both get and set.        
        public int Active { get; set; }
        public int Priority { get; set; }
        public long OfferId { get; set; }
        public int Repeat { get; set; }
        public string Message { get; set; }
    }
}
