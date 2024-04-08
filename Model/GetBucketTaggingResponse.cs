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
using System.Collections.Generic;


namespace OBS.Model
{
    /// <summary>
    /// Response to a request for obtaining bucket tags
    /// </summary>
    public class GetBucketTaggingResponse : ObsWebServiceResponse
    {

        private IList<Tag> tags;
        /// <summary>
        /// Bucket tag set
        /// </summary>
        public IList<Tag> Tags
        {
            get {
                
                return this.tags ?? (this.tags = new List<Tag>()); }
            internal set { this.tags = value; }
        }

    }
}
    


