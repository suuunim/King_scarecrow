using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_downstairs : MonoBehaviour
{
    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;

    public int clickCount = 0;
    public static int spaceCount = 0;

    GameObject npc;
    public GameManager manager;


    public Image img_player;
    public Image img_npc;

    public GameObject backgroud_home;
    public GameObject backgroud_company;

    string[] script_list_1 = new string[] { "안녕하세요! 저 아까 마을 회관에서 인사 드린 (이름)입니다.", "여긴 왜 왔수?", "한 분 한 분께 제대로 인사 드리러 왔습니다.", "위쪽 집에 살고 있는데, 잘 부탁드려요!", " 어! 안녕? 새로 이사 온 사람이야. 잘 부탁해!", "뭘 꼬라 봐요?", "우리 딸, 왔어? 밥 먹어야지.", "이제 좀 가시죠? 가족끼리 밥 좀 먹고 싶은데.", "아이고, 죄송합니다. 밥 맛있게 드세요!" };

    
    public void OnClickNextText()//다음으로 넘어가는 버튼 클릭 시 실행되는 함수
    {

        

            string str = script_list_1[clickCount];




            talk.SetMsg(str);

            clickCount++;

            if (clickCount == 9)//9번째 즉 string리스트 전부 끝나면 
            {

                GameManager.Part1++;
                SceneManager.LoadScene("Map");//다음 맵으로 넘어가도록

            }
        
        
        //if (clickCount == 2)
        //{
        //    backgroud_home.SetActive(false);
        //    backgroud_company.SetActive(true);
        //}

        //if (clickCount == 7)
        //{
        //    backgroud_company.SetActive(false);
        //    backgroud_home.SetActive(true);


        //}




    }



    public void StartTalk()
    {

        
        talkUI.transform.GetChild(1).gameObject.SetActive(true);
       
    
    }



    void Start()
    {

        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);


        
        StartTalk();

       


    }

   
}
