/*----------------------------------------------------------------------------------
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

namespace OBS.Model
{
    /// <summary>
    /// Response to a request for obtaining object ACLs
    /// </summary>
    public class GetObjectAclResponse : ObsWebServiceResponse
    {
        /// <summary>
        /// List of grantees' permission information
        /// </summary>
        public AccessControlList AccessControlList { get; internal set; }
    }
}
    

