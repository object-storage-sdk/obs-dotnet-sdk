﻿/*----------------------------------------------------------------------------------
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License.  You may obtain a copy of the
// License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations under the License.
//----------------------------------------------------------------------------------*/
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace OBS.Model
{
    /// <summary>
    /// Expiration details of an object
    /// </summary>
    public class ExpirationDetail
    {

        /// <summary>
        /// Expiration time
        /// </summary>
        public DateTime? ExpiryDate
        {
            get;
            set;
        }

        /// <summary>
        /// ID
        /// </summary>
        public string RuleId
        {
            get;
            set;
        }
    }
}


