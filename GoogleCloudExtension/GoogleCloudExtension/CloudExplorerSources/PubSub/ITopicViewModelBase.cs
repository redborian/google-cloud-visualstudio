// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using GoogleCloudExtension.CloudExplorer;
using System.Threading.Tasks;

namespace GoogleCloudExtension.CloudExplorerSources.PubSub
{
    internal interface ITopicViewModelBase : ICloudExplorerItemSource, ITreeHierarchy
    {
        /// <summary>
        /// The PubsubDataSource to connect to.
        /// </summary>
        IPubsubDataSource DataSource { get; }

        /// <summary>
        /// Returns the context in which this view model is working.
        /// </summary>
        ICloudSourceContext Context { get; }

        /// <summary>
        /// Refreshes the subscriptions of this topic.
        /// </summary>
        Task Refresh();

        /// <summary>
        /// Opens an external browser.
        /// </summary>
        /// <param name="url">
        /// The URL to open the browser to.
        /// </param>
        void OpenBrowser(string url);
    }
}