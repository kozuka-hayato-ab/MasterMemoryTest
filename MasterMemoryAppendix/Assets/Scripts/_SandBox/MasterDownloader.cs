using UnityEngine;
using Generated;

// TODO: よしなに変更してください
public class MasterDownloader
{
    private static MemoryDatabase _db;

    public static MemoryDatabase DB => _db;

    public static void DownloadMasterData()
    {
        _db = new MemoryDatabase((Resources.Load("master-data") as TextAsset).bytes);
    }
}