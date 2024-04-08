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
    /// Response to an object deletion request
    /// </summary>
    public class DeleteObjectResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Identifier specifying whether the deleted object is a delete marker
        /// </summary>
        public bool DeleteMarker
        {
            get;
            internal set;
        }

        /// <summary>
        /// Version ID of the to-be-deleted object
        /// </summary>
        public string VersionId
        {
            get;
            internal set;
        }

    }
}
    


