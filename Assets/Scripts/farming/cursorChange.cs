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
    public Text cursorControl;

    //cursorControl
    //0 : 가장 기본 상태
    //1 : 무씨앗 누른 상태
    //2 : 배추 씨앗 누른 상태
    //3 : 파 씨앗 누른 상태
    //4 : 물뿌리개 누른 상태
    //5 : 호미 누른 상태


    public void clickSeed1()
    {
        //무씨앗 클릭 함수
        Cursor.SetCursor(raddish, Vector2.zero, CursorMode.ForceSoftware);
        cursorControl.text = "1";    
    }
    public void clickSeed2()
      {
        //배추씨앗 클릭 함수
          Cursor.SetCursor(cabbage, Vector2.zero, CursorMode.ForceSoftware);
        cursorControl.text = "2";
    }
    public void clickSeed3()
      {
        //파 씨앗 클릭 함수
          Cursor.SetCursor(greenOnion, Vector2.zero, CursorMode.ForceSoftware);
        cursorControl.text = "3";
    }

    public void clickHomi()
    {
        //호미 클릭 함수
        Cursor.SetCursor(homi, Vector2.zero, CursorMode.ForceSoftware);
        cursorControl.text = "5";
    }
    public void clickwatering()
    {
        //물뿌리개 클릭 함수
        Cursor.SetCursor(watering, Vector2.zero, CursorMode.ForceSoftware);
        cursorControl.text = "4";
    }
}
