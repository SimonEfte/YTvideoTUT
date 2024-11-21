using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperMute : MonoBehaviour
{
    public static int flipperMute1 = 0;
    public static int flipperMute2 = 0;
    public static int flipperMute3 = 0;
    public static int flipperMute4 = 0;
    public static int flipperMute5 = 0;
    public static int flipperMute6 = 0;
    public static int flipperMute7 = 0;
    public static int flipperMute8 = 0;
    public static int flipperMute9 = 0;
    public static int flipperMute10 = 0;
    public static int flipperMute11 = 0;
    public static int flipperMute12 = 0;
    public static int flipperMute13 = 0;
    public static int flipperMute14 = 0;
    public static int flipperMute15 = 0;
    public static int flipperMute16 = 0;
    public static int flipperMute17 = 0;
    public static int flipperMute18 = 0;
    public static int flipperMute19 = 0;
    public static int flipperMute20 = 0;
    public static int flipperMute21 = 0;

    public GameObject muteflipper1;
    public GameObject unMuteFlippeR1;
    public GameObject muteflipper2;
    public GameObject unMuteFlippeR2;
    public GameObject muteflipper3;
    public GameObject unMuteFlippeR3;
    public GameObject muteflipper4;
    public GameObject unMuteFlippeR4;
    public GameObject muteflipper5;
    public GameObject unMuteFlippeR5;
    public GameObject muteflipper6;
    public GameObject unMuteFlippeR6;
    public GameObject muteflipper7;
    public GameObject unMuteFlippeR7;
    public GameObject muteflipper8;
    public GameObject unMuteFlippeR8;
    public GameObject muteflipper9;
    public GameObject unMuteFlippeR9;
    public GameObject muteflipper10;
    public GameObject unMuteFlippeR10;
    public GameObject muteflipper11;
    public GameObject unMuteFlippeR11;
    public GameObject muteflipper12;
    public GameObject unMuteFlippeR12;
    public GameObject muteflipper13;
    public GameObject unMuteFlippeR13;
    public GameObject muteflipper14;
    public GameObject unMuteFlippeR14;
    public GameObject muteflipper15;
    public GameObject unMuteFlippeR15;
    public GameObject muteflipper16;
    public GameObject unMuteFlippeR16;
    public GameObject muteflipper17;
    public GameObject unMuteFlippeR17;
    public GameObject muteflipper18;
    public GameObject unMuteFlippeR18;
    public GameObject muteflipper19;
    public GameObject unMuteFlippeR19;
    public GameObject muteflipper20;
    public GameObject unMuteFlippeR20;
    public GameObject muteflipper21;
    public GameObject unMuteFlippeR21;
    private void Start()
    {
        flipperMute1 = PlayerPrefs.GetInt("FlipperMute1");
        flipperMute2 = PlayerPrefs.GetInt("FlipperMute2");
        flipperMute3 = PlayerPrefs.GetInt("FlipperMute3");
        flipperMute4 = PlayerPrefs.GetInt("FlipperMute4");
        flipperMute5 = PlayerPrefs.GetInt("FlipperMute5");
        flipperMute6 = PlayerPrefs.GetInt("FlipperMute6");
        flipperMute7 = PlayerPrefs.GetInt("FlipperMute7");
        flipperMute8 = PlayerPrefs.GetInt("FlipperMute8");
        flipperMute9 = PlayerPrefs.GetInt("FlipperMute9");
        flipperMute10 = PlayerPrefs.GetInt("FlipperMute10");
        flipperMute11 = PlayerPrefs.GetInt("FlipperMute11");
        flipperMute12 = PlayerPrefs.GetInt("FlipperMute12");
        flipperMute13 = PlayerPrefs.GetInt("FlipperMute13");
        flipperMute14 = PlayerPrefs.GetInt("FlipperMute14");
        flipperMute15 = PlayerPrefs.GetInt("FlipperMute15");
        flipperMute16 = PlayerPrefs.GetInt("FlipperMute16");
        flipperMute17 = PlayerPrefs.GetInt("FlipperMute17");
        flipperMute18 = PlayerPrefs.GetInt("FlipperMute18");
        flipperMute19 = PlayerPrefs.GetInt("FlipperMute19");
        flipperMute20 = PlayerPrefs.GetInt("FlipperMute20");
        flipperMute21 = PlayerPrefs.GetInt("FlipperMute21");

        FlipperMuteAllCheck();
    }

    public void FlipperMuteAllCheck()
    {
        if (flipperMute1 == 1) { unMuteFlippeR1.SetActive(true); muteflipper1.SetActive(false); }
        if (flipperMute1 == 0) { muteflipper1.SetActive(true); unMuteFlippeR1.SetActive(false); }

        if (flipperMute2 == 1) { unMuteFlippeR2.SetActive(true); muteflipper2.SetActive(false); }
        if (flipperMute2 == 0) { muteflipper2.SetActive(true); unMuteFlippeR2.SetActive(false); }

        if (flipperMute3 == 1) { unMuteFlippeR3.SetActive(true); muteflipper3.SetActive(false); }
        if (flipperMute3 == 0) { muteflipper3.SetActive(true); unMuteFlippeR3.SetActive(false); }

        if (flipperMute4 == 1) { unMuteFlippeR4.SetActive(true); muteflipper4.SetActive(false); }
        if (flipperMute4 == 0) { muteflipper4.SetActive(true); unMuteFlippeR4.SetActive(false); }

        if (flipperMute5 == 1) { unMuteFlippeR5.SetActive(true); muteflipper5.SetActive(false); }
        if (flipperMute5 == 0) { muteflipper5.SetActive(true); unMuteFlippeR5.SetActive(false); }

        if (flipperMute6 == 1) { unMuteFlippeR6.SetActive(true); muteflipper6.SetActive(false); }
        if (flipperMute6 == 0) { muteflipper6.SetActive(true); unMuteFlippeR6.SetActive(false); }

        if (flipperMute7 == 1) { unMuteFlippeR7.SetActive(true); muteflipper7.SetActive(false); }
        if (flipperMute7 == 0) { muteflipper7.SetActive(true); unMuteFlippeR7.SetActive(false); }

        if (flipperMute8 == 1) { unMuteFlippeR8.SetActive(true); muteflipper8.SetActive(false); }
        if (flipperMute8 == 0) { muteflipper8.SetActive(true); unMuteFlippeR8.SetActive(false); }

        if (flipperMute9 == 1) { unMuteFlippeR9.SetActive(true); muteflipper9.SetActive(false); }
        if (flipperMute9 == 0) { muteflipper9.SetActive(true); unMuteFlippeR9.SetActive(false); }

        if (flipperMute10 == 1) { unMuteFlippeR10.SetActive(true); muteflipper10.SetActive(false); }
        if (flipperMute10 == 0) { muteflipper10.SetActive(true); unMuteFlippeR10.SetActive(false); }

        if (flipperMute11 == 1) { unMuteFlippeR11.SetActive(true); muteflipper11.SetActive(false); }
        if (flipperMute11 == 0) { muteflipper11.SetActive(true); unMuteFlippeR11.SetActive(false); }

        if (flipperMute12 == 1) { unMuteFlippeR12.SetActive(true); muteflipper12.SetActive(false); }
        if (flipperMute12 == 0) { muteflipper12.SetActive(true); unMuteFlippeR12.SetActive(false); }

        if (flipperMute13 == 1) { unMuteFlippeR13.SetActive(true); muteflipper13.SetActive(false); }
        if (flipperMute13 == 0) { muteflipper13.SetActive(true); unMuteFlippeR13.SetActive(false); }

        if (flipperMute14 == 1) { unMuteFlippeR14.SetActive(true); muteflipper14.SetActive(false); }
        if (flipperMute14 == 0) { muteflipper14.SetActive(true); unMuteFlippeR14.SetActive(false); }

        if (flipperMute15 == 1) { unMuteFlippeR15.SetActive(true); muteflipper15.SetActive(false); }
        if (flipperMute15 == 0) { muteflipper15.SetActive(true); unMuteFlippeR15.SetActive(false); }

        if (flipperMute16 == 1) { unMuteFlippeR16.SetActive(true); muteflipper16.SetActive(false); }
        if (flipperMute16 == 0) { muteflipper16.SetActive(true); unMuteFlippeR16.SetActive(false); }

        if (flipperMute17 == 1) { unMuteFlippeR17.SetActive(true); muteflipper17.SetActive(false); }
        if (flipperMute17 == 0) { muteflipper17.SetActive(true); unMuteFlippeR17.SetActive(false); }

        if (flipperMute18 == 1) { unMuteFlippeR18.SetActive(true); muteflipper18.SetActive(false); }
        if (flipperMute18 == 0) { muteflipper18.SetActive(true); unMuteFlippeR18.SetActive(false); }

        if (flipperMute19 == 1) { unMuteFlippeR19.SetActive(true); muteflipper19.SetActive(false); }
        if (flipperMute19 == 0) { muteflipper19.SetActive(true); unMuteFlippeR19.SetActive(false); }

        if (flipperMute20 == 1) { unMuteFlippeR20.SetActive(true); muteflipper20.SetActive(false); }
        if (flipperMute20 == 0) { muteflipper20.SetActive(true); unMuteFlippeR20.SetActive(false); }

        if (flipperMute21 == 1) { unMuteFlippeR21.SetActive(true); muteflipper21.SetActive(false); }
        if (flipperMute21 == 0) { muteflipper21.SetActive(true); unMuteFlippeR21.SetActive(false); }
    }

    public void mute1()
    {
        muteflipper1.SetActive(false);
        unMuteFlippeR1.SetActive(true);
        flipperMute1 = 1;
        PlayerPrefs.SetInt("FlipperMute1", flipperMute1);
    }
    public void unMute1()
    {
        muteflipper1.SetActive(true);
        unMuteFlippeR1.SetActive(false);
        flipperMute1 = 0;
        PlayerPrefs.SetInt("FlipperMute1", flipperMute1);
    }

    public void mute2()
    {
        muteflipper2.SetActive(false);
        unMuteFlippeR2.SetActive(true);
        flipperMute2 = 1;
        PlayerPrefs.SetInt("FlipperMute2", flipperMute2);
    }
    public void unMute2()
    {
        muteflipper2.SetActive(true);
        unMuteFlippeR2.SetActive(false);
        flipperMute2 = 0;
        PlayerPrefs.SetInt("FlipperMute2", flipperMute2);
    }

    public void mute3()
    {
        muteflipper3.SetActive(false);
        unMuteFlippeR3.SetActive(true);
        flipperMute3 = 1;
        PlayerPrefs.SetInt("FlipperMute3", flipperMute3);
    }
    public void unMute3()
    {
        muteflipper3.SetActive(true);
        unMuteFlippeR3.SetActive(false);
        flipperMute3 = 0;
        PlayerPrefs.SetInt("FlipperMute3", flipperMute3);
    }

    public void mute4()
    {
        muteflipper4.SetActive(false);
        unMuteFlippeR4.SetActive(true);
        flipperMute4 = 1;
        PlayerPrefs.SetInt("FlipperMute4", flipperMute4);
    }
    public void unMute4()
    {
        muteflipper4.SetActive(true);
        unMuteFlippeR4.SetActive(false);
        flipperMute4 = 0;
        PlayerPrefs.SetInt("FlipperMute4", flipperMute4);
    }

    public void mute5()
    {
        muteflipper5.SetActive(false);
        unMuteFlippeR5.SetActive(true);
        flipperMute5 = 1;
        PlayerPrefs.SetInt("FlipperMute5", flipperMute5);
    }
    public void unMute5()
    {
        muteflipper5.SetActive(true);
        unMuteFlippeR5.SetActive(false);
        flipperMute5 = 0;
        PlayerPrefs.SetInt("FlipperMute5", flipperMute5);
    }

    public void mute6()
    {
        muteflipper6.SetActive(false);
        unMuteFlippeR6.SetActive(true);
        flipperMute6 = 1;
        PlayerPrefs.SetInt("FlipperMute6", flipperMute6);
    }
    public void unMute6()
    {
        muteflipper6.SetActive(true);
        unMuteFlippeR6.SetActive(false);
        flipperMute6 = 0;
        PlayerPrefs.SetInt("FlipperMute6", flipperMute6);
    }

    public void mute7()
    {
        muteflipper7.SetActive(false);
        unMuteFlippeR7.SetActive(true);
        flipperMute7 = 1;
        PlayerPrefs.SetInt("FlipperMute7", flipperMute7);
    }
    public void unMute7()
    {
        muteflipper7.SetActive(true);
        unMuteFlippeR7.SetActive(false);
        flipperMute7 = 0;
        PlayerPrefs.SetInt("FlipperMute7", flipperMute7);
    }

    public void mute8()
    {
        muteflipper8.SetActive(false);
        unMuteFlippeR8.SetActive(true);
        flipperMute8 = 1;
        PlayerPrefs.SetInt("FlipperMute8", flipperMute8);
    }
    public void unMute8()
    {
        muteflipper8.SetActive(true);
        unMuteFlippeR8.SetActive(false);
        flipperMute8 = 0;
        PlayerPrefs.SetInt("FlipperMute8", flipperMute8);
    }

    public void mute9()
    {
        muteflipper9.SetActive(false);
        unMuteFlippeR9.SetActive(true);
        flipperMute9 = 1;
        PlayerPrefs.SetInt("FlipperMute9", flipperMute9);
    }
    public void unMute9()
    {
        muteflipper9.SetActive(true);
        unMuteFlippeR9.SetActive(false);
        flipperMute9 = 0;
        PlayerPrefs.SetInt("FlipperMute9", flipperMute9);
    }

    public void mute10()
    {
        muteflipper10.SetActive(false);
        unMuteFlippeR10.SetActive(true);
        flipperMute10 = 1;
        PlayerPrefs.SetInt("FlipperMute10", flipperMute10);
    }
    public void unMute10()
    {
        muteflipper10.SetActive(true);
        unMuteFlippeR10.SetActive(false);
        flipperMute10 = 0;
        PlayerPrefs.SetInt("FlipperMute10", flipperMute10);
    }

    public void mute11()
    {
        muteflipper11.SetActive(false);
        unMuteFlippeR11.SetActive(true);
        flipperMute11 = 1;
        PlayerPrefs.SetInt("FlipperMute11", flipperMute11);
    }
    public void unMute11()
    {
        muteflipper11.SetActive(true);
        unMuteFlippeR11.SetActive(false);
        flipperMute11 = 0;
        PlayerPrefs.SetInt("FlipperMute11", flipperMute11);
    }

    public void mute12()
    {
        muteflipper12.SetActive(false);
        unMuteFlippeR12.SetActive(true);
        flipperMute12 = 1;
        PlayerPrefs.SetInt("FlipperMute12", flipperMute12);
    }
    public void unMute12()
    {
        muteflipper12.SetActive(true);
        unMuteFlippeR12.SetActive(false);
        flipperMute12 = 0;
        PlayerPrefs.SetInt("FlipperMute12", flipperMute12);
    }

    public void mute13()
    {
        muteflipper13.SetActive(false);
        unMuteFlippeR13.SetActive(true);
        flipperMute13 = 1;
        PlayerPrefs.SetInt("FlipperMute13", flipperMute13);
    }
    public void unMute13()
    {
        muteflipper13.SetActive(true);
        unMuteFlippeR13.SetActive(false);
        flipperMute13 = 0;
        PlayerPrefs.SetInt("FlipperMute13", flipperMute13);
    }

    public void mute14()
    {
        muteflipper14.SetActive(false);
        unMuteFlippeR14.SetActive(true);
        flipperMute14 = 1;
        PlayerPrefs.SetInt("FlipperMute14", flipperMute14);
    }
    public void unMute14()
    {
        muteflipper14.SetActive(true);
        unMuteFlippeR14.SetActive(false);
        flipperMute14 = 0;
        PlayerPrefs.SetInt("FlipperMute14", flipperMute14);
    }

    public void mute15()
    {
        muteflipper15.SetActive(false);
        unMuteFlippeR15.SetActive(true);
        flipperMute15 = 1;
        PlayerPrefs.SetInt("FlipperMute15", flipperMute15);
    }
    public void unMute15()
    {
        muteflipper15.SetActive(true);
        unMuteFlippeR15.SetActive(false);
        flipperMute15 = 0;
        PlayerPrefs.SetInt("FlipperMute15", flipperMute15);
    }

    public void mute16()
    {
        muteflipper16.SetActive(false);
        unMuteFlippeR16.SetActive(true);
        flipperMute16 = 1;
        PlayerPrefs.SetInt("FlipperMute16", flipperMute16);
    }
    public void unMute16()
    {
        muteflipper16.SetActive(true);
        unMuteFlippeR16.SetActive(false);
        flipperMute16 = 0;
        PlayerPrefs.SetInt("FlipperMute16", flipperMute16);
    }

    public void mute17()
    {
        muteflipper17.SetActive(false);
        unMuteFlippeR17.SetActive(true);
        flipperMute17 = 1;
        PlayerPrefs.SetInt("FlipperMute17", flipperMute17);
    }
    public void unMute17()
    {
        muteflipper17.SetActive(true);
        unMuteFlippeR17.SetActive(false);
        flipperMute17 = 0;
        PlayerPrefs.SetInt("FlipperMute17", flipperMute17);
    }

    public void mute18()
    {
        muteflipper18.SetActive(false);
        unMuteFlippeR18.SetActive(true);
        flipperMute18 = 1;
        PlayerPrefs.SetInt("FlipperMute18", flipperMute18);
    }
    public void unMute18()
    {
        muteflipper18.SetActive(true);
        unMuteFlippeR18.SetActive(false);
        flipperMute18 = 0;
        PlayerPrefs.SetInt("FlipperMute18", flipperMute18);
    }

    public void mute19()
    {
        muteflipper19.SetActive(false);
        unMuteFlippeR19.SetActive(true);
        flipperMute19 = 1;
        PlayerPrefs.SetInt("FlipperMute19", flipperMute19);
    }
    public void unMute19()
    {
        muteflipper19.SetActive(true);
        unMuteFlippeR19.SetActive(false);
        flipperMute19 = 0;
        PlayerPrefs.SetInt("FlipperMute19", flipperMute19);
    }

    public void mute20()
    {
        muteflipper20.SetActive(false);
        unMuteFlippeR20.SetActive(true);
        flipperMute20 = 1;
        PlayerPrefs.SetInt("FlipperMute20", flipperMute20);
    }
    public void unMute20()
    {
        muteflipper20.SetActive(true);
        unMuteFlippeR20.SetActive(false);
        flipperMute20 = 0;
        PlayerPrefs.SetInt("FlipperMute20", flipperMute20);
    }

    public void mute21()
    {
        muteflipper21.SetActive(false);
        unMuteFlippeR21.SetActive(true);
        flipperMute21 = 1;
        PlayerPrefs.SetInt("FlipperMute21", flipperMute21);
    }
    public void unMute21()
    {
        muteflipper21.SetActive(true);
        unMuteFlippeR21.SetActive(false);
        flipperMute21 = 0;
        PlayerPrefs.SetInt("FlipperMute21", flipperMute21);
    }
}
