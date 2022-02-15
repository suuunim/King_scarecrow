using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cursorOriginal : MonoBehaviour
{
    private Text txt_cursor;
    public Texture2D original;
    // Start is called before the first frame update
    void Start()
    {
        txt_cursor = GameObject.Find("cursorControl").GetComponent<Text>();
        txt_cursor.text = "0";
        Cursor.SetCursor(original, Vector2.zero, CursorMode.ForceSoftware);
    }

}
