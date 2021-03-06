﻿// Copyright 2017 Google Inc. All Rights Reserved.
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

using System;
using System.Linq;

namespace GoogleCloudExtension.GcsUtils
{
    /// <summary>
    /// This class represents a reference to an file or directory on GCS.
    /// </summary>
    public class GcsItemRef
    {
        /// <summary>
        /// The bucket that contains this item.
        /// </summary>
        public string Bucket { get; }

        /// <summary>
        /// The name of the item within the bucket.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Wether this item is a directory.
        /// </summary>
        public bool IsDirectory => String.IsNullOrEmpty(Name) || Name.Last() == '/';

        /// <summary>
        /// Returns the full GCS path for the item.
        /// </summary>
        public string FullPath { get; }

        /// <summary>
        /// Whether this item is file.
        /// </summary>
        public bool IsFile => !IsDirectory;

        public GcsItemRef(string bucket, string name)
        {
            Bucket = bucket;
            Name = name;
            FullPath = $"gs://{bucket}/{name}";
        }

        /// <summary>
        /// Returns the string representation of the item.
        /// </summary>
        public override string ToString() => FullPath;
    }
}
