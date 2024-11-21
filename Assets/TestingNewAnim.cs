using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingNewAnim : MonoBehaviour
{
    public Animator flipAnim, flipAnim2, flipAnim3, flipAnim4, flipAnim5, flipAnim6, flipAnim7, flipAnim8, flipAnim9, flipAnim10, flipAnim11, flipAnim12, flipAnim13, flipAnim14, flipAnim15, flipAnim16, flipAnim17, flipAnim18, flipAnim19, flipAnim20, flipAnim21;

    public Animator flipSpecilAnim1, flipSpecilAnim2, flipSpecilAnim3, flipSpecilAnim4, flipSpecilAnim5, flipSpecilAnim6, flipSpecilAnim7, flipSpecilAnim8, flipSpecilAnim9, flipSpecilAnim10, flipSpecilAnim11, flipSpecilAnim12, flipSpecilAnim13, flipSpecilAnim14, flipSpecilAnim15, flipSpecilAnim16, flipSpecilAnim17, flipSpecilAnim18, flipSpecilAnim19, flipSpecilAnim20, flipSpecilAnim21;

    public void Flip(int flipper)
    {
        if(LoadSaves.isMobileBuild == true)
        {
            if (flipper == 1) { flipAnim.SetTrigger("Flip2"); }
            if (flipper == 2) { flipAnim2.SetTrigger("Flip2"); }
            if (flipper == 3) { flipAnim3.SetTrigger("Flip2"); }
            if (flipper == 4) { flipAnim4.SetTrigger("Flip2"); }
            if (flipper == 5) { flipAnim5.SetTrigger("Flip2"); }
            if (flipper == 6) { flipAnim6.SetTrigger("Flip2"); }
            if (flipper == 7) { flipAnim7.SetTrigger("Flip2"); }
            if (flipper == 8) { flipAnim8.SetTrigger("Flip2"); }
            if (flipper == 9) { flipAnim9.SetTrigger("Flip2"); }
            if (flipper == 10) { flipAnim10.SetTrigger("Flip2"); }
            if (flipper == 11) { flipAnim11.SetTrigger("Flip2"); }
            if (flipper == 12) { flipAnim12.SetTrigger("Flip2"); }
            if (flipper == 13) { flipAnim13.SetTrigger("Flip2"); }
            if (flipper == 14) { flipAnim14.SetTrigger("Flip2"); }
            if (flipper == 15) { flipAnim15.SetTrigger("Flip2"); }
            if (flipper == 16) { flipAnim16.SetTrigger("Flip2"); }
            if (flipper == 17) { flipAnim17.SetTrigger("Flip2"); }
            if (flipper == 18) { flipAnim18.SetTrigger("Flip2"); }
            if (flipper == 19) { flipAnim19.SetTrigger("Flip2"); }
            if (flipper == 20) { flipAnim20.SetTrigger("Flip2"); }
            if (flipper == 21) { flipAnim21.SetTrigger("Flip2"); }
        }
    }

    public void FlipSpecial(int flipper)
    {
        if (LoadSaves.isMobileBuild == true)
        {
            if (flipper == 1) { flipSpecilAnim1.SetTrigger("SpecialFlip"); }
            if (flipper == 2) { flipSpecilAnim2.SetTrigger("SpecialFlip"); }
            if (flipper == 3) { flipSpecilAnim3.SetTrigger("SpecialFlip"); }
            if (flipper == 4) { flipSpecilAnim4.SetTrigger("SpecialFlip"); }
            if (flipper == 5) { flipSpecilAnim5.SetTrigger("SpecialFlip"); }
            if (flipper == 6) { flipSpecilAnim6.SetTrigger("SpecialFlip"); }
            if (flipper == 7) { flipSpecilAnim7.SetTrigger("SpecialFlip"); }
            if (flipper == 8) { flipSpecilAnim8.SetTrigger("SpecialFlip"); }
            if (flipper == 9) { flipSpecilAnim9.SetTrigger("SpecialFlip"); }
            if (flipper == 10) { flipSpecilAnim10.SetTrigger("SpecialFlip"); }
            if (flipper == 11) { flipSpecilAnim11.SetTrigger("SpecialFlip"); }
            if (flipper == 12) { flipSpecilAnim12.SetTrigger("SpecialFlip"); }
            if (flipper == 13) { flipSpecilAnim13.SetTrigger("SpecialFlip"); }
            if (flipper == 14) { flipSpecilAnim14.SetTrigger("SpecialFlip"); }
            if (flipper == 15) { flipSpecilAnim15.SetTrigger("SpecialFlip"); }
            if (flipper == 16) { flipSpecilAnim16.SetTrigger("SpecialFlip"); }
            if (flipper == 17) { flipSpecilAnim17.SetTrigger("SpecialFlip"); }
            if (flipper == 18) { flipSpecilAnim18.SetTrigger("SpecialFlip"); }
            if (flipper == 19) { flipSpecilAnim19.SetTrigger("SpecialFlip"); }
            if (flipper == 20) { flipSpecilAnim20.SetTrigger("SpecialFlip"); }
            if (flipper == 21) { flipSpecilAnim21.SetTrigger("SpecialFlip"); }
        }
    }

    public void Set()
    {
        //if (LoadSaves.isMobileBuild == false) { specialAnim1.Play(); }
        //  else { newFlipScript.FlipSpecial(1); }

        //  public TestingNewAnim newFlipScript;
    }
}
