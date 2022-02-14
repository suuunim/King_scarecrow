using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//전체밭(해당 농작물 밭 6칸 중 아무곳이나) 클릭 
//관련 스크립트 (raycast target 문제로 작은 밭 한칸 한칸에 적용)
public class GField : MonoBehaviour
{
    //cursorControl
    //0 : 가장 기본 상태
    //1 : 무씨앗 누른 상태
    //2 : 배추 씨앗 누른 상태
    //3 : 파 씨앗 누른 상태
    //4 : 물뿌리개 누른 상태
    //5 : 호미 누른 상태

    //밭 한칸 한칸의 상태
    //0 기본 상태
    //1 밭이 갈아진 상태
    //2 씨앗이 심어진 상태
    //3 ~ 초 흐름

    public Text cursorControl;
    public Text result;
    public Sprite plowed;
    public Sprite seed;
    public Sprite complete;
    public Sprite fail;
    public Sprite initial;
    public Sprite sprout;

    public Text seedGNum;

    private GameObject parent;
    private Sprite sp;



    //같은 그룹의 밭들 이미지와 상태 변경하는 함수
    private void changeImageToWatered()//물줬을 때
    {
        for (int i = 0; i < 6; i++)
        {
            Transform tmp = parent.transform.GetChild(i);
            Image img = tmp.GetComponent<Image>();
            if (tmp.GetChild(0).GetComponent<Text>().text == "2")//이미 씨앗까지 다 준 상태였을 때
            {
                img.sprite = sprout;
                Debug.Log(i + " watered and start growing");
                tmp.GetChild(0).GetComponent<Text>().text = "3";
                GameObject.Find("fieldTimer").GetComponent<FieldTimer>().gTimer[i] = 3.0f;
                Debug.Log(GameObject.Find("fieldTimer").GetComponent<FieldTimer>().gTimer[i]);
            }

        }

    }

    private void changeImageToPlowed()//밭 갈아 줬을 때
    {
        for (int i = 0; i < 6; i++)
        {
            Transform tmp = parent.transform.GetChild(i);
            Image img = tmp.GetComponent<Image>();
            if (tmp.GetChild(0).GetComponent<Text>().text == "0")//기본 상태였을 때
            {
                Debug.Log(i + " plowed");
                Color color = img.color;
                img.sprite = plowed;
                color.a = 1.0f;
                img.color = color;
                tmp.GetChild(0).GetComponent<Text>().text = "1";
            }

        }

    }
    public void clickfield()
    {
        Button obj = this.GetComponent<Button>();
        Image img = obj.image;
        sp = obj.image.sprite;

        string state = obj.transform.GetChild(0).GetComponent<Text>().text;
        if (state == "13" || state =="14")//파 다 자랐을 때
        {
            if (img.sprite == complete)
            {
                Debug.Log("수확성공");
                result.text = (int.Parse(result.text) + 1).ToString();
                //DataController.Instance.gameData.greenOnionNum++;
            }
            img.sprite = initial;
            obj.transform.GetChild(0).GetComponent<Text>().text = "0";
            
        }

        //파 씨앗 클릭 후 파밭을 클릭하는 경우
        else if (int.Parse(seedGNum.text) > 0 && cursorControl.text == "3" && obj.transform.parent.name == "field3" && sp == plowed)
        {
            Debug.Log(this.GetComponent<Button>() + "seed complete");
            img.sprite = seed;
            obj.transform.GetChild(0).GetComponent<Text>().text = "2";
            seedGNum.text = (int.Parse(seedGNum.text) - 1).ToString();
        }

        else if (cursorControl.text == "4")
        {
            parent = transform.parent.gameObject;
            changeImageToWatered();
        }
        else if (cursorControl.text == "5")
        {
            parent = transform.parent.gameObject;
            changeImageToPlowed();
        }




    }
}
