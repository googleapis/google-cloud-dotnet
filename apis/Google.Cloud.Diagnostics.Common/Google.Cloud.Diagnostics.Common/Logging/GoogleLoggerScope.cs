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
    public abstract class GoogleLoggerScope : IDisposable
    {
        private static readonly AsyncLocal<GoogleLoggerScope> _current = new AsyncLocal<GoogleLoggerScope>();

        /// <summary>
        /// The current scope, may be null.
        /// </summary>
        public static GoogleLoggerScope Current
        {
            get
            {
                return _current.Value;
            }
            private set
            {
                _current.Value = value;
            }
        }

        /// <summary>
        /// Creates a new scope with the given state and <see cref="Current"/> as parent.
        /// Sets the newly created scope as <see cref="Current"/>.
        /// </summary>
        /// <param name="state"></param>
        public static GoogleLoggerScope BeginScope(object state) =>
            Current = state switch
            {
                IEnumerable<KeyValuePair<string, object>> keyValues => new KeyValueLoggerScope(keyValues, Current),
                _ => new GoogleLoggerScope<object>(state, Current)
            };

        /// <summary>
        /// The parent scope, may be null.
        /// </summary>
        protected internal GoogleLoggerScope Parent { get; }

        /// <summary>
        /// Creates a new scope.
        /// </summary>
        protected internal GoogleLoggerScope(GoogleLoggerScope parent)
            => Parent = parent;

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
            // we pop it and all it's child scopes.
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
        public void ApplyFullScopeStack(LogEntry entry)
        {
            GaxPreconditions.CheckNotNull(entry, nameof(entry));
            GaxPreconditions.CheckNotNull(entry.JsonPayload, nameof(entry.JsonPayload));
            ApplyFullScopeStackImpl(entry);
        }

        private void ApplyFullScopeStackImpl(LogEntry entry)
        {
            Parent?.ApplyFullScopeStackImpl(entry);
            ApplyThisScope(entry);
        }

        /// <summary>
        /// Apply this scope's information only.
        /// Implementers should decide whether to overwirte similar information from
        /// previous scopes or combine it with this one.
        /// </summary>
        protected internal abstract void ApplyThisScope(LogEntry entry);
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
        protected internal override void ApplyThisScope(LogEntry entry)
        {
            string stateText = State.ToString() ?? "";
            if (entry.JsonPayload.Fields.TryGetValue("scope", out Value value))
            {
                value = Value.ForString($"{value.StringValue} => {stateText}");
            }
            else
            {
                value = Value.ForString(stateText);
            }

            entry.JsonPayload.Fields["scope"] = value;
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
        /// This method first calls <see cref="GoogleLoggerScope{TState}.ApplyThisScope(LogEntry)"/>.
        /// Then, if <see cref="GoogleLoggerScope{TState}.State"/> contains elements it will create
        /// a <see cref="Struct"/> adding each key value pair to <see cref="Struct.Fields"/>.
        /// This <see cref="Struct"/> will be added to the <see cref="LogEntry.JsonPayload"/> on a list field
        /// named <code>parent_scopes</code>.
        /// </remarks>
        protected internal override void ApplyThisScope(LogEntry entry)
        {
            base.ApplyThisScope(entry);

            if (!(State.ToStructValue() is Value newValue))
            {
                return;
            }

            if (entry.JsonPayload.Fields.TryGetValue("parent_scopes", out Value existingValues))
            {
                existingValues.ListValue.Values.Insert(0, newValue);
            }
            else
            {
                entry.JsonPayload.Fields["parent_scopes"] = Value.ForList(newValue);
            }
        }
    }
}
