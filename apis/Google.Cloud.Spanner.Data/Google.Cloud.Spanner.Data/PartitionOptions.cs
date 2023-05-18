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
/// An immutable class representing partiton options.
/// `PartitionSizeBytes`, `MaxPartitions`, and `CancellationToken` properties of
/// this class are utilized in the RPC call while generating partition tokens.
/// `DataBoostEnabled` property will be stored in the request property of the
/// <see cref="CommandPartition"/> object and will be used while executing the
/// partition object. If `DataBoostEnabled` is set to true, the request will be
/// executed using Spanner's independent compute resources.
/// </summary>
public sealed class PartitionOptions
{
    /// <summary>
    /// Returns a default instance of <see cref="PartitionOptions"/> with databoost enabled flag set to false;
    /// </summary>
    public static PartitionOptions DefaultWithDataBoostDisabled { get; } = new PartitionOptions(null, null, false);

    /// <summary>
    /// Returns a default instance of <see cref="PartitionOptions"/> with databoost enables flag set to true;
    /// </summary>
    public static PartitionOptions DefaultWithDataBoostEnabled { get; } = new PartitionOptions(null, null, true);

    internal long? PartitionSizeBytes { get; }

    internal long? MaxPartitions { get; }

    internal bool DataBoostEnabled { get; }

    internal CancellationToken CancellationToken { get; }

    /// <summary>
    /// Creates and returns an instance of <see cref="PartitionOptions"/> class.
    /// </summary>
    /// <param name="partitionSizeBytes">
    /// The desired data size for each partition generated.  The default for this
    /// option is currently 1 GiB.  This is only a hint. The actual size of each
    /// partition may be smaller or larger than this size request.
    /// </param>
    /// <param name="maxPartitions">
    /// The desired maximum number of partitions to return.  For example, this may
    /// be set to the number of workers available.  The default for this option
    /// is currently 10,000. The maximum value is currently 200,000.  This is only
    /// a hint.  The actual number of partitions returned may be smaller or larger than
    /// this maximum count request.
    /// </param>
    /// <param name="dataBoostEnabled">
    /// If set to true, the request will be executed using Spanner's independent compute resources.
    /// The default value for this option is false.
    /// </param>
    /// <param name="cancellationToken">An optional token for canceling the call.</param>
    public PartitionOptions(long? partitionSizeBytes, long? maxPartitions, bool? dataBoostEnabled, CancellationToken cancellationToken = default)
    {
        PartitionSizeBytes = partitionSizeBytes;
        MaxPartitions = maxPartitions;
        DataBoostEnabled = dataBoostEnabled ?? false;
        CancellationToken = cancellationToken;
    }
}
