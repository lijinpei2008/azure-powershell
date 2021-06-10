namespace Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Extensions;

    /// <summary>Response of a list operation.</summary>
    public partial class DatadogAgreementResourceListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IDatadogAgreementResourceListResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IDatadogAgreementResourceListResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next set of results, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataDog.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataDog.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IDatadogAgreementResource[] _value;

        /// <summary>Results of a list operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataDog.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataDog.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IDatadogAgreementResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DatadogAgreementResourceListResponse" /> instance.</summary>
        public DatadogAgreementResourceListResponse()
        {

        }
    }
    /// Response of a list operation.
    public partial interface IDatadogAgreementResourceListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.IJsonSerializable
    {
        /// <summary>Link to the next set of results, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the next set of results, if any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Results of a list operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataDog.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Results of a list operation.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IDatadogAgreementResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IDatadogAgreementResource[] Value { get; set; }

    }
    /// Response of a list operation.
    internal partial interface IDatadogAgreementResourceListResponseInternal

    {
        /// <summary>Link to the next set of results, if any.</summary>
        string NextLink { get; set; }
        /// <summary>Results of a list operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataDog.Models.Api20210301.IDatadogAgreementResource[] Value { get; set; }

    }
}