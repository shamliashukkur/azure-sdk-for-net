// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A data flow transformation. </summary>
    public partial class Transformation
    {
        /// <summary> Initializes a new instance of Transformation. </summary>
        /// <param name="name"> Transformation name. </param>
        public Transformation(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of Transformation. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <param name="description"> Transformation description. </param>
        internal Transformation(string name, string description)
        {
            Name = name;
            Description = description;
        }

        /// <summary> Transformation name. </summary>
        public string Name { get; set; }
        /// <summary> Transformation description. </summary>
        public string Description { get; set; }
    }
}