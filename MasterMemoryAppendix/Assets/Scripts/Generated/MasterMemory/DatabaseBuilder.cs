// <auto-generated />
#pragma warning disable CS0105
using MasterMemory;
using MasterMemory.Validation;
using MessagePack;
using System;
using System.Collections;
using System.Collections.Generic;
using Generated.Tables;

namespace Generated
{
   public sealed class DatabaseBuilder : DatabaseBuilderBase
   {
        public DatabaseBuilder() : this(null) { }
        public DatabaseBuilder(MessagePack.IFormatterResolver resolver) : base(resolver) { }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<MPokemon> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<long>.Default);
            return this;
        }

    }
}