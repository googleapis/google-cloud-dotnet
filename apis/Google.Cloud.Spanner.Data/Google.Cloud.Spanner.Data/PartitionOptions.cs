// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using System.Threading;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// An immutable class representing partition options.
/// </summary>
/// <remarks>
/// <para>
/// The specified values of `PartitionSizeBytes` and `MaxPartitions`
/// are utilized in the RPC call while generating the partition tokens.
/// </para>
/// <para>
/// The specified flag for `DataBoostEnabled` will be stored in the request property
/// of the <see cref="CommandPartition"/> object and is used when creating a request
/// to read from the partition. If `DataBoostEnabled` is set to true, the request will be
/// executed using Spanner-independent compute resources.
/// </para>
/// </remarks>
public sealed class PartitionOptions
{
    /// <summary>
    /// Returns a default instance of <see cref="PartitionOptions"/>.
    /// </summary>
    public static PartitionOptions Default { get; } = new PartitionOptions(null, null, false);

    /// <summary>
    /// Returns a new instance with the same options as this one, but with the specified new value for <see cref="DataBoostEnabled" />.
    /// </summary>
    /// <returns>A new instance of <see cref="PartitionOptions"/>.</returns>
    public PartitionOptions WithDataBoostEnabled(bool? dataBoostEnabled) => new(PartitionSizeBytes, MaxPartitions, dataBoostEnabled);

    /// <summary>
    /// Returns a new instance with the same options as this one, but with the specified new value for <see cref="PartitionSizeBytes"/>.
    /// </summary>
    /// <returns>A new instance of <see cref="PartitionOptions"/>.</returns>
    public PartitionOptions WithPartitionSizeBytes(long? partitionSizeBytes) => new(partitionSizeBytes, MaxPartitions, DataBoostEnabled);

    /// <summary>
    /// Returns a new instance with the same options as this one, but with the specified new value for <see cref="MaxPartitions"/>.
    /// </summary>
    /// <returns>A new instance of <see cref="PartitionOptions"/>.</returns>
    public PartitionOptions WithMaxPartitions(long? maxPartitions) => new(PartitionSizeBytes, maxPartitions, DataBoostEnabled);

    /// <summary>
    /// The desired data size for each partition generated.
    /// The default value for this is null, in which case the server will decide the data size for each partition generated.
    /// </summary>
    public long? PartitionSizeBytes { get; }

    /// <summary>
    /// The desired maximum number of partitions to return.
    /// The default value for this is null, in which case the server will decide how many partitions to return.
    /// </summary>
    public long? MaxPartitions { get; }

    /// <summary>
    /// If set to true, the request will be executed using Spanner independent compute resources.
    /// The default value for this option is false.
    /// </summary>
    public bool DataBoostEnabled { get; }

    /// <summary>
    /// Creates a new instance of <see cref="PartitionOptions"/> class.
    /// </summary>
    private PartitionOptions(long? partitionSizeBytes, long? maxPartitions, bool? dataBoostEnabled)
    {
        PartitionSizeBytes = partitionSizeBytes;
        MaxPartitions = maxPartitions;
        DataBoostEnabled = dataBoostEnabled ?? false;
    }
}
