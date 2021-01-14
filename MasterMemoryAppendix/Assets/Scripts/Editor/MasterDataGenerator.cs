using System.IO;
using MessagePack.Resolvers;
// MasterMemory.Generatorにて生成時にNameSpaceをGeneratedで指定
using Generated;
using MessagePack;
using UnityEditor;
using UnityEngine;

public static class MasterDataGenerator
{
    [MenuItem("MasterMemory/MasterDataGenerator")]
    static void BuildMasterData()
    {
        try
        {
            StaticCompositeResolver.Instance.Register
            (
                new IFormatterResolver[]
                {
                    MasterMemoryResolver.Instance,
                    GeneratedResolver.Instance,
                    StandardResolver.Instance,
                });
            var options = MessagePackSerializerOptions.Standard.WithResolver(StaticCompositeResolver.Instance);
            MessagePackSerializer.DefaultOptions = options;
        }
        catch
        {
        }

        var builder = new DatabaseBuilder();
        builder.Append(new MPokemon[]
        {
            new MPokemon(DisplayName: "フシギダネ", Hp: 45, Attack: 49, Defense: 49, SpecialAttack: 65,
                SpecialDefence: 65, Speed: 45),
            new MPokemon(DisplayName: "リザードン", Hp: 78, Attack: 84, Defense: 78, SpecialAttack: 109,
                SpecialDefence: 85, Speed: 100),
        });

        byte[] data = builder.Build();
        Debug.Log("ConvertToJson : " + MessagePackSerializer.ConvertToJson(data));
        var resourcesDir = $"{Application.dataPath}/Resources";
        Directory.CreateDirectory(resourcesDir);
        var filename = "/master-data.bytes";

        using (var fs = new FileStream(resourcesDir + filename, FileMode.Create))
        {
            fs.Write(data, 0, data.Length);
        }

        Debug.Log($"Write byte[] to: {resourcesDir + filename}");

        AssetDatabase.Refresh();
    }
}