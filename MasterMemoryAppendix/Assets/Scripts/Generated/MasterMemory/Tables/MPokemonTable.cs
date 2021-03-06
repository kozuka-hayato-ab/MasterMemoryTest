// <auto-generated />
#pragma warning disable CS0105
using MasterMemory;
using MasterMemory.Validation;
using MessagePack;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Generated.Tables
{
   public sealed partial class MPokemonTable : TableBase<MPokemon>, ITableUniqueValidate
   {
        public Func<MPokemon, long> PrimaryKeySelector => primaryIndexSelector;
        readonly Func<MPokemon, long> primaryIndexSelector;


        public MPokemonTable(MPokemon[] sortedData)
            : base(sortedData)
        {
            this.primaryIndexSelector = x => x.Id;
            OnAfterConstruct();
        }

        partial void OnAfterConstruct();


        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public MPokemon FindById(long key)
        {
            var lo = 0;
            var hi = data.Length - 1;
            while (lo <= hi)
            {
                var mid = (int)(((uint)hi + (uint)lo) >> 1);
                var selected = data[mid].Id;
                var found = (selected < key) ? -1 : (selected > key) ? 1 : 0;
                if (found == 0) { return data[mid]; }
                if (found < 0) { lo = mid + 1; }
                else { hi = mid - 1; }
            }
            return ThrowKeyNotFound(key);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public bool TryFindById(long key, out MPokemon result)
        {
            var lo = 0;
            var hi = data.Length - 1;
            while (lo <= hi)
            {
                var mid = (int)(((uint)hi + (uint)lo) >> 1);
                var selected = data[mid].Id;
                var found = (selected < key) ? -1 : (selected > key) ? 1 : 0;
                if (found == 0) { result = data[mid]; return true; }
                if (found < 0) { lo = mid + 1; }
                else { hi = mid - 1; }
            }
            result = default;
            return false;
        }

        public MPokemon FindClosestById(long key, bool selectLower = true)
        {
            return FindUniqueClosestCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<long>.Default, key, selectLower);
        }

        public RangeView<MPokemon> FindRangeById(long min, long max, bool ascendant = true)
        {
            return FindUniqueRangeCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<long>.Default, min, max, ascendant);
        }


        void ITableUniqueValidate.ValidateUnique(ValidateResult resultSet)
        {
            ValidateUniqueCore(data, primaryIndexSelector, "Id", resultSet);       
        }

        public static MasterMemory.Meta.MetaTable CreateMetaTable()
        {
            return new MasterMemory.Meta.MetaTable(typeof(MPokemon), typeof(MPokemonTable), "m_pokemon",
                new MasterMemory.Meta.MetaProperty[]
                {
                    new MasterMemory.Meta.MetaProperty(typeof(MPokemon).GetProperty("Id")),
                    new MasterMemory.Meta.MetaProperty(typeof(MPokemon).GetProperty("DisplayName")),
                    new MasterMemory.Meta.MetaProperty(typeof(MPokemon).GetProperty("Hp")),
                    new MasterMemory.Meta.MetaProperty(typeof(MPokemon).GetProperty("Attack")),
                    new MasterMemory.Meta.MetaProperty(typeof(MPokemon).GetProperty("Defense")),
                    new MasterMemory.Meta.MetaProperty(typeof(MPokemon).GetProperty("SpecialAttack")),
                    new MasterMemory.Meta.MetaProperty(typeof(MPokemon).GetProperty("SpecialDefence")),
                    new MasterMemory.Meta.MetaProperty(typeof(MPokemon).GetProperty("Speed")),
                },
                new MasterMemory.Meta.MetaIndex[]{
                    new MasterMemory.Meta.MetaIndex(new System.Reflection.PropertyInfo[] {
                        typeof(MPokemon).GetProperty("Id"),
                    }, true, true, System.Collections.Generic.Comparer<long>.Default),
                });
        }

    }
}