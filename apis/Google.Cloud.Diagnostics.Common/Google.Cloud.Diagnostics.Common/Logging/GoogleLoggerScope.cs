// Copyright 2021 Google LLC
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

using Google.Api.Gax;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Represents a scope for a Google Logger.
    /// </summary>
    internal abstract class GoogleLoggerScope : IDisposable
    {
        private static readonly AsyncLocal<GoogleLoggerScope> _current = new AsyncLocal<GoogleLoggerScope>();

        /// <summary>
        /// The current scope, may be null.
        /// </summary>
        public static GoogleLoggerScope Current
        {
            get => _current.Value;
            private set => _current.Value = value;
        }

        /// <summary>
        /// Creates a new scope with the given state and <see cref="Current"/> as parent.
        /// Sets the newly created scope as <see cref="Current"/>.
        /// </summary>
        public static GoogleLoggerScope BeginScope(object state) =>
            Current = CreateScope(state, Current);

        /// <summary>
        /// Creates a new scope with the given state and <see cref="Current"/> as parent.
        /// Sets the newly created scope as <see cref="Current"/>.
        /// </summary>
        public static GoogleLoggerScope CreateScope(object state, GoogleLoggerScope parent) =>
            state switch
            {
                LabellingScopeState labels => new LabellingScope(labels, parent),
                IEnumerable<KeyValuePair<string, object>> keyValues => new KeyValueLoggerScope(keyValues, parent),
                _ => new GoogleLoggerScope<object>(state, parent)
            };

        /// <summary>
        /// The parent scope, may be null.
        /// </summary>
        private GoogleLoggerScope Parent { get; }

        /// <summary>
        /// Creates a new scope.
        /// </summary>
        protected internal GoogleLoggerScope(GoogleLoggerScope parent) => Parent = parent;

        /// <summary>
        /// Removes this scope, and all inner scopes, from the scope stack.
        /// </summary>
        public void Dispose()
        {
            var maybeMyself = Current;
            while (maybeMyself != null && maybeMyself != this)
            {
                maybeMyself = maybeMyself.Parent;
            }
            // Only if we've found this instance in the Scope stack
            // we pop it and all its child scopes.
            if (maybeMyself == this)
            {
                Current = Parent;
            }
        }

        /// <summary>
        /// Modifies the log entry adding information for the full scope stack
        /// whose top, or most recently created scope, is <see cref="Current"/>.
        /// Information is added from least recent scope to more recent one, so that
        /// information added by more recent scopes can overwrite information added
        /// by less recent ones.
        /// </summary>
        public void ApplyTo(LogEntry entry)
        {
            GaxPreconditions.CheckNotNull(entry, nameof(entry));
            GaxPreconditions.CheckNotNull(entry.JsonPayload, nameof(entry.JsonPayload));
            ApplyToImp(entry);
        }

        private void ApplyToImp(LogEntry entry)
        {
            Parent?.ApplyToImp(entry);
            ApplyThisScopeOnlyTo(entry);
        }

        /// <summary>
        /// Apply this scope's information only.
        /// Implementers should decide whether to overwrite similar information from
        /// previous scopes or combine it with this one.
        /// </summary>
        protected internal abstract void ApplyThisScopeOnlyTo(LogEntry entry);
    }

    internal class GoogleLoggerScope<TState> : GoogleLoggerScope
    {
        /// <summary>The state associated with the this scope.</summary>
        public TState State { get; }

        public GoogleLoggerScope(TState state, GoogleLoggerScope parent)
            : base(parent)
        {
            GaxPreconditions.CheckNotNull((object)state, nameof(state));
            State = state;
        }

        /// <summary>
        /// Applies the information contained in <see cref="State"/> to the log entry.
        /// </summary>
        /// <remarks>
        /// <see cref="object.ToString()"/> is called on <see cref="State"/> and it's added
        /// to the <see cref="LogEntry.JsonPayload"/> in a field named <code>scope</code>.
        /// This method will combine existing information so that the <code>scope</code>
        /// field looks like "grandparentScope => parentScope => childScope".
        /// </remarks>
        protected internal override void ApplyThisScopeOnlyTo(LogEntry entry)
        {
            string stateText = State.ToString() ?? "";
            string effectiveText = entry.JsonPayload.Fields.TryGetValue("scope", out Value value)
                ? value.KindCase == Value.KindOneofCase.StringValue
                    ? $"{value.StringValue} => {stateText}"
                    : throw new InvalidOperationException(
                        $"scope field in {nameof(entry.JsonPayload)} is expected to be a {nameof(Value.KindOneofCase.StringValue)} or unset. Found a {value.KindCase} instead.")
                : stateText;
            entry.JsonPayload.Fields["scope"] = Value.ForString(effectiveText);
        }
    }

    internal class KeyValueLoggerScope : GoogleLoggerScope<IEnumerable<KeyValuePair<string, object>>>
    {
        public KeyValueLoggerScope(IEnumerable<KeyValuePair<string, object>> state, GoogleLoggerScope parent)
            : base(state, parent)
        { }

        /// <summary>
        /// Applies the information contained in <see cref="GoogleLoggerScope{TState}.State"/> to the log entry.
        /// </summary>
        /// <remarks>
        /// This method first calls <see cref="GoogleLoggerScope{TState}.ApplyThisScopeOnlyTo(LogEntry)"/>.
        /// Then, if <see cref="GoogleLoggerScope{TState}.State"/> contains elements it will create
        /// a <see cref="Struct"/> adding each key value pair to <see cref="Struct.Fields"/>.
        /// This <see cref="Struct"/> will be added to the <see cref="LogEntry.JsonPayload"/> on a list field
        /// named <code>parent_scopes</code>.
        /// </remarks>
        protected internal override void ApplyThisScopeOnlyTo(LogEntry entry)
        {
            base.ApplyThisScopeOnlyTo(entry);

            if (!(State.ToStructValue() is Value newValue))
            {
                return;
            }

            if (entry.JsonPayload.Fields.TryGetValue("parent_scopes", out Value existingValues))
            {
                if (existingValues.KindCase == Value.KindOneofCase.ListValue)
                {
                    existingValues.ListValue.Values.Insert(0, newValue);
                }
                else
                {
                    throw new InvalidOperationException(
                        $"parent_scopes field in {nameof(entry.JsonPayload)} is expected to be a {nameof(Value.KindOneofCase.ListValue)} or unset. Found a {existingValues.KindCase} instead.");
                }
            }
            else
            {
                entry.JsonPayload.Fields["parent_scopes"] = Value.ForList(newValue);
            }
        }
    }
}
