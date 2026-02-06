// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests;

public class SpannerBatchWriteCommandTests
{
    [Fact]
    public void Add_ValidCommands()
    {
        var connection = new SpannerConnection();
        var command = connection.CreateBatchWriteCommand();

        var cmd1 = connection.CreateInsertCommand("table", new SpannerParameterCollection { { "col", SpannerDbType.String, "val" } });
        var cmd2 = connection.CreateUpdateCommand("table", new SpannerParameterCollection { { "col", SpannerDbType.String, "val" } });

        command.Add(cmd1, cmd2);

        Assert.Single(command.CommandGroups);
        Assert.Equal(2, command.CommandGroups[0].Commands.Count);
        Assert.Same(cmd1, command.CommandGroups[0].Commands[0]);
        Assert.Same(cmd2, command.CommandGroups[0].Commands[1]);
    }

    [Fact]
    public void Add_SeveralGroups()
    {
        var connection = new SpannerConnection();
        var command = connection.CreateBatchWriteCommand();

        command.Add(connection.CreateInsertCommand("table"));
        command.Add(connection.CreateUpdateCommand("table"));

        Assert.Equal(2, command.CommandGroups.Count);
    }

    [Fact]
    public void Add_UnsupportedCommandType_Throws()
    {
        var connection = new SpannerConnection();
        var command = connection.CreateBatchWriteCommand();
        var selectCommand = connection.CreateSelectCommand("SELECT 1");

        Assert.Throws<InvalidOperationException>(() => command.Add(selectCommand));
    }

    [Fact]
    public void Add_NullCommand_Throws()
    {
        var connection = new SpannerConnection();
        var command = connection.CreateBatchWriteCommand();

        Assert.Throws<ArgumentNullException>(() => command.Add((SpannerCommand)null));
    }
}