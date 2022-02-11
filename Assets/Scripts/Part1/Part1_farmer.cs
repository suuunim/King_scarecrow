using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_farmer : MonoBehaviour
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

    string[] script_list_1 = new string[] { "안녕하세요. 저 마을 회관에서 뵌 (이름)입니다!", "밖에 보니까 농사를 엄청 잘 해 두셨더라고요. 대단하세요!", "…", "제가 이번에 처음 농사 짓는 거라, 이것저것 여쭈러 와도 될까요?", "할아버님을 너무 성가시게 하지는 않겠습니다!", "…", "… 죄송합니다! 편하게 계세요!" };

    
    public void OnClickNextText()
    {

        

            string str = script_list_1[clickCount];




            talk.SetMsg(str);

            clickCount++;

            if (clickCount == 7)
            {

                GameManager.Part1 = 4;
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
