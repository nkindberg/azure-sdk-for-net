// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Reservations;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class SplitRequest
    {
        /// <summary>
        /// Initializes a new instance of the SplitRequest class.
        /// </summary>
        public SplitRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SplitRequest class.
        /// </summary>
        /// <param name="quantities">List of the quantities in the new
        /// reservations to create.</param>
        /// <param name="reservationId">Resource id of the reservation to be
        /// split. Format of the resource id should be
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</param>
        public SplitRequest(IList<int?> quantities = default(IList<int?>), string reservationId = default(string))
        {
            Quantities = quantities;
            ReservationId = reservationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of the quantities in the new reservations to
        /// create.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantities")]
        public IList<int?> Quantities { get; set; }

        /// <summary>
        /// Gets or sets resource id of the reservation to be split. Format of
        /// the resource id should be
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationId")]
        public string ReservationId { get; set; }

    }
}
