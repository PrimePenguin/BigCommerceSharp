using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BigCommerceSharp.Model
{
    public class OrderRefundResponse
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public List<Refund> Refunds { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "meta")]
        public MetaCollectionFull1 Meta { get; set; }
    }
}
