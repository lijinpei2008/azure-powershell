// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Type of storage.</summary>
    public partial struct AzureStorageType :
        System.IEquatable<AzureStorageType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType AzureBlob = @"AzureBlob";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType AzureFiles = @"AzureFiles";

        /// <summary>the value for an instance of the <see cref="AzureStorageType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AzureStorageType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AzureStorageType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AzureStorageType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AzureStorageType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AzureStorageType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AzureStorageType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AzureStorageType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AzureStorageType && Equals((AzureStorageType)obj);
        }

        /// <summary>Returns hashCode for enum AzureStorageType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AzureStorageType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AzureStorageType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AzureStorageType" />.</param>

        public static implicit operator AzureStorageType(string value)
        {
            return new AzureStorageType(value);
        }

        /// <summary>Implicit operator to convert AzureStorageType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AzureStorageType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AzureStorageType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AzureStorageType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageType e2)
        {
            return e2.Equals(e1);
        }
    }
}