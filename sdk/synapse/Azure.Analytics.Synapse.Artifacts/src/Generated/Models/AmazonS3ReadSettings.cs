// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure data lake store read settings. </summary>
    public partial class AmazonS3ReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of AmazonS3ReadSettings. </summary>
        public AmazonS3ReadSettings()
        {
            Type = "AmazonS3ReadSettings";
        }

        /// <summary> Initializes a new instance of AmazonS3ReadSettings. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="wildcardFolderPath"> AmazonS3 wildcardFolderPath. Type: string (or Expression with resultType string). </param>
        /// <param name="wildcardFileName"> AmazonS3 wildcardFileName. Type: string (or Expression with resultType string). </param>
        /// <param name="prefix"> The prefix filter for the S3 object name. Type: string (or Expression with resultType string). </param>
        /// <param name="enablePartitionDiscovery"> Indicates whether to enable partition discovery. </param>
        /// <param name="modifiedDatetimeStart"> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </param>
        internal AmazonS3ReadSettings(string type, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object recursive, object wildcardFolderPath, object wildcardFileName, object prefix, bool? enablePartitionDiscovery, object modifiedDatetimeStart, object modifiedDatetimeEnd) : base(type, maxConcurrentConnections, additionalProperties)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            Prefix = prefix;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            Type = type ?? "AmazonS3ReadSettings";
        }

        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object Recursive { get; set; }
        /// <summary> AmazonS3 wildcardFolderPath. Type: string (or Expression with resultType string). </summary>
        public object WildcardFolderPath { get; set; }
        /// <summary> AmazonS3 wildcardFileName. Type: string (or Expression with resultType string). </summary>
        public object WildcardFileName { get; set; }
        /// <summary> The prefix filter for the S3 object name. Type: string (or Expression with resultType string). </summary>
        public object Prefix { get; set; }
        /// <summary> Indicates whether to enable partition discovery. </summary>
        public bool? EnablePartitionDiscovery { get; set; }
        /// <summary> The start of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file&apos;s modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeEnd { get; set; }
    }
}
