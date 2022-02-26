using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class MapManager : MonoBehaviour
{
    public GameObject FarmingIcon;
    public GameObject talkUI;
    public TextMeshProUGUI msgTxt;
    // Start is called before the first frame update
    void Start()
    {


        
        if (GameManager.Part1 == 1)
        {

            msgTxt.text = "이장의 집으로 찾아가 인사드리자!";
           

        }
        else if(GameManager.Part1 == 2)
        {
            msgTxt.text = "마을 주민들을 만나기 위해 마을 회관으로 가자!";
            

        }
        else if (GameManager.Part1 == 3 || GameManager.Part1 == 4 || GameManager.Part1 == 5)
        {
            msgTxt.text = "마을 주민들에게 직접 찾아가 인사드리자!";
            
        }
        else if (GameManager.Part1 == 7)
        {
            msgTxt.text = "가진 씨앗을 전부 이용하여 밭에서 농작물을 수확하자!";
           
            FarmingIcon.SetActive(true);

        }
        else if (GameManager.Part1 ==8)
        {
            msgTxt.text = "농사꾼 할아버지를 찾아가 조언을 얻자!";
           

        }
        else if (GameManager.Part1 == 9 || GameManager.Part1 == 10)
        {
            msgTxt.text = "이장의 도움을 받아 거래처를 구하자!";
            

        }
        else if (GameManager.Part1 == 12)
        {
            msgTxt.text = "이장을 믿고 농작물을 수확하러 가자!";
           
            FarmingIcon.SetActive(true);

        }
        else if(GameManager.Part1 == 13 || GameManager.Part1 == 14)
        {
           
            msgTxt.text = "이장에게 찾아가 강력하게 항의하자!";

        }
        else if(GameManager.Part1 == 15)
        {
            
            msgTxt.text = "가진 씨앗을 전부 이용하여 밭에서 농작물을 수확하자!";
            FarmingIcon.SetActive(true);
        }
        else if (GameManager.Part1 == 16)
        {
            
            msgTxt.text = "차를 타고 마을 밖으로 나가 거래처를 찾자!";
           
        }
        else if (GameManager.Part1 == 19)
        {
            
            msgTxt.text = "아랫집에서 농작물, 농기구, 씨앗을 되찾아오자.";

        }
        else if (GameManager.Part1 == 20)
        {
            
            msgTxt.text = "농기구들을 노란 들판에 버려버리자.";

        }
        else if (GameManager.Part1 == 23)
        {
            
            msgTxt.text = "허수아비와 함께 뒷산으로 가 이장을 기다리자.";

        }
        else
        {
            FarmingIcon.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
