// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
    /// </summary>
    public partial struct AccountStatus :
        System.IEquatable<AccountStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccountStatus Available = @"available";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccountStatus Unavailable = @"unavailable";

        /// <summary>the value for an instance of the <see cref="AccountStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AccountStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AccountStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AccountStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AccountStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AccountStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AccountStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccountStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AccountStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AccountStatus && Equals((AccountStatus)obj);
        }

        /// <summary>Returns hashCode for enum AccountStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AccountStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AccountStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AccountStatus" />.</param>

        public static implicit operator AccountStatus(string value)
        {
            return new AccountStatus(value);
        }

        /// <summary>Implicit operator to convert AccountStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AccountStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccountStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AccountStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccountStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccountStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AccountStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccountStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AccountStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}