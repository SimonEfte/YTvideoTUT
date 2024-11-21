using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScreen : MonoBehaviour
{
    public GameObject screen2;
    public void SwitchScreenButton()
    {
        screen2.SetActive(true);
    }

    public void SwitchScreenButtonBack()
    {
        screen2.SetActive(false);
    }
}
