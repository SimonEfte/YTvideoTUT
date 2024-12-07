using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialsLinks : MonoBehaviour
{
 
    public void OpenDiscord()
    {
        Application.OpenURL("https://discord.gg/eVBcVJJuBz");
    }

    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/Sniceman");
    }

    public void OpenTwitch()
    {
        Application.OpenURL("https://www.twitch.tv/sniceman");
    }

    public void OpenSteam()
    {
        Application.OpenURL("https://store.steampowered.com/curator/43674917");
    }

    public void OpenGooglePlay()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.eagleeyegames.coinflipper");
    }

    public void OpenAppStore()
    {
        Application.OpenURL("https://apps.apple.com/us/app/coin-flipper-idle-game/id6738841143?platform=iphone");
    }

}
