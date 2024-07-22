// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Health.Deidentification
{
    /// <summary> Result of the "Tag" operation. </summary>
    public partial class PhiTaggerResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PhiTaggerResult"/>. </summary>
        /// <param name="entities"> List of entities detected in the input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entities"/> is null. </exception>
        internal PhiTaggerResult(IEnumerable<PhiEntity> entities)
        {
            Argument.AssertNotNull(entities, nameof(entities));

            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="PhiTaggerResult"/>. </summary>
        /// <param name="entities"> List of entities detected in the input. </param>
        /// <param name="path"> Path to the document in storage. </param>
        /// <param name="etag"> The entity tag for this resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PhiTaggerResult(IReadOnlyList<PhiEntity> entities, string path, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Entities = entities;
            Path = path;
            Etag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PhiTaggerResult"/> for deserialization. </summary>
        internal PhiTaggerResult()
        {
        }

        /// <summary> List of entities detected in the input. </summary>
        public IReadOnlyList<PhiEntity> Entities { get; }
        /// <summary> Path to the document in storage. </summary>
        public string Path { get; }
        /// <summary> The entity tag for this resource. </summary>
        public ETag? Etag { get; }
    }
}
