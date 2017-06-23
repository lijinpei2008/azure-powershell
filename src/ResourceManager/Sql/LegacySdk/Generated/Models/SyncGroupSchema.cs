// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represents the simple schema of sync group.
    /// </summary>
    public partial class SyncGroupSchema
    {
        private string _masterSyncMemberName;
        
        /// <summary>
        /// Optional. The name of master sync member.
        /// </summary>
        public string MasterSyncMemberName
        {
            get { return this._masterSyncMemberName; }
            set { this._masterSyncMemberName = value; }
        }
        
        private IList<SyncGroupSchemaTable> _tables;
        
        /// <summary>
        /// Optional. Table list in database.
        /// </summary>
        public IList<SyncGroupSchemaTable> Tables
        {
            get { return this._tables; }
            set { this._tables = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SyncGroupSchema class.
        /// </summary>
        public SyncGroupSchema()
        {
            this.Tables = new LazyList<SyncGroupSchemaTable>();
        }
    }
}
