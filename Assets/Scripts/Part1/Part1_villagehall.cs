using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_villagehall : MonoBehaviour
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

    string[] script_list_1 = new string[] { "신고할 용건이 있습니다. (이름)씨! 이리로 와서 자기 소개해요.", "안녕하세요! 저는 (이름)라고 합니다.", "공기 좋은 마을에서 농사를 지으며 살고 싶어, 마을에 내려오게 되었습니다.", "일손이 부족하시면 저를 불러주세요! 마다 않고 달려가겠습니다.", "아직 농사에 대해 잘 몰라, 이웃 분들께서 많이 도와 주시면 감사하겠습니다.", "여러분들과 함께 즐겁게 지내고 싶어요! 잘 부탁드립니다.", "…", "…", "…", "그래요. 이제 다들 해산해도 됩니다. (이름)씨도 가보세요.", "이 분위기 뭐지.. 내가 뭘 잘못 한 게 있나?", "흐음... 한 분 한 분 직접 찾아가서 인사 드려야겠어.", "농사를 성공적으로 마치려면 그분들의 도움이 꼭 필요해." };


    public void OnClickNextText()
    {


        string str = script_list_1[clickCount];


        
        
        talk.SetMsg(str);

        clickCount++;

        if (clickCount == 13)
        {

            GameManager.Part1 = 3;
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
