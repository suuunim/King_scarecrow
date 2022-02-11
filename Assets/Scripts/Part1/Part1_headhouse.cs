using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_headhouse : MonoBehaviour
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

    string[] script_list_1 = new string[] { "처음 보는데, 자네가 바로 이번에 전입 온 청년인가?", "네, (이름)라고 합니다. 잘 부탁드려요!", "어릴 적부터 시골 마을에서 농사를 지으며 사는 게 꿈이었습니다.", "힘들었던 도시 생활을 접고, 이제 그 꿈을 이뤄보려고 합니다!", "그 꿈 이루도록 내가 많이 도와주지.", "다른 이들과는 인사 안했지? 마을 회관에 있으면 내가 사람들과 함께 가겠네.", "먼저 가있게나." };

    
    public void OnClickNextText()
    {

        

            string str = script_list_1[clickCount];




            talk.SetMsg(str);

            clickCount++;

            if (clickCount == 6)
            {

                GameManager.Part1 = 2;
                SceneManager.LoadScene("Map");

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
