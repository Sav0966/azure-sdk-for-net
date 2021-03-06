// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base class for output.
    /// </summary>
    public partial class Format
    {
        /// <summary>
        /// Initializes a new instance of the Format class.
        /// </summary>
        public Format()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Format class.
        /// </summary>
        /// <param name="filenamePattern">The pattern of the file names for the
        /// generated output files. The following macros are supported in the
        /// file name: {Basename} - The base name of the input video
        /// {Extension} - The appropriate extension for this format. {Label} -
        /// The label assigned to the codec/layer. {Index} - A unique index for
        /// thumbnails. Only applicable to thumbnails. {Bitrate} - The
        /// audio/video bitrate. Not applicable to thumbnails. {Codec} - The
        /// type of the audio/video codec. Any unsubstituted macros will be
        /// collapsed and removed from the filename.</param>
        public Format(string filenamePattern = default(string))
        {
            FilenamePattern = filenamePattern;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the pattern of the file names for the generated output
        /// files. The following macros are supported in the file name:
        /// {Basename} - The base name of the input video {Extension} - The
        /// appropriate extension for this format. {Label} - The label assigned
        /// to the codec/layer. {Index} - A unique index for thumbnails. Only
        /// applicable to thumbnails. {Bitrate} - The audio/video bitrate. Not
        /// applicable to thumbnails. {Codec} - The type of the audio/video
        /// codec. Any unsubstituted macros will be collapsed and removed from
        /// the filename.
        /// </summary>
        [JsonProperty(PropertyName = "filenamePattern")]
        public string FilenamePattern { get; set; }

    }
}
