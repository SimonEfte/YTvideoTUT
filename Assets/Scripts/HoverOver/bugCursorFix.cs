using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugCursorFix : MonoBehaviour
{
    public Texture2D cursor;
    public GameObject objectToAdd;
    public void Update()
    {
        if (objectToAdd.activeInHierarchy == false)
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
    }
}
