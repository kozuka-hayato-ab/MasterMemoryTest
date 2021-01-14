using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MessagePack;
using MessagePack.Resolvers;
using Generated;

public class MasterTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MasterDownloader.DownloadMasterData();
        MPokemon temp = MasterDownloader.DB.MPokemonTable.FindByDisplayName("フシギダネ");
        Debug.Log(temp.ToString());
    }
}