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

// ReSharper disable UnusedParameter.Local
// ReSharper disable EmptyNamespace

#if NET45 || NET451
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Threading;
using Google.Api.Gax;
#endif

namespace Google.Cloud.Spanner.Data
{
#if NET45 || NET451

    /// <summary>
    /// </summary>
    public sealed class SpannerDataAdapter : DbDataAdapter, IDbDataAdapter
    {
        private SpannerCommand _selectCommand;
        private SpannerCommand _builtInsertCommand;

        /// <summary>
        /// </summary>
        public SpannerDataAdapter()
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <param name="connection"></param>
        public SpannerDataAdapter(string sqlQuery, SpannerConnection connection)
        {
            SpannerConnection = connection;
            SelectCommand = connection.CreateSelectCommand(sqlQuery);
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Configuration")]
        public bool BuildUpdateCommands { get; set; } = true;

        /// <summary>
        /// </summary>
        [Category("Commands")]
        public new SpannerCommand DeleteCommand { get; set; }

        /// <summary>
        /// </summary>
        [Category("Commands")]
        public new SpannerCommand InsertCommand { get; set; }

        /// <summary>
        /// </summary>
        [Category("Commands")]
        public new SpannerCommand SelectCommand
        {
            get
            {
                if (_selectCommand == null && SpannerConnection != null && SelectStatement != null)
                {
                    ClearBuiltCommands();
                    _selectCommand = SpannerConnection.CreateSelectCommand(SelectStatement);
                }
                return _selectCommand;
            }
            set
            {
                ClearBuiltCommands();
                _selectCommand = value;
            }
        }

        /// <summary>
        /// </summary>
        [Category("Commands")]
        public new SpannerCommand UpdateCommand { get; set; }

        [Browsable(false)]
        IDbCommand IDbDataAdapter.DeleteCommand
        {
            get { return DeleteCommand; }
            set { DeleteCommand = (SpannerCommand) value; }
        }

        [Browsable(false)]
        IDbCommand IDbDataAdapter.InsertCommand
        {
            get { return InsertCommand; }
            set { InsertCommand = (SpannerCommand) value; }
        }

        [Browsable(false)]
        IDbCommand IDbDataAdapter.SelectCommand
        {
            get { return SelectCommand; }
            set { SelectCommand = (SpannerCommand) value; }
        }

        [Browsable(false)]
        IDbCommand IDbDataAdapter.UpdateCommand
        {
            get { return UpdateCommand; }
            set { UpdateCommand = (SpannerCommand) value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Configuration")]
        public string SelectStatement
        {
            get { return _selectStatement; }
            set
            {
                _selectCommand = null;
                _selectStatement = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Configuration")]
        public SpannerConnection SpannerConnection { get; set; }

        /// <summary>
        /// </summary>
        public event EventHandler<SpannerRowUpdatedEventArgs> RowUpdated;

        /// <summary>
        /// </summary>
        public event EventHandler<SpannerRowUpdatingEventArgs> RowUpdating;

        /*
         * Implement abstract methods inherited from DbDataAdapter.
         */
        /// <inheritdoc />
        protected override RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command,
            StatementType statementType, DataTableMapping tableMapping)
        {
            return new SpannerRowUpdatedEventArgs(dataRow, command, statementType, tableMapping);
        }

        /// <inheritdoc />
        protected override RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command,
            StatementType statementType, DataTableMapping tableMapping)
        {
            return new SpannerRowUpdatingEventArgs(dataRow, command, statementType, tableMapping);
        }

        /// <inheritdoc />
        protected override void OnRowUpdated(RowUpdatedEventArgs rowUpdatedEventArgs)
        {
            RowUpdated?.Invoke(this, (SpannerRowUpdatedEventArgs) rowUpdatedEventArgs);
        }

        private readonly SpannerParameterCollection _parsedParameterCollection = new SpannerParameterCollection();
        private SpannerCommand _builtUpdateCommand;
        private SpannerCommand _builtDeleteCommand;
        private string _selectStatement;
        private string _updateTable;

        /// <inheritdoc />
        protected override int Fill(DataSet dataSet, string srcTable, IDataReader dataReader, int startRecord, int maxRecords)
        {
            SpannerDataReader spannerDataReader = dataReader as SpannerDataReader;
            if (spannerDataReader != null && BuildUpdateCommands)
            {
                var readerMetadata = spannerDataReader.PopulateMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions();
                foreach (var field in readerMetadata.RowType.Fields)
                {
                    _parsedParameterCollection.Add(
                        new SpannerParameter(field.Name, field.Type.Code.GetSpannerDbType(), field.Name));
                }
            }

            return base.Fill(dataSet, srcTable, dataReader, startRecord, maxRecords);
        }

        private void ClearBuiltCommands()
        {
            _builtInsertCommand = null;
            _builtDeleteCommand = null;
            _builtUpdateCommand = null;
        }

        private SpannerCommand GetBuiltInsertCommand()
        {
            if (_builtInsertCommand != null)
            {
                return _builtInsertCommand;
            }
            if (_parsedParameterCollection != null)
            {
                _builtInsertCommand = SpannerConnection.CreateInsertCommand(UpdateTable, _parsedParameterCollection);
            }
            return _builtInsertCommand;
        }

        private SpannerCommand GetBuiltUpdateCommand()
        {
            if (_builtUpdateCommand != null)
            {
                return _builtUpdateCommand;
            }
            if (_parsedParameterCollection != null)
            {
                _builtUpdateCommand = SpannerConnection.CreateUpdateCommand(UpdateTable, _parsedParameterCollection);
            }
            return _builtUpdateCommand;
        }

        private SpannerCommand GetBuiltDeleteCommand()
        {
            if (_builtDeleteCommand != null)
            {
                return _builtDeleteCommand;
            }
            if (_parsedParameterCollection != null)
            {
                _builtDeleteCommand = SpannerConnection.CreateDeleteCommand(UpdateTable, _parsedParameterCollection);
            }
            return _builtDeleteCommand;
        }

        /// <inheritdoc />
        protected override void OnRowUpdating(RowUpdatingEventArgs rowUpdatingEventArgs)
        {
            if (rowUpdatingEventArgs.Command == null && BuildUpdateCommands)
            {
                //show a friendly exception before this bails later in case
                //the user forgot to set this property.
                if (string.IsNullOrEmpty(UpdateTable))
                {
                    throw new InvalidOperationException("You must set SpannderDataAdapter.UpdateTable to automatically generate update commands.");
                }

                // Note that we auto build the commands as a feature of the *Data adapter* versus a separate class.
                // This is done for two reasons:
                // a) We cannot create a "proper" DbCommandBuilder because DDL is not supported by Spanner.
                //    This means any "SpannerCommandBuilder" would not live up to expectations and be castable
                //    to DbCommandBuilder.
                // b) The code for building these commands is both much simpler than othe providers and also
                //    somewhat more limiting (it only supports simple table updates whereas other command builders
                //    use TSQL or additional sql commands to inspect a query and determine the proper way to update it).
                //    This means that the auto build feature has more limited use, but is still useful for
                //    quickly getting started and achieving full CRUD on a table with only a single SQL Query + table name.
                //    It also means the code for this support is significantly reduced and does not warrant its own class.
                switch (rowUpdatingEventArgs.StatementType)
                {
                    case StatementType.Insert:
                        rowUpdatingEventArgs.Command = GetBuiltInsertCommand();
                        break;
                    case StatementType.Update:
                        rowUpdatingEventArgs.Command = GetBuiltUpdateCommand();
                        break;
                    case StatementType.Delete:
                        rowUpdatingEventArgs.Command = GetBuiltDeleteCommand();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            RowUpdating?.Invoke(this, (SpannerRowUpdatingEventArgs) rowUpdatingEventArgs);
        }

        /// <summary>
        /// 
        /// </summary>
        [Category("Configuration")]
        public string UpdateTable
        {
            get { return _updateTable; }
            set
            {
                ClearBuiltCommands();
                _updateTable = value;
            }
        }
    }
#endif
}