// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Internal
{
    [SpacetimeDB.Type]
    [DataContract]
    public sealed partial class Typespace
    {
        [DataMember(Name = "types")]
        public System.Collections.Generic.List<SpacetimeDB.BSATN.AlgebraicType> Types;

        public Typespace(System.Collections.Generic.List<SpacetimeDB.BSATN.AlgebraicType> Types)
        {
            this.Types = Types;
        }

        public Typespace()
        {
            this.Types = new();
        }
    }
}
