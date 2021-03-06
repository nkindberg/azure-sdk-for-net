// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Azure;
    using KeyVault;

    /// <summary>
    /// Defines values for KeyUsageType.
    /// </summary>
    public static class KeyUsageType
    {
        public const string DigitalSignature = "digitalSignature";
        public const string NonRepudiation = "nonRepudiation";
        public const string KeyEncipherment = "keyEncipherment";
        public const string DataEncipherment = "dataEncipherment";
        public const string KeyAgreement = "keyAgreement";
        public const string KeyCertSign = "keyCertSign";
        public const string CRLSign = "cRLSign";
        public const string EncipherOnly = "encipherOnly";
        public const string DecipherOnly = "decipherOnly";
    }
}

