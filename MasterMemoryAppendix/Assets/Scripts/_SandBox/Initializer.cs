using Generated;
using MessagePack.Resolvers;
using MessagePack;
using UnityEngine;

public static class Initializer {
    [RuntimeInitializeOnLoadMethod (RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Initialize () {
        StaticCompositeResolver.Instance.Register
        (
            MasterMemoryResolver.Instance,
            GeneratedResolver.Instance,
            StandardResolver.Instance
        );

        var options = MessagePackSerializerOptions.Standard.WithResolver( StaticCompositeResolver.Instance );
        MessagePackSerializer.DefaultOptions = options;
    }
}
