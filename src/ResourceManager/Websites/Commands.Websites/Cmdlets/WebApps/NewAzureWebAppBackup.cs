﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Commands.WebApps.Models;
using Microsoft.Azure.Commands.WebApps.Models.WebApp;
using Microsoft.Azure.Management.WebSites.Models;

namespace Microsoft.Azure.Commands.WebApps.Cmdlets.WebApps
{
    /// <summary>
    /// Creates a backup of an Azure Web App
    /// </summary>
    [Cmdlet(VerbsCommon.New, "AzureWebAppBackup")]
    public class NewAzureWebAppBackup : WebAppBaseClientCmdLet
    {
        [Parameter(Position = 0, Mandatory = true, HelpMessage = "The name of the resource group.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Position = 1, Mandatory = true, HelpMessage = "The name of the web app.", ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 2, Mandatory = true, HelpMessage = "The SAS URL for the Azure Storage container used to store the backup.")]
        [ValidateNotNullOrEmpty]
        public string StorageAccountUrl;

        [Parameter(Position = 3, Mandatory = false, HelpMessage = "The databases to backup.")]
        public IList<DatabaseBackupSetting> Databases;

        [Parameter(Position = 4, Mandatory = false, HelpMessage = "The name of the web app slot.")]
        public string Slot { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            BackupRequest request = new BackupRequest()
            {
                StorageAccountUrl = this.StorageAccountUrl,
                Databases = this.Databases
            };
            WriteObject(WebsitesClient.BackupSite(ResourceGroupName, Name, Slot, request));
        }
    }
}
