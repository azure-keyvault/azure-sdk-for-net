// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Properties of the certificate.
    /// </summary>
    public partial class CertificateProperties : ResourceCommonPropertiesBase
    {
        private DateTimeOffset _expiryTime;
        
        /// <summary>
        /// Optional. Gets or sets the expiry time of the certificate.
        /// </summary>
        public DateTimeOffset ExpiryTime
        {
            get { return this._expiryTime; }
            set { this._expiryTime = value; }
        }
        
        private bool _isExportable;
        
        /// <summary>
        /// Optional. Gets or sets the is exportable flag of the certificate.
        /// </summary>
        public bool IsExportable
        {
            get { return this._isExportable; }
            set { this._isExportable = value; }
        }
        
        private string _thumbprint;
        
        /// <summary>
        /// Optional. Gets or sets the thumbprint of the certificate.
        /// </summary>
        public string Thumbprint
        {
            get { return this._thumbprint; }
            set { this._thumbprint = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CertificateProperties class.
        /// </summary>
        public CertificateProperties()
        {
        }
    }
}
