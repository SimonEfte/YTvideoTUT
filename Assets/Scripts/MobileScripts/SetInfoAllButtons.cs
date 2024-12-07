using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInfoAllButtons : MonoBehaviour
{
    public GameObject upgrade1Info, upgrade2Info, upgrade3Info, upgrade4Info, upgrade5Info, upgrade6Info, upgrade7Info, upgrade8Info, upgrade9Info, upgrade10Info, upgrade11Info, upgrade12Info, upgrade13Info, upgrade14Info, upgrade15Info;

    public GameObject specialInfo1, specialInfo2, specialInfo3, specialInfo4, specialInfo5, specialInfo6, specialInfo7, specialInfo8, specialInfo9;
    public GameObject exitGameBTN, aviableOnPlayBtn, languagesBtn, resBtn;
    public GameObject appStoreBtn, outOnMobileText;

    public GameObject setting1, setting2, sound;


    void Start()
    {
        //-2.4 = -197
        //-2.5 = -201.2
        //0.1 = 4.2

        if(LoadSaves.isMobileBuild == true) 
        {
            setting1.transform.localPosition = new Vector2(878f, 452f);
            setting2.transform.localPosition = new Vector2(878f, 452f);
            setting1.transform.localScale = new Vector2(5.33f, 5.33f);
            setting2.transform.localScale = new Vector2(5.33f, 5.33f);

            sound.transform.localPosition = new Vector2(694f, 451f);
            sound.transform.localScale = new Vector2(2.17f, 2.17f);

            exitGameBTN.SetActive(false);
            aviableOnPlayBtn.SetActive(false);
            appStoreBtn.SetActive(false);
            outOnMobileText.SetActive(false);
            languagesBtn.SetActive(false);
            resBtn.SetActive(false);

            xpos = -2.4f;
            ypos = -4.6f;
            scale = 2.7f;

            specialInfo1.SetActive(true);
            specialInfo2.SetActive(true);
            specialInfo3.SetActive(true);
            specialInfo4.SetActive(true);
            specialInfo5.SetActive(true);
            specialInfo6.SetActive(true);
            specialInfo7.SetActive(true);
            specialInfo8.SetActive(true);
            specialInfo9.SetActive(true);

            upgrade1Info.SetActive(true);
            upgrade2Info.SetActive(true);
            upgrade3Info.SetActive(true);
            upgrade4Info.SetActive(true);
            upgrade5Info.SetActive(true);
            upgrade6Info.SetActive(true);
            upgrade7Info.SetActive(true);
            upgrade8Info.SetActive(true);
            upgrade9Info.SetActive(true);
            upgrade10Info.SetActive(true);
            upgrade11Info.SetActive(true);
            upgrade12Info.SetActive(true);
            upgrade13Info.SetActive(true);
            upgrade14Info.SetActive(true);
            upgrade15Info.SetActive(true);
        }
        else
        {
            specialInfo1.SetActive(false);
            specialInfo2.SetActive(false);
            specialInfo3.SetActive(false);
            specialInfo4.SetActive(false);
            specialInfo5.SetActive(false);
            specialInfo6.SetActive(false);
            specialInfo7.SetActive(false);
            specialInfo8.SetActive(false);
            specialInfo9.SetActive(false);

            upgrade1Info.SetActive(false);
            upgrade2Info.SetActive(false);
            upgrade3Info.SetActive(false);
            upgrade4Info.SetActive(false);
            upgrade5Info.SetActive(false);
            upgrade6Info.SetActive(false);
            upgrade7Info.SetActive(false);
            upgrade8Info.SetActive(false);
            upgrade9Info.SetActive(false);
            upgrade10Info.SetActive(false);
            upgrade11Info.SetActive(false);
            upgrade12Info.SetActive(false);
            upgrade13Info.SetActive(false);
            upgrade14Info.SetActive(false);
            upgrade15Info.SetActive(false);
        }
    }

    public GameObject blackBar;
    public GameObject closeBar;


    public void SetBlackBar()
    {
        closeBar.SetActive(true);
        blackBar.SetActive(true);
    }

    public GameObject hover1, hover2, hover3, hover4, hover5, hover6, hover7, hover8, hover9, hover10, hover11, hover12, hover13, hover14, hover15, hover16, hover17, hover18, hover19, hover20, hover21, hover22, hover23, hover24, hover25;


    public static float xpos, ypos, scale;

    public void CloseBTN()
    {
        closeBar.SetActive(false);
        blackBar.SetActive(false);

        hover1.SetActive(false);
        hover2.SetActive(false);
        hover3.SetActive(false);
        hover4.SetActive(false);
        hover5.SetActive(false);
        hover6.SetActive(false);
        hover7.SetActive(false);
        hover8.SetActive(false);
        hover9.SetActive(false);
        hover10.SetActive(false);
        hover11.SetActive(false);
        hover12.SetActive(false);
        hover13.SetActive(false);
        hover14.SetActive(false);
        hover15.SetActive(false);
        hover16.SetActive(false);
        hover17.SetActive(false);
        hover18.SetActive(false);
        hover19.SetActive(false);
        hover20.SetActive(false);
        hover21.SetActive(false);
        hover22.SetActive(false);
        hover23.SetActive(false);
        hover24.SetActive(false);
    }

    public GameObject inflationExpl;
    public GameObject mobileInfoBar;
    //1.875 is original size
    //-634, 360 is original pos

    public void OpenInflationExplination()
    {
        if(LoadSaves.isMobileBuild == true)
        {
            inflationExpl.SetActive(true);
            inflationExpl.transform.localScale = new Vector2(4,4);
            inflationExpl.transform.localPosition = new Vector2(0, 81);
            mobileInfoBar.SetActive(true);
        }
    }

    public void CloseExpl()
    {
        inflationExpl.SetActive(false);
    }


}
