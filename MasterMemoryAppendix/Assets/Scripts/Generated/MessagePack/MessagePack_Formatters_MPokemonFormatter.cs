// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters
{
    using System;
    using System.Buffers;
    using MessagePack;

    public sealed class MPokemonFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::MPokemon>
    {


        public void Serialize(ref MessagePackWriter writer, global::MPokemon value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(8);
            writer.Write(value.Id);
            formatterResolver.GetFormatterWithVerify<string>().Serialize(ref writer, value.DisplayName, options);
            writer.Write(value.Hp);
            writer.Write(value.Attack);
            writer.Write(value.Defense);
            writer.Write(value.SpecialAttack);
            writer.Write(value.SpecialDefence);
            writer.Write(value.Speed);
        }

        public global::MPokemon Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __Id__ = default(long);
            var __DisplayName__ = default(string);
            var __Hp__ = default(int);
            var __Attack__ = default(int);
            var __Defense__ = default(int);
            var __SpecialAttack__ = default(int);
            var __SpecialDefence__ = default(int);
            var __Speed__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var key = i;

                switch (key)
                {
                    case 0:
                        __Id__ = reader.ReadInt64();
                        break;
                    case 1:
                        __DisplayName__ = formatterResolver.GetFormatterWithVerify<string>().Deserialize(ref reader, options);
                        break;
                    case 2:
                        __Hp__ = reader.ReadInt32();
                        break;
                    case 3:
                        __Attack__ = reader.ReadInt32();
                        break;
                    case 4:
                        __Defense__ = reader.ReadInt32();
                        break;
                    case 5:
                        __SpecialAttack__ = reader.ReadInt32();
                        break;
                    case 6:
                        __SpecialDefence__ = reader.ReadInt32();
                        break;
                    case 7:
                        __Speed__ = reader.ReadInt32();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::MPokemon(__Id__, __DisplayName__, __Hp__, __Attack__, __Defense__, __SpecialAttack__, __SpecialDefence__, __Speed__);
            reader.Depth--;
            return ____result;
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name
