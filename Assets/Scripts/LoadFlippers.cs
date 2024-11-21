using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFlippers : MonoBehaviour
{
    public GameObject empty1;
    public GameObject empty2;
    public GameObject empty3;
    public GameObject empty4;
    public GameObject empty5;
    public GameObject empty6;
    public GameObject empty7;
    public GameObject empty8;
    public GameObject empty9;
    public GameObject empty10;
    public GameObject empty11;
    public GameObject empty12;
    public GameObject empty13;
    public GameObject empty14;
    public GameObject empty15;
    public GameObject empty16;
    public GameObject empty17;
    public GameObject empty18;
    public GameObject empty19;
    public GameObject empty20;
    public GameObject empty21;

    public GameObject startGameButton;
    public GameObject startScreen;


    void Awake()
    {
        MainButtonClick.numberOfDuplicationUpgrades = PlayerPrefs.GetInt("SavedNumberOfCoinFlips");
        flipperLocation();
    }

    public void StartGame()
    {
        startGameButton.SetActive(false);
        startScreen.SetActive(false);
    }

    public void flipperLocation()
    {
        if (MainButtonClick.numberOfDuplicationUpgrades == 1)
        {
            empty1.SetActive(true);
            empty1.transform.localPosition = new Vector3(580f, -12, 0f);
            empty1.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
            empty2.SetActive(true);
            empty2.transform.localPosition = new Vector3(12, -12, 0f);
            empty2.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 2)
        {
            empty1.SetActive(true);
            empty1.transform.localPosition = new Vector3(12f, 102, 0f);
            empty1.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
            empty2.SetActive(true);
            empty2.transform.localPosition = new Vector3(580f, 102, 0f);
            empty2.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
            empty3.SetActive(true);
            empty3.transform.localPosition = new Vector3(235, -218, 0f);
            empty3.transform.localScale = new Vector3(1.107344f, 1.107344f, 1.107344f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 3)
        {
            empty1.SetActive(true);
            empty1.transform.localPosition = new Vector3(12f, 145, 0f);
            empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty2.SetActive(true);
            empty2.transform.localPosition = new Vector3(580, 145, 0f);
            empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty3.SetActive(true);
            empty3.transform.localPosition = new Vector3(12, -240, 0f);
            empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty4.SetActive(true);
            empty4.transform.localPosition = new Vector3(580, -240, 0f);
            empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 4)
        {
            empty1.SetActive(true);
            empty1.transform.localPosition = new Vector3(12f, 145, 0f);
            empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty2.SetActive(true);
            empty2.transform.localPosition = new Vector3(580, 145, 0f);
            empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty3.SetActive(true);
            empty3.transform.localPosition = new Vector3(12, -240, 0f);
            empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty4.SetActive(true);
            empty4.transform.localPosition = new Vector3(580, -240, 0f);
            empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty5.SetActive(true);
            empty5.transform.localPosition = new Vector3(285, -48f, 0f);
            empty5.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 5)
        {
            empty1.SetActive(true);
            empty1.transform.localPosition = new Vector3(-156f, 145, 0);
            empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty2.SetActive(true);
            empty2.transform.localPosition = new Vector3(283, 145, 0);
            empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty3.SetActive(true);
            empty3.transform.localPosition = new Vector3(737, 145, 0);
            empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty4.SetActive(true);
            empty4.transform.localPosition = new Vector3(-156, -240, 0);
            empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty5.SetActive(true);
            empty5.transform.localPosition = new Vector3(283, -240, 0);
            empty5.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty6.SetActive(true);
            empty6.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty6.transform.localPosition = new Vector3(737, -240, 0);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 6)
        {
            empty1.SetActive(true);
            empty1.transform.localPosition = new Vector3(-152f, 145, 0);
            empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty2.SetActive(true);
            empty2.transform.localPosition = new Vector3(136, 145, 0);
            empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty3.SetActive(true);
            empty3.transform.localPosition = new Vector3(436, 145, 0);
            empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty4.SetActive(true);
            empty4.transform.localPosition = new Vector3(736, 145, 0);
            empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty5.SetActive(true);
            empty5.transform.localPosition = new Vector3(-27, -225, 0);
            empty5.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty6.SetActive(true);
            empty6.transform.localPosition = new Vector3(274, -225, 0);
            empty6.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty7.SetActive(true);
            empty7.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty7.transform.localPosition = new Vector3(578, -225, 0);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 7)
        {
            empty1.SetActive(true);
            empty1.transform.localPosition = new Vector3(-152f, 145, 0);
            empty1.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty2.SetActive(true);
            empty2.transform.localPosition = new Vector3(136, 145, 0);
            empty2.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty3.SetActive(true);
            empty3.transform.localPosition = new Vector3(436, 145, 0);
            empty3.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty4.SetActive(true);
            empty4.transform.localPosition = new Vector3(736, 145, 0);
            empty4.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty5.SetActive(true);
            empty5.transform.localPosition = new Vector3(-152, -225, 0);
            empty5.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty6.SetActive(true);
            empty6.transform.localPosition = new Vector3(136, -225, 0);
            empty6.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty7.SetActive(true);
            empty7.transform.localPosition = new Vector3(436, -225, 0);
            empty7.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
            empty8.SetActive(true);
            empty8.transform.localPosition = new Vector3(736, -225, 0);
            empty8.transform.localScale = new Vector3(0.8652826f, 0.8652826f, 0.8652826f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 8)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty1.transform.localPosition = new Vector3(-152f, 154, 0);
            empty1.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
            empty2.transform.localPosition = new Vector3(136, 154, 0);
            empty2.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
            empty3.transform.localPosition = new Vector3(436, 154, 0);
            empty3.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
            empty4.transform.localPosition = new Vector3(736, 154, 0);
            empty4.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
            empty5.transform.localPosition = new Vector3(-228, -206, 0);
            empty5.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
            empty6.transform.localPosition = new Vector3(35, -206, 0);
            empty6.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
            empty7.transform.localPosition = new Vector3(308, -206, 0);
            empty7.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
            empty8.transform.localPosition = new Vector3(571, -206, 0);
            empty8.transform.localScale = new Vector3(0.7429143f, 0.7429143f, 0.7429143f);
            empty9.SetActive(true);
            empty9.transform.localPosition = new Vector3(834, -206, 0);
            empty9.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 9)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty1.transform.localPosition = new Vector3(-228f, 154, 0);
            empty1.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            empty2.transform.localPosition = new Vector3(35, 154, 0);
            empty2.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            empty3.transform.localPosition = new Vector3(308, 154, 0);
            empty3.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            empty4.transform.localPosition = new Vector3(571, 154, 0);
            empty4.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            empty5.transform.localPosition = new Vector3(834, 154, 0);
            empty5.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            empty6.transform.localPosition = new Vector3(-228, -206, 0);
            empty6.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            empty7.transform.localPosition = new Vector3(35, -206, 0);
            empty7.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            empty8.transform.localPosition = new Vector3(308, -206, 0);
            empty8.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            empty9.transform.localPosition = new Vector3(571, -206, 0);
            empty9.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
            empty10.SetActive(true);
            empty10.transform.localPosition = new Vector3(834, -206, 0);
            empty10.transform.localScale = new Vector3(0.7429143f, 0.74291436f, 0.7429143f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 10)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty1.transform.localPosition = new Vector3(-185f, 173, 0);
            empty1.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty2.transform.localPosition = new Vector3(132, 173, 0);
            empty2.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty3.transform.localPosition = new Vector3(453, 173, 0);
            empty3.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty4.transform.localPosition = new Vector3(767, 173, 0);
            empty4.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty5.transform.localPosition = new Vector3(-35, -70, 0);
            empty5.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty6.transform.localPosition = new Vector3(287, -70, 0);
            empty6.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty7.transform.localPosition = new Vector3(606, -70, 0);
            empty7.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty8.transform.localPosition = new Vector3(-185f, -305, 0);
            empty8.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty9.transform.localPosition = new Vector3(132, -305, 0);
            empty9.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty10.transform.localPosition = new Vector3(453, -305, 0);
            empty10.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
            empty11.SetActive(true);
            empty11.transform.localPosition = new Vector3(767, -305, 0);
            empty11.transform.localScale = new Vector3(0.6641134f, 0.6641134f, 0.6641134f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 11)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty1.transform.localPosition = new Vector3(-207f, 200, 0);
            empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty2.transform.localPosition = new Vector3(43, 200, 0);
            empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty3.transform.localPosition = new Vector3(293, 200, 0);
            empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty4.transform.localPosition = new Vector3(543, 200, 0);
            empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty5.transform.localPosition = new Vector3(793, 200, 0);
            empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty6.transform.localPosition = new Vector3(-208, -50, 0);
            empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty7.transform.localPosition = new Vector3(43, -50, 0);
            empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty8.transform.localPosition = new Vector3(293, -50, 0);
            empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty9.transform.localPosition = new Vector3(543, -50, 0);
            empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty10.transform.localPosition = new Vector3(793, -50, 0);
            empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty11.transform.localPosition = new Vector3(-208, -300, 0);
            empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty12.SetActive(true);
            empty12.transform.localPosition = new Vector3(43, -300, 0);
            empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 12)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty1.transform.localPosition = new Vector3(-207f, 200, 0);
            empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty2.transform.localPosition = new Vector3(43, 200, 0);
            empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty3.transform.localPosition = new Vector3(293, 200, 0);
            empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty4.transform.localPosition = new Vector3(543, 200, 0);
            empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty5.transform.localPosition = new Vector3(793, 200, 0);
            empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty6.transform.localPosition = new Vector3(-208, -50, 0);
            empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty7.transform.localPosition = new Vector3(43, -50, 0);
            empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty8.transform.localPosition = new Vector3(293, -50, 0);
            empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty9.transform.localPosition = new Vector3(543, -50, 0);
            empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty10.transform.localPosition = new Vector3(793, -50, 0);
            empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty11.transform.localPosition = new Vector3(-208, -300, 0);
            empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty12.SetActive(true);
            empty12.transform.localPosition = new Vector3(43, -300, 0);
            empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty13.SetActive(true);
            empty13.transform.localPosition = new Vector3(293, -300, 0);
            empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 13)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty1.transform.localPosition = new Vector3(-207f, 200, 0);
            empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty2.transform.localPosition = new Vector3(43, 200, 0);
            empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty3.transform.localPosition = new Vector3(293, 200, 0);
            empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty4.transform.localPosition = new Vector3(543, 200, 0);
            empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty5.transform.localPosition = new Vector3(793, 200, 0);
            empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty6.transform.localPosition = new Vector3(-208, -50, 0);
            empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty7.transform.localPosition = new Vector3(43, -50, 0);
            empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty8.transform.localPosition = new Vector3(293, -50, 0);
            empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty9.transform.localPosition = new Vector3(543, -50, 0);
            empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty10.transform.localPosition = new Vector3(793, -50, 0);
            empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty11.transform.localPosition = new Vector3(-208, -300, 0);
            empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty12.SetActive(true);
            empty12.transform.localPosition = new Vector3(43, -300, 0);
            empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty13.SetActive(true);
            empty13.transform.localPosition = new Vector3(293, -300, 0);
            empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty14.SetActive(true);
            empty14.transform.localPosition = new Vector3(543, -300, 0);
            empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 14)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty1.transform.localPosition = new Vector3(-207f, 200, 0);
            empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty2.transform.localPosition = new Vector3(43, 200, 0);
            empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty3.transform.localPosition = new Vector3(293, 200, 0);
            empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty4.transform.localPosition = new Vector3(543, 200, 0);
            empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty5.transform.localPosition = new Vector3(793, 200, 0);
            empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty6.transform.localPosition = new Vector3(-208, -50, 0);
            empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty7.transform.localPosition = new Vector3(43, -50, 0);
            empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty8.transform.localPosition = new Vector3(293, -50, 0);
            empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty9.transform.localPosition = new Vector3(543, -50, 0);
            empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty10.transform.localPosition = new Vector3(793, -50, 0);
            empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty11.transform.localPosition = new Vector3(-208, -300, 0);
            empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty12.SetActive(true);
            empty12.transform.localPosition = new Vector3(43, -300, 0);
            empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty13.SetActive(true);
            empty13.transform.localPosition = new Vector3(293, -300, 0);
            empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty14.SetActive(true);
            empty14.transform.localPosition = new Vector3(543, -300, 0);
            empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty15.SetActive(true);
            empty15.transform.localPosition = new Vector3(793, -300, 0);
            empty15.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 15)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty12.SetActive(true);
            empty13.SetActive(true);
            empty14.SetActive(true);
            empty15.SetActive(true);

            empty1.transform.localPosition = new Vector3(-210f, 200, 0);
            empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty2.transform.localPosition = new Vector3(-10, 200, 0);
            empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty3.transform.localPosition = new Vector3(190, 200, 0);
            empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty4.transform.localPosition = new Vector3(390, 200, 0);
            empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty5.transform.localPosition = new Vector3(590, 200, 0);
            empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty6.transform.localPosition = new Vector3(790, 200, 0);
            empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty7.transform.localPosition = new Vector3(-210, -50, 0);
            empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty8.transform.localPosition = new Vector3(-10, -50, 0);
            empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty9.transform.localPosition = new Vector3(190, -50, 0);
            empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty10.transform.localPosition = new Vector3(390, -50, 0);
            empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty11.transform.localPosition = new Vector3(590, -50, 0);
            empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty12.transform.localPosition = new Vector3(790f, -50, 0);
            empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty13.transform.localPosition = new Vector3(-210f, -300, 0);
            empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty14.transform.localPosition = new Vector3(-10f, -300, 0);
            empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty15.transform.localPosition = new Vector3(190f, -300, 0);
            empty15.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty16.SetActive(true);
            empty16.transform.localPosition = new Vector3(390, -300, 0);
            empty16.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 16)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty12.SetActive(true);
            empty13.SetActive(true);
            empty14.SetActive(true);
            empty15.SetActive(true);

            empty1.transform.localPosition = new Vector3(-210f, 200, 0);
            empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty2.transform.localPosition = new Vector3(-10, 200, 0);
            empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty3.transform.localPosition = new Vector3(190, 200, 0);
            empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty4.transform.localPosition = new Vector3(390, 200, 0);
            empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty5.transform.localPosition = new Vector3(590, 200, 0);
            empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty6.transform.localPosition = new Vector3(790, 200, 0);
            empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty7.transform.localPosition = new Vector3(-210, -50, 0);
            empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty8.transform.localPosition = new Vector3(-10, -50, 0);
            empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty9.transform.localPosition = new Vector3(190, -50, 0);
            empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty10.transform.localPosition = new Vector3(390, -50, 0);
            empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty11.transform.localPosition = new Vector3(590, -50, 0);
            empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty12.transform.localPosition = new Vector3(790f, -50, 0);
            empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty13.transform.localPosition = new Vector3(-210f, -300, 0);
            empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty14.transform.localPosition = new Vector3(-10f, -300, 0);
            empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty15.transform.localPosition = new Vector3(190f, -300, 0);
            empty15.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty16.SetActive(true);
            empty16.transform.localPosition = new Vector3(390, -300, 0);
            empty16.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty17.SetActive(true);
            empty17.transform.localPosition = new Vector3(590, -300, 0);
            empty17.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 17)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty12.SetActive(true);
            empty13.SetActive(true);
            empty14.SetActive(true);
            empty15.SetActive(true);
            empty1.transform.localPosition = new Vector3(-210f, 200, 0);
            empty1.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty2.transform.localPosition = new Vector3(-10, 200, 0);
            empty2.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty3.transform.localPosition = new Vector3(190, 200, 0);
            empty3.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty4.transform.localPosition = new Vector3(390, 200, 0);
            empty4.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty5.transform.localPosition = new Vector3(590, 200, 0);
            empty5.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty6.transform.localPosition = new Vector3(790, 200, 0);
            empty6.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty7.transform.localPosition = new Vector3(-210, -50, 0);
            empty7.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty8.transform.localPosition = new Vector3(-10, -50, 0);
            empty8.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty9.transform.localPosition = new Vector3(190, -50, 0);
            empty9.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty10.transform.localPosition = new Vector3(390, -50, 0);
            empty10.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty11.transform.localPosition = new Vector3(590, -50, 0);
            empty11.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty12.transform.localPosition = new Vector3(790f, -50, 0);
            empty12.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty13.transform.localPosition = new Vector3(-210f, -300, 0);
            empty13.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty14.transform.localPosition = new Vector3(-10f, -300, 0);
            empty14.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty15.transform.localPosition = new Vector3(190f, -300, 0);
            empty15.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty16.SetActive(true);
            empty16.transform.localPosition = new Vector3(390, -300, 0);
            empty16.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty17.SetActive(true);
            empty17.transform.localPosition = new Vector3(590, -300, 0);
            empty17.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
            empty18.SetActive(true);
            empty18.transform.localPosition = new Vector3(790, -300, 0);
            empty18.transform.localScale = new Vector3(0.5590653f, 0.5590653f, 0.5590653f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 18)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty12.SetActive(true);
            empty13.SetActive(true);
            empty14.SetActive(true);
            empty15.SetActive(true);
            empty16.SetActive(true);
            empty17.SetActive(true);
            empty18.SetActive(true);
            empty1.transform.localPosition = new Vector3(-221f, 220, 0);
            empty1.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty2.transform.localPosition = new Vector3(-51, 220, 0);
            empty2.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty3.transform.localPosition = new Vector3(119, 220, 0);
            empty3.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty4.transform.localPosition = new Vector3(289, 220, 0);
            empty4.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty5.transform.localPosition = new Vector3(459, 220, 0);
            empty5.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty6.transform.localPosition = new Vector3(629, 220, 0);
            empty6.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty7.transform.localPosition = new Vector3(799, 220, 0);
            empty7.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty8.transform.localPosition = new Vector3(-221, -40, 0);
            empty8.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty9.transform.localPosition = new Vector3(-50, -40, 0);
            empty9.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty10.transform.localPosition = new Vector3(119, -40, 0);
            empty10.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty11.transform.localPosition = new Vector3(289, -40, 0);
            empty11.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty12.transform.localPosition = new Vector3(459f, -40, 0);
            empty12.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty13.transform.localPosition = new Vector3(629f, -40, 0);
            empty13.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty14.transform.localPosition = new Vector3(799f, -40, 0);
            empty14.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty15.transform.localPosition = new Vector3(-221f, -300, 0);
            empty15.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty16.transform.localPosition = new Vector3(-51, -300, 0);
            empty16.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty17.transform.localPosition = new Vector3(119, -300, 0);
            empty17.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty18.transform.localPosition = new Vector3(289, -300, 0);
            empty18.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty19.SetActive(true);
            empty19.transform.localPosition = new Vector3(459, -300, 0);
            empty19.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 19)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty12.SetActive(true);
            empty13.SetActive(true);
            empty14.SetActive(true);
            empty15.SetActive(true);
            empty16.SetActive(true);
            empty17.SetActive(true);
            empty18.SetActive(true);
            empty1.transform.localPosition = new Vector3(-221f, 220, 0);
            empty1.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty2.transform.localPosition = new Vector3(-51, 220, 0);
            empty2.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty3.transform.localPosition = new Vector3(119, 220, 0);
            empty3.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty4.transform.localPosition = new Vector3(289, 220, 0);
            empty4.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty5.transform.localPosition = new Vector3(459, 220, 0);
            empty5.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty6.transform.localPosition = new Vector3(629, 220, 0);
            empty6.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty7.transform.localPosition = new Vector3(799, 220, 0);
            empty7.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty8.transform.localPosition = new Vector3(-221, -40, 0);
            empty8.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty9.transform.localPosition = new Vector3(-50, -40, 0);
            empty9.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty10.transform.localPosition = new Vector3(119, -40, 0);
            empty10.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty11.transform.localPosition = new Vector3(289, -40, 0);
            empty11.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty12.transform.localPosition = new Vector3(459f, -40, 0);
            empty12.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty13.transform.localPosition = new Vector3(629f, -40, 0);
            empty13.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty14.transform.localPosition = new Vector3(799f, -40, 0);
            empty14.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty15.transform.localPosition = new Vector3(-221f, -300, 0);
            empty15.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty16.transform.localPosition = new Vector3(-51, -300, 0);
            empty16.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty17.transform.localPosition = new Vector3(119, -300, 0);
            empty17.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty18.transform.localPosition = new Vector3(289, -300, 0);
            empty18.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty19.SetActive(true);
            empty19.transform.localPosition = new Vector3(459, -300, 0);
            empty19.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty20.SetActive(true);
            empty20.transform.localPosition = new Vector3(629, -300, 0);
            empty20.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
        }
        if (MainButtonClick.numberOfDuplicationUpgrades == 20)
        {
            empty1.SetActive(true);
            empty2.SetActive(true);
            empty3.SetActive(true);
            empty4.SetActive(true);
            empty5.SetActive(true);
            empty6.SetActive(true);
            empty7.SetActive(true);
            empty8.SetActive(true);
            empty9.SetActive(true);
            empty10.SetActive(true);
            empty11.SetActive(true);
            empty12.SetActive(true);
            empty13.SetActive(true);
            empty14.SetActive(true);
            empty15.SetActive(true);
            empty16.SetActive(true);
            empty17.SetActive(true);
            empty18.SetActive(true);
            empty1.transform.localPosition = new Vector3(-221f, 220, 0);
            empty1.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty2.transform.localPosition = new Vector3(-51, 220, 0);
            empty2.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty3.transform.localPosition = new Vector3(119, 220, 0);
            empty3.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty4.transform.localPosition = new Vector3(289, 220, 0);
            empty4.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty5.transform.localPosition = new Vector3(459, 220, 0);
            empty5.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty6.transform.localPosition = new Vector3(629, 220, 0);
            empty6.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty7.transform.localPosition = new Vector3(799, 220, 0);
            empty7.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty8.transform.localPosition = new Vector3(-221, -40, 0);
            empty8.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty9.transform.localPosition = new Vector3(-50, -40, 0);
            empty9.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty10.transform.localPosition = new Vector3(119, -40, 0);
            empty10.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty11.transform.localPosition = new Vector3(289, -40, 0);
            empty11.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty12.transform.localPosition = new Vector3(459f, -40, 0);
            empty12.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty13.transform.localPosition = new Vector3(629f, -40, 0);
            empty13.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty14.transform.localPosition = new Vector3(799f, -40, 0);
            empty14.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty15.transform.localPosition = new Vector3(-221f, -300, 0);
            empty15.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty16.transform.localPosition = new Vector3(-51, -300, 0);
            empty16.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty17.transform.localPosition = new Vector3(119, -300, 0);
            empty17.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty18.transform.localPosition = new Vector3(289, -300, 0);
            empty18.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty19.SetActive(true);
            empty19.transform.localPosition = new Vector3(459, -300, 0);
            empty19.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty20.SetActive(true);
            empty20.transform.localPosition = new Vector3(629, -300, 0);
            empty20.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
            empty21.SetActive(true);
            empty21.transform.localPosition = new Vector3(799, -300, 0);
            empty21.transform.localScale = new Vector3(0.4948343f, 0.4948343f, 0.4948343f);
           
        }
    }

}
