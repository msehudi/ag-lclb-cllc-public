// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of adoxio_applicationcrsbpfv4
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.adoxio_applicationcrsbpfv4Collection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMadoxioApplicationcrsbpfv4Collection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationcrsbpfv4Collection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationcrsbpfv4Collection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationcrsbpfv4Collection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationcrsbpfv4Collection(IList<MicrosoftDynamicsCRMadoxioApplicationcrsbpfv4> value = default(IList<MicrosoftDynamicsCRMadoxioApplicationcrsbpfv4>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationcrsbpfv4> Value { get; set; }

    }
}
