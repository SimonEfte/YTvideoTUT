using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChallengesTabs : MonoBehaviour
{

    public GameObject challengesList;
    public GameObject arrowUp;
    public GameObject arrowDown;
    public GameObject ButtonDropDown;
    public GameObject ButtonDropUp;

    public void ChallengeListClick()
    {
        challengesList.SetActive(true);
        arrowDown.SetActive(false);
        arrowUp.SetActive(true);
        ButtonDropDown.SetActive(false);
        ButtonDropUp.SetActive(true);
    }

    public void ChallengeListClickDown()
    {
        challengesList.SetActive(false);
        arrowUp.SetActive(false);
        arrowDown.SetActive(true);
        ButtonDropDown.SetActive(true);
        ButtonDropUp.SetActive(false);
    }
}
