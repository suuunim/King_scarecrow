using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cursorChange : MonoBehaviour
{
    private Button button;
    public Texture2D raddish;
    public Texture2D cabbage;
    public Texture2D greenOnion;
    public Texture2D homi;
    public Texture2D watering;
    public Texture2D original;
    public Text cursorControl;
    private Vector2 hotSpot;

    //cursorControl
    //0 : 가장 기본 상태
    //1 : 무씨앗 누른 상태
    //2 : 배추 씨앗 누른 상태
    //3 : 파 씨앗 누른 상태
    //4 : 물뿌리개 누른 상태
    //5 : 호미 누른 상태

    public void adjustHotSpot(Texture2D target)
    {
        hotSpot.x = target.width / 2;
        hotSpot.y = target.height / 2;
    }

    public void changeToOriginal()
    {
        Cursor.SetCursor(original, Vector2.zero, CursorMode.ForceSoftware);
        cursorControl.text = "0";
    }
    //무씨앗 클릭 함수
    public void clickSeed1()
    {
        adjustHotSpot(raddish);
        if (cursorControl.text == "1")
            changeToOriginal();
        else
        {
            Cursor.SetCursor(raddish, hotSpot, CursorMode.ForceSoftware);
            cursorControl.text = "1";
        }


    }
    public void clickSeed2()
      {
        adjustHotSpot(cabbage);
        if (cursorControl.text == "2")
            changeToOriginal();
        else
        {
            Cursor.SetCursor(cabbage, hotSpot, CursorMode.ForceSoftware);
            cursorControl.text = "2";
        }
            
    }
    public void clickSeed3()
      {
        adjustHotSpot(greenOnion);
        if (cursorControl.text == "3")
            changeToOriginal();
        else
        {
            Cursor.SetCursor(greenOnion, hotSpot, CursorMode.ForceSoftware);
            cursorControl.text = "3";
        }
       
    }

    public void clickHomi()
    {
        if(cursorControl.text == "5")
        {
            changeToOriginal();
        }
        else
        {
            Cursor.SetCursor(homi, Vector2.zero, CursorMode.ForceSoftware);
            cursorControl.text = "5";
        }
 
    }
    public void clickwatering()
    {
        if (cursorControl.text == "4")
            changeToOriginal();
        else
        {
            Vector2 v;
            v.x = watering.width / 2;
            v.y = watering.height / 2;
            Cursor.SetCursor(watering, v, CursorMode.ForceSoftware);
            cursorControl.text = "4";
        }
    }
}
