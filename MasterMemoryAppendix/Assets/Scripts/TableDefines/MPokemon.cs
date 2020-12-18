using System.Collections;
using System.Collections.Generic;
using MasterMemory;
using MessagePack;

/// <summary>
/// MPokemonテーブル
/// </summary>
[MemoryTable("m_pokemon"), MessagePackObject]
public partial class MPokemon
{
    [Key(0)] [PrimaryKey(0)] public long Id { get; private set; }
    [Key(1)] public string DisplayName { get; private set; }
    [Key(2)] public int Hp { get; private set; }
    [Key(3)] public int Attack { get; private set; }
    [Key(4)] public int Defense { get; private set; }
    [Key(5)] public int SpecialAttack { get; private set; }
    [Key(6)] public int SpecialDefence { get; private set; }
    [Key(7)] public int Speed { get; private set; }

    public override string ToString()
    {
        return "Id, DisplayName, Hp, Attack, Defence, SpecialAttack, SpecialDefense, Speed" + "\n" +
               string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", Id, DisplayName, Hp, Attack, Defense,
                   SpecialAttack, SpecialDefence, Speed);
    }

    public MPokemon(long Id, string DisplayName, int Hp, int Attack, int Defense, int SpecialAttack, int SpecialDefence,
        int Speed)
    {
        this.Id = Id;
        this.DisplayName = DisplayName;
        this.Hp = Hp;
        this.Attack = Attack;
        this.Defense = Defense;
        this.SpecialAttack = SpecialAttack;
        this.SpecialDefence = SpecialDefence;
        this.Speed = Speed;
    }
}