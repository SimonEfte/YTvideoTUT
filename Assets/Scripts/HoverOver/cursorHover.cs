using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorHover : MonoBehaviour
{
    public Texture2D cursor1;
    public GameObject objectToAdd1;

    public void OnMouseEnter()
    {
        if (LoadSaves.isMobileBuild == false)
        {
            Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
        }
    }

    public void OnMouseExit()
    {
        if (LoadSaves.isMobileBuild == false)
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
    }

    /*
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Click");
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
    }*/
}
