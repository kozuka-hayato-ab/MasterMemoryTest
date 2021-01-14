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
   public sealed class ImmutableBuilder : ImmutableBuilderBase
   {
        MemoryDatabase memory;

        public ImmutableBuilder(MemoryDatabase memory)
        {
            this.memory = memory;
        }

        public MemoryDatabase Build()
        {
            return memory;
        }

        public void ReplaceAll(System.Collections.Generic.IList<MPokemon> data)
        {
            var newData = CloneAndSortBy(data, x => x.DisplayName, System.StringComparer.Ordinal);
            var table = new MPokemonTable(newData);
            memory = new MemoryDatabase(
                table
            
            );
        }

        public void RemoveMPokemon(string[] keys)
        {
            var data = RemoveCore(memory.MPokemonTable.GetRawDataUnsafe(), keys, x => x.DisplayName, System.StringComparer.Ordinal);
            var newData = CloneAndSortBy(data, x => x.DisplayName, System.StringComparer.Ordinal);
            var table = new MPokemonTable(newData);
            memory = new MemoryDatabase(
                table
            
            );
        }

        public void Diff(MPokemon[] addOrReplaceData)
        {
            var data = DiffCore(memory.MPokemonTable.GetRawDataUnsafe(), addOrReplaceData, x => x.DisplayName, System.StringComparer.Ordinal);
            var newData = CloneAndSortBy(data, x => x.DisplayName, System.StringComparer.Ordinal);
            var table = new MPokemonTable(newData);
            memory = new MemoryDatabase(
                table
            
            );
        }

    }
}