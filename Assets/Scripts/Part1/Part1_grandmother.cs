using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_grandmother : MonoBehaviour
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

    string[] script_list_1 = new string[] { "안녕하세요. 새로 이사 온 (이름)입니다!", "… 청년은 몇 살이예요?", " 25살입니다!", "6살이나 많구만..", "아, 혹시 손주 분이랑 같이 지내시나요?", "할머니, 언제 들어오세요?", "어.. 손주가 많이 어리네요?", "청년.", "이곳은위험한곳이야.나쁜일에휘말리기전에얼른떠나는게좋을거야.나는이미다늙었고이곳을떠날수도없지만,자네는미래가창창하잖나.그러니내조언을새겨듣기를바라.그래야만청년이정상적으로살아갈수있어.", "꼭.꼭.떠나게나.", "뭐지... 방금?" };

    
    public void OnClickNextText()
    {

        

            string str = script_list_1[clickCount];




            talk.SetMsg(str);

            clickCount++;

            if (clickCount == 11)
            {

                GameManager.Part1++;
                SceneManager.LoadScene("Mmainhouse");

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
