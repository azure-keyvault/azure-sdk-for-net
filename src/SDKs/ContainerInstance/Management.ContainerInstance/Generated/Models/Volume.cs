// Code generated by Microsoft (R) AutoRest Code Generator 1.2.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ContainerInstance;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The volume.
    /// </summary>
    public partial class Volume
    {
        /// <summary>
        /// Initializes a new instance of the Volume class.
        /// </summary>
        public Volume()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Volume class.
        /// </summary>
        /// <param name="name">The volume name.</param>
        /// <param name="azureFile">The Azure file volume.</param>
        public Volume(string name, AzureFileVolume azureFile)
        {
            Name = name;
            AzureFile = azureFile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the volume name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Azure file volume.
        /// </summary>
        [JsonProperty(PropertyName = "azureFile")]
        public AzureFileVolume AzureFile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (AzureFile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AzureFile");
            }
            if (AzureFile != null)
            {
                AzureFile.Validate();
            }
        }
    }
}
