// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Contains information about an application in an Azure Batch account.
    /// </summary>
    public partial class ApplicationSummary
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationSummary class.
        /// </summary>
        public ApplicationSummary() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationSummary class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the application
        /// within the account.</param>
        /// <param name="displayName">The display name for the
        /// application.</param>
        /// <param name="versions">The versions of the application which are
        /// available.</param>
        public ApplicationSummary(string id, string displayName, System.Collections.Generic.IList<string> versions)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Versions = versions;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the application
        /// within the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the versions of the application which are available.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "versions")]
        public System.Collections.Generic.IList<string> Versions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }
            if (this.DisplayName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DisplayName");
            }
            if (this.Versions == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Versions");
            }
        }
    }
}
