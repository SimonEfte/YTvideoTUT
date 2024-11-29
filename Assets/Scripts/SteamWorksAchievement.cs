using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamWorksAchievement : MonoBehaviour
{
    void Start()
    {
        try
        {
            // Steamworks.SteamClient.Init(2153770);
        }
        catch (System.Exception e)
        {

        }
    }


    void Update()
    {
        // Steamworks.SteamClient.RunCallbacks();
    }
    void OnApplicationQuit()
    {
        //  Steamworks.SteamClient.Shutdown();
    }
}
