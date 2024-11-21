using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverOverBackground : MonoBehaviour
{
    public Texture2D cursor1;
    public GameObject muteFlipper1;
    public GameObject muteFlipper2;
    public GameObject muteFlipper3;
    public GameObject muteFlipper4;
    public GameObject muteFlipper5;
    public GameObject muteFlipper6;
    public GameObject muteFlipper7;
    public GameObject muteFlipper8;
    public GameObject muteFlipper9;
    public GameObject muteFlipper10;
    public GameObject muteFlipper11;
    public GameObject muteFlipper12;
    public GameObject muteFlipper13;
    public GameObject muteFlipper14;
    public GameObject muteFlipper15;
    public GameObject muteFlipper16;
    public GameObject muteFlipper17;
    public GameObject muteFlipper18;
    public GameObject muteFlipper19;
    public GameObject muteFlipper20;
    public GameObject muteFlipper21;

    public GameObject specialMuteFlipper1;
    public GameObject specialMuteFlipper2;
    public GameObject specialMuteFlipper3;
    public GameObject specialMuteFlipper4;
    public GameObject specialMuteFlipper5;
    public GameObject specialMuteFlipper6;
    public GameObject specialMuteFlipper7;
    public GameObject specialMuteFlipper8;
    public GameObject specialMuteFlipper9;
    public GameObject specialMuteFlipper10;
    public GameObject specialMuteFlipper11;
    public GameObject specialMuteFlipper12;
    public GameObject specialMuteFlipper13;
    public GameObject specialMuteFlipper14;
    public GameObject specialMuteFlipper15;
    public GameObject specialMuteFlipper16;
    public GameObject specialMuteFlipper17;
    public GameObject specialMuteFlipper18;
    public GameObject specialMuteFlipper19;
    public GameObject specialMuteFlipper20;
    public GameObject specialMuteFlipper21;

    public GameObject hoverOver1;
    public GameObject hoverOver2;
    public GameObject hoverOver3;
    public GameObject hoverOver4;
    public GameObject hoverOver5;
    public GameObject hoverOver6;
    public GameObject hoverOver7;
    public GameObject hoverOver8;
    public GameObject hoverOver9;
    public GameObject hoverOver10;
    public GameObject hoverOver11;
    public GameObject hoverOver12;
    public GameObject hoverOver13;
    public GameObject hoverOver14;
    public GameObject hoverOver15;
    public GameObject hoverOver16;
    public GameObject hoverOverChest;
    public GameObject hoverOverRitual;
    public GameObject hoverOverAuto;
    public GameObject hoverOverFlipAll;
    public GameObject hoverOverEndless;
    public GameObject hoverOverPile;
    public GameObject hoverOverGamble;

    public GameObject autoList;
    public GameObject autoButton;
    public GameObject autoButton2;

    public void OnMouseEnter()
    {
        if (LoadSaves.isMobileBuild == false)
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            muteFlipper1.SetActive(false);
            muteFlipper2.SetActive(false);
            muteFlipper3.SetActive(false);
            muteFlipper4.SetActive(false);
            muteFlipper5.SetActive(false);
            muteFlipper6.SetActive(false);
            muteFlipper7.SetActive(false);
            muteFlipper8.SetActive(false);
            muteFlipper9.SetActive(false);
            muteFlipper10.SetActive(false);
            muteFlipper11.SetActive(false);
            muteFlipper12.SetActive(false);
            muteFlipper13.SetActive(false);
            muteFlipper14.SetActive(false);
            muteFlipper15.SetActive(false);
            muteFlipper16.SetActive(false);
            muteFlipper17.SetActive(false);
            muteFlipper18.SetActive(false);
            muteFlipper19.SetActive(false);
            muteFlipper20.SetActive(false);
            muteFlipper21.SetActive(false);

            specialMuteFlipper1.SetActive(false);
            specialMuteFlipper2.SetActive(false);
            specialMuteFlipper3.SetActive(false);
            specialMuteFlipper4.SetActive(false);
            specialMuteFlipper5.SetActive(false);
            specialMuteFlipper6.SetActive(false);
            specialMuteFlipper7.SetActive(false);
            specialMuteFlipper8.SetActive(false);
            specialMuteFlipper9.SetActive(false);
            specialMuteFlipper10.SetActive(false);
            specialMuteFlipper11.SetActive(false);
            specialMuteFlipper12.SetActive(false);
            specialMuteFlipper13.SetActive(false);
            specialMuteFlipper14.SetActive(false);
            specialMuteFlipper15.SetActive(false);
            specialMuteFlipper16.SetActive(false);
            specialMuteFlipper17.SetActive(false);
            specialMuteFlipper18.SetActive(false);
            specialMuteFlipper19.SetActive(false);
            specialMuteFlipper20.SetActive(false);
            specialMuteFlipper21.SetActive(false);
            hoverOver1.SetActive(false);
            hoverOver2.SetActive(false);
            hoverOver3.SetActive(false);
            hoverOver4.SetActive(false);
            hoverOver5.SetActive(false);
            hoverOver6.SetActive(false);
            hoverOver7.SetActive(false);
            hoverOver8.SetActive(false);
            hoverOver9.SetActive(false);
            hoverOver10.SetActive(false);
            hoverOver11.SetActive(false);
            hoverOver12.SetActive(false);
            hoverOver13.SetActive(false);
            hoverOver14.SetActive(false);
            hoverOver15.SetActive(false);
            hoverOver16.SetActive(false);

            hoverOverChest.SetActive(false);
            hoverOverPile.SetActive(false);
            hoverOverAuto.SetActive(false);
            hoverOverFlipAll.SetActive(false);
            hoverOverEndless.SetActive(false);
            hoverOverPile.SetActive(false);
            hoverOverGamble.SetActive(false);
            autoList.SetActive(false);
            autoButton.SetActive(true);
            autoButton2.SetActive(false);
            armHover1.SetActive(false);
            armHover2.SetActive(false);
            armHover3.SetActive(false);
            armHover4.SetActive(false);
            armHover5.SetActive(false);
            armHover6.SetActive(false);
            armHover7.SetActive(false);
            armHover8.SetActive(false);
            armHover9.SetActive(false);
            armHover10.SetActive(false);
            armHover11.SetActive(false);
            armHover12.SetActive(false);
            armHover13.SetActive(false);
            armHover14.SetActive(false);
            armHover15.SetActive(false);
            armHover16.SetActive(false);
            armHover17.SetActive(false);
            armHover18.SetActive(false);
            armHover19.SetActive(false);
            armHover20.SetActive(false);
            armHover21.SetActive(false);
            armHover22.SetActive(false);
            armHover23.SetActive(false);
            armHover24.SetActive(false);
            armHover25.SetActive(false);
            armHover26.SetActive(false);
            armHover27.SetActive(false);
            armHover28.SetActive(false);
            armHover29.SetActive(false);
            armHover30.SetActive(false);
        }
    }


    public GameObject armHover1;
    public GameObject armHover2;
    public GameObject armHover3;
    public GameObject armHover4;
    public GameObject armHover5;
    public GameObject armHover6;
    public GameObject armHover7;
    public GameObject armHover8;
    public GameObject armHover9;
    public GameObject armHover10;
    public GameObject armHover11;
    public GameObject armHover12;
    public GameObject armHover13;
    public GameObject armHover14;
    public GameObject armHover15;
    public GameObject armHover16;
    public GameObject armHover17;
    public GameObject armHover18;
    public GameObject armHover19;
    public GameObject armHover20;
    public GameObject armHover21;
    public GameObject armHover22;
    public GameObject armHover23;
    public GameObject armHover24;
    public GameObject armHover25;
    public GameObject armHover26;
    public GameObject armHover27;
    public GameObject armHover28;
    public GameObject armHover29;
    public GameObject armHover30;

    public void OnMouseExit()
    {
        if (LoadSaves.isMobileBuild == false)
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
    }
}
