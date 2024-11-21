using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class GoldenFlipsButton : MonoBehaviour
{
    public static int goldenCoinsUpgradeCount;
    public GameObject specialEmpty1;
    public VideoPlayer specialAnim1;
    public GameObject specialEmpty2;
    public VideoPlayer specialAnim2;
    public GameObject specialEmpty3;
    public VideoPlayer specialAnim3;
    public GameObject specialEmpty4;
    public VideoPlayer specialAnim4;
    public GameObject specialEmpty5;
    public VideoPlayer specialAnim5;
    public VideoPlayer specialAnim6;
    public GameObject specialEmpty6;
    public GameObject specialEmpty7;
    public VideoPlayer specialAnim7;
    public GameObject specialEmpty8;
    public VideoPlayer specialAnim8;
    public GameObject specialEmpty9;
    public VideoPlayer specialAnim9;
    public GameObject specialEmpty10;
    public VideoPlayer specialAnim10;
    public GameObject specialEmpty11;
    public VideoPlayer specialAnim11;
    public GameObject specialEmpty12;
    public VideoPlayer specialAnim12;
    public GameObject specialEmpty13;
    public VideoPlayer specialAnim13;
    public GameObject specialEmpty14;
    public VideoPlayer specialAnim14;
    public GameObject specialEmpty15;
    public VideoPlayer specialAnim15;
    public GameObject specialEmpty16;
    public VideoPlayer specialAnim16;
    public GameObject specialEmpty17;
    public VideoPlayer specialAnim17;
    public GameObject specialEmpty18;
    public VideoPlayer specialAnim18;
    public GameObject specialEmpty19;
    public VideoPlayer specialAnim19;
    public GameObject specialEmpty20;
    public VideoPlayer specialAnim20;
    public GameObject specialEmpty21;
    public VideoPlayer specialAnim21;

    public GameObject specialAutoFlips1;
    public GameObject specialAutoFlips2;
    public GameObject specialAutoFlips3;
    public GameObject specialAutoFlips4;
    public GameObject specialAutoFlips5;
    public GameObject specialAutoFlips6;
    public GameObject specialAutoFlips7;
    public GameObject specialAutoFlips8;
    public GameObject specialAutoFlips9;
    public GameObject specialAutoFlips10;
    public GameObject specialAutoFlips11;
    public GameObject specialAutoFlips12;
    public GameObject specialAutoFlips13;
    public GameObject specialAutoFlips14;
    public GameObject specialAutoFlips15;
    public GameObject specialAutoFlips16;
    public GameObject specialAutoFlips17;
    public GameObject specialAutoFlips18;
    public GameObject specialAutoFlips19;
    public GameObject specialAutoFlips20;
    public GameObject specialAutoFlips21;

    public GameObject specialFlipperHoverOver1;
    public GameObject specialFlipperHoverOver2;
    public GameObject specialFlipperHoverOver3;
    public GameObject specialFlipperHoverOver4;
    public GameObject specialFlipperHoverOver5;
    public GameObject specialFlipperHoverOver6;
    public GameObject specialFlipperHoverOver7;
    public GameObject specialFlipperHoverOver8;
    public GameObject specialFlipperHoverOver9;
    public GameObject specialFlipperHoverOver10;
    public GameObject specialFlipperHoverOver11;
    public GameObject specialFlipperHoverOver12;
    public GameObject specialFlipperHoverOver13;
    public GameObject specialFlipperHoverOver14;
    public GameObject specialFlipperHoverOver15;
    public GameObject specialFlipperHoverOver16;
    public GameObject specialFlipperHoverOver17;
    public GameObject specialFlipperHoverOver18;
    public GameObject specialFlipperHoverOver19;
    public GameObject specialFlipperHoverOver20;
    public GameObject specialFlipperHoverOver21;

    public GameObject hideBackground1;
    public GameObject hideBackground2;
    public GameObject hideBackground3;
    public GameObject hideBackground4;
    public GameObject hideBackground5;
    public GameObject hideBackground6;
    public GameObject hideBackground7;
    public GameObject hideBackground8;
    public GameObject hideBackground9;
    public GameObject hideBackground10;
    public GameObject hideBackground11;
    public GameObject hideBackground12;
    public GameObject hideBackground13;
    public GameObject hideBackground14;
    public GameObject hideBackground15;
    public GameObject hideBackground16;
    public GameObject hideBackground17;
    public GameObject hideBackground18;
    public GameObject hideBackground19;
    public GameObject hideBackground20;
    public GameObject hideBackground21;
  
    private void Start()
    {
        if (goldenCoinsUpgradeCount > 0)
        {
            hideBackground1.SetActive(true);
            specialEmpty1.SetActive(true);
            StartCoroutine(waitForSpecialFlip());
        }
        if (goldenCoinsUpgradeCount > 1)
        {
            hideBackground2.SetActive(true);
            specialEmpty2.SetActive(true);
            StartCoroutine(waitForSpecialFlip2());
        }
        if (goldenCoinsUpgradeCount > 2)
        {
            hideBackground3.SetActive(true);
            specialEmpty3.SetActive(true);
            StartCoroutine(waitForSpecialFlip3());
        }
        if (goldenCoinsUpgradeCount > 3)
        {
            hideBackground4.SetActive(true);
            specialEmpty4.SetActive(true);
            StartCoroutine(waitForSpecialFlip4());
        }
        if (goldenCoinsUpgradeCount > 4)
        {
            hideBackground5.SetActive(true);
            specialEmpty5.SetActive(true);
            StartCoroutine(waitForSpecialFlip5());
        }
        if (goldenCoinsUpgradeCount > 5)
        {
            hideBackground6.SetActive(true);
            specialEmpty6.SetActive(true);
            StartCoroutine(waitForSpecialFlip6());
        }
        if (goldenCoinsUpgradeCount > 6)
        {
            hideBackground7.SetActive(true);
            specialEmpty7.SetActive(true);
            StartCoroutine(waitForSpecialFlip7());
        }
        if (goldenCoinsUpgradeCount > 7)
        {
            hideBackground8.SetActive(true);
            specialEmpty8.SetActive(true);
            StartCoroutine(waitForSpecialFlip8());
        }
        if (goldenCoinsUpgradeCount > 8)
        {
            hideBackground9.SetActive(true);
            specialEmpty9.SetActive(true);
            StartCoroutine(waitForSpecialFlip9());
        }
        if (goldenCoinsUpgradeCount > 9)
        {
            hideBackground10.SetActive(true);
            specialEmpty10.SetActive(true);
            StartCoroutine(waitForSpecialFlip10());
        }
        if (goldenCoinsUpgradeCount > 10)
        {
            hideBackground11.SetActive(true);
            specialEmpty11.SetActive(true);
            StartCoroutine(waitForSpecialFlip11());
        }
        if (goldenCoinsUpgradeCount > 11)
        {
            hideBackground12.SetActive(true);
            specialEmpty12.SetActive(true);
            StartCoroutine(waitForSpecialFlip12());
        }
        if (goldenCoinsUpgradeCount > 12)
        {
            hideBackground13.SetActive(true);
            specialEmpty13.SetActive(true);
            StartCoroutine(waitForSpecialFlip13());
        }
        if (goldenCoinsUpgradeCount > 13)
        {
            hideBackground14.SetActive(true);
            specialEmpty14.SetActive(true);
            StartCoroutine(waitForSpecialFlip14());
        }
        if (goldenCoinsUpgradeCount > 14)
        {
            hideBackground15.SetActive(true);
            specialEmpty15.SetActive(true);
            StartCoroutine(waitForSpecialFlip15());
        }
        if (goldenCoinsUpgradeCount > 15)
        {
            hideBackground16.SetActive(true);
            specialEmpty16.SetActive(true);
            StartCoroutine(waitForSpecialFlip16());
        }
        if (goldenCoinsUpgradeCount > 16)
        {
            hideBackground17.SetActive(true);
            specialEmpty17.SetActive(true);
            StartCoroutine(waitForSpecialFlip17());
        }
        if (goldenCoinsUpgradeCount > 17)
        {
            hideBackground18.SetActive(true);
            specialEmpty18.SetActive(true);
            StartCoroutine(waitForSpecialFlip18());
        }
        if (goldenCoinsUpgradeCount > 18)
        {
            hideBackground19.SetActive(true);
            specialEmpty19.SetActive(true);
            StartCoroutine(waitForSpecialFlip19());
        }
        if (goldenCoinsUpgradeCount > 19)
        {
            hideBackground20.SetActive(true);
            specialEmpty20.SetActive(true);
            StartCoroutine(waitForSpecialFlip20());
        }
        if (goldenCoinsUpgradeCount > 20)
        {
            hideBackground21.SetActive(true);
            specialEmpty21.SetActive(true);
            StartCoroutine(waitForSpecialFlip21());
        }

        SetPosAndScale();
    }

    #region Set number of duplication upgrade position and scale
    public void SetPosAndScale()
    {
        if (MainButtonClick.numberOfDuplicationUpgrades == 20)
        {
            specialEmpty1.transform.localPosition = new Vector3(-204f, 220, 0);
            specialEmpty1.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty2.transform.localPosition = new Vector3(-34, 220, 0);
            specialEmpty2.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty3.transform.localPosition = new Vector3(136, 220, 0);
            specialEmpty3.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty4.transform.localPosition = new Vector3(306, 220, 0);
            specialEmpty4.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty5.transform.localPosition = new Vector3(476, 220, 0);
            specialEmpty5.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty6.transform.localPosition = new Vector3(646, 220, 0);
            specialEmpty6.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty7.transform.localPosition = new Vector3(816, 220, 0);
            specialEmpty7.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty8.transform.localPosition = new Vector3(-204, -40, 0);
            specialEmpty8.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty9.transform.localPosition = new Vector3(-33, -40, 0);
            specialEmpty9.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty10.transform.localPosition = new Vector3(136, -40, 0);
            specialEmpty10.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty11.transform.localPosition = new Vector3(306, -40, 0);
            specialEmpty11.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty12.transform.localPosition = new Vector3(476f, -40, 0);
            specialEmpty12.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty13.transform.localPosition = new Vector3(646f, -40, 0);
            specialEmpty13.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty14.transform.localPosition = new Vector3(816f, -40, 0);
            specialEmpty14.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty15.transform.localPosition = new Vector3(-204f, -300, 0);
            specialEmpty15.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty16.transform.localPosition = new Vector3(-33, -300, 0);
            specialEmpty16.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty17.transform.localPosition = new Vector3(136, -300, 0);
            specialEmpty17.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty18.transform.localPosition = new Vector3(306, -300, 0);
            specialEmpty18.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty19.transform.localPosition = new Vector3(476, -300, 0);
            specialEmpty19.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty20.transform.localPosition = new Vector3(646, -300, 0);
            specialEmpty20.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            specialEmpty21.transform.localPosition = new Vector3(816, -300, 0);
            specialEmpty21.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
        }

        if (goldenCoinsUpgradeCount == 0)
        {
            hideBackground1.SetActive(false);
            hideBackground2.SetActive(false);
            hideBackground3.SetActive(false);
            hideBackground4.SetActive(false);
            hideBackground5.SetActive(false);
            hideBackground6.SetActive(false);
            hideBackground7.SetActive(false);
            hideBackground8.SetActive(false);
            hideBackground9.SetActive(false);
            hideBackground10.SetActive(false);
            hideBackground11.SetActive(false);
            hideBackground12.SetActive(false);
            hideBackground13.SetActive(false);
            hideBackground14.SetActive(false);
            hideBackground15.SetActive(false);
            hideBackground16.SetActive(false);
            hideBackground17.SetActive(false);
            hideBackground18.SetActive(false);
            hideBackground19.SetActive(false);
            hideBackground20.SetActive(false);
            hideBackground21.SetActive(false);

            specialEmpty1.SetActive(false);
            SpecialAuto1.flipAuto = 0;
            specialEmpty2.SetActive(false);
            SpecialAuto2.flipAuto = 0;
            specialEmpty3.SetActive(false);
            SpecialAuto3.flipAuto = 0;
            specialEmpty4.SetActive(false);
            SpecialAuto4.flipAuto = 0;
            specialEmpty5.SetActive(false);
            SpecialAuto5.flipAuto = 0;
            specialEmpty6.SetActive(false);
            SpecialAuto6.flipAuto = 0;
            specialEmpty7.SetActive(false);
            SpecialAuto7.flipAuto = 0;
            specialEmpty8.SetActive(false);
            SpecialAuto8.flipAuto = 0;
            specialEmpty9.SetActive(false);
            SpecialAuto9.flipAuto = 0;
            specialEmpty10.SetActive(false);
            SpecialAuto10.flipAuto = 0;
            specialEmpty11.SetActive(false);
            SpecialAuto11.flipAuto = 0;
            specialEmpty12.SetActive(false);
            SpecialAuto12.flipAuto = 0;
            specialEmpty13.SetActive(false);
            SpecialAuto13.flipAuto = 0;
            specialEmpty14.SetActive(false);
            SpecialAuto14.flipAuto = 0;
            specialEmpty15.SetActive(false);
            SpecialAuto15.flipAuto = 0;
            specialEmpty16.SetActive(false);
            SpecialAuto16.flipAuto = 0;
            specialEmpty17.SetActive(false);
            SpecialAuto17.flipAuto = 0;
            specialEmpty18.SetActive(false);
            SpecialAuto18.flipAuto = 0;
            specialEmpty19.SetActive(false);
            SpecialAuto19.flipAuto = 0;
            specialEmpty20.SetActive(false);
            SpecialAuto20.flipAuto = 0;
            specialEmpty21.SetActive(false);
            SpecialAuto21.flipAuto = 0;

        }
    }
    #endregion


    IEnumerator waitForSpecialFlip()
    {
        float random = Random.Range(0.1f, 2f);
        yield return new WaitForSeconds(random);
        SpecialAuto1.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip2()
    {
        float random = Random.Range(0.1f, 1.9f);
        yield return new WaitForSeconds(random);
        SpecialAuto2.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip3()
    {
        float random = Random.Range(0.1f, 2.1f);
        yield return new WaitForSeconds(random);
        SpecialAuto3.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip4()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto4.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip5()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto5.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip6()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto6.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip7()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto7.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip8()
    {
        float random = Random.Range(0.1f, 0.5f);
        yield return new WaitForSeconds(random);
        SpecialAuto8.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip9()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto9.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip10()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto10.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip11()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto11.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip12()
    {
        float random = Random.Range(0.1f, 0.8f);
        yield return new WaitForSeconds(random);
        SpecialAuto12.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip13()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto13.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip14()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto14.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip15()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto15.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip16()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto16.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip17()
    {
        float random = Random.Range(0.1f, 0.2f);
        yield return new WaitForSeconds(random);
        SpecialAuto17.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip18()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto18.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip19()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto19.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip20()
    {
        float random = Random.Range(1.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto20.flipAuto = 1;
    }
    IEnumerator waitForSpecialFlip21()
    {
        float random = Random.Range(0.1f, 1.85f);
        yield return new WaitForSeconds(random);
        SpecialAuto21.flipAuto = 1;
    }


    public void GoldenCoins()
    {
      
        goldenCoinsUpgradeCount += 1;
        GlobalCoins.CoinCount -= GOLDENFLIPS.specialCoinsButtonCost;
        GOLDENFLIPS.turnOffButton = true;
        GOLDENFLIPS.specialCoinsButtonCost *= 1.75f;
        if (goldenCoinsUpgradeCount > 0)
        {
            hideBackground1.SetActive(true);
            specialEmpty1.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto1.flipAuto = 1;}
        }
        if (goldenCoinsUpgradeCount > 1)
        {
            hideBackground2.SetActive(true);
            specialEmpty2.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto2.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 2)
        {
            hideBackground3.SetActive(true);
            specialEmpty3.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto3.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 3)
        {
            hideBackground4.SetActive(true);
            specialEmpty4.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto4.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 4)
        {
            hideBackground5.SetActive(true);
            specialEmpty5.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto5.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 5)
        {
            hideBackground6.SetActive(true);
            specialEmpty6.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto6.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 6)
        {
            hideBackground7.SetActive(true);
            specialEmpty7.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto7.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 7)
        {
            hideBackground8.SetActive(true);
            specialEmpty8.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto8.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 8)
        {
            hideBackground9.SetActive(true);
            specialEmpty9.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto9.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 9)
        {
            hideBackground10.SetActive(true);
            specialEmpty10.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto10.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 10)
        {
            hideBackground11.SetActive(true);
            specialEmpty11.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto11.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 11)
        {
            hideBackground12.SetActive(true);
            specialEmpty12.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto12.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 12)
        {
            hideBackground13.SetActive(true);
            specialEmpty13.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto13.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 13)
        {
            hideBackground14.SetActive(true);
            specialEmpty14.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto14.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 14)
        {
            hideBackground15.SetActive(true);
            specialEmpty15.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto15.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 15)
        {
            hideBackground16.SetActive(true);
            specialEmpty16.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto16.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 16)
        {
            hideBackground17.SetActive(true);
            specialEmpty17.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto17.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 17)
        {
            hideBackground18.SetActive(true);
            specialEmpty18.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto18.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 18)
        {
            hideBackground19.SetActive(true);
            specialEmpty19.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto19.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 19)
        {
            hideBackground20.SetActive(true);
            specialEmpty20.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto20.flipAuto = 1; }
        }
        if (goldenCoinsUpgradeCount > 20)
        {
            hideBackground21.SetActive(true);
            specialEmpty21.SetActive(true);
            if (ManualClicking.isSwitchOff == 0) { SpecialAuto21.flipAuto = 1; }
        }

        UpgradeClickSound();
    }

    public AudioSource UpgradeSound1;
    public AudioSource UpgradeSound2;

    public void UpgradeClickSound()
    {
        int generateRandomUpgradeSound = Random.Range(1, 3);
        if (generateRandomUpgradeSound == 1)
        {
            UpgradeSound1.Play();
        }
        else if (generateRandomUpgradeSound == 2)
        {
            UpgradeSound2.Play();
        }
    }
}
