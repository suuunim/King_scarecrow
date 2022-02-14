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

    string[] script_list_1 = new string[] {  "밖에 보니까 농사를 엄청 잘 해 두셨더라고요. 대단하세요!", "…", "제가 이번에 처음 농사 짓는 거라, 이것저것 여쭈러 와도 될까요?", "할아버님을 너무 성가시게 하지는 않겠습니다!", "…", "… 죄송합니다! 편하게 계세요!" };
    string[] script_list_2 = new string[] {  "방금 농작물을 수확했는데, 혹시 이것들 어디에 팔 수 있는지 아시나요?", "거래처를 공유해달라는 게 아니고! 어떻게 구해야 하는지 궁금해서요..", " …", "아이고, 제가 무례했다면 죄송합니다. 이러려는 의도는 아니었는데..", "… 이장님께 가봐. 그 분께 가면 너를 도와줄 거야.", "엇, 감사합니다! 정말 감사해요!" };
    string[] script_list_3 = new string[] { "어..? ", "여긴 농사꾼 집이잖아!", "청년! 깼어? 갑자기 쓰러져서 내가 얼마나 놀랐는지 몰라.", "당신.. 누구야!? 왜 내가 지금 여기 있어?", "허어... 다짜고짜 반말인 청년은 또 처음이네? ", "당신 누구냐고.. 여긴 농사꾼 집이잖아!", "농사꾼? 아….……… 내 남편이 농사꾼이긴 한데, 영감을 봤어?", "어, 영감 왔수?", "그려, 할멈도 왔구만. 어. 마을 청년도 여기 있네?", "아! 저번에 이장님께서 말씀하신 전입 온다는 그 청년이구만?", "그런데 영감을 아는 모양인가봐. 농사꾼 얘기를 하던데.", "알지. 저 청년도 농사를 짓는대. 내가 이장님께 소개도 시켜드렸고.", "오, 이장님께? 거래는 잘 하고 있, 어디 가나? 청년! 청년!!!" };
    string[] script_list = new string[] { };

    public void OnClickNextText()
    {



        if (GameManager.Part1 == 5)
        {
            if (clickCount == 6)
            {
                clickCount = 0;
                SceneManager.LoadScene("Mmainhouse");
                GameManager.Part1++;
            }
        }
        else if (GameManager.Part1 == 8)
        {
            if (clickCount == 6)
            {
                clickCount = 0;
                GameManager.Part1 = 9;
                SceneManager.LoadScene("Map");
            }
        }
        else if (GameManager.Part1 == 17)
        {
            if (clickCount == 13)
            {
                clickCount = 0;
                SceneManager.LoadScene("Load");

            }

        }
        else
        {
            if (clickCount == 6)
            {
                clickCount = 0;
                SceneManager.LoadScene("Map");
                GameManager.Part1++;
            }
        }







        string str = script_list[clickCount];




        talk.SetMsg(str);

        clickCount++;
      




    }



    public void StartTalk()
    {

        
        talkUI.transform.GetChild(1).gameObject.SetActive(true);
       
    
    }



    void Start()
    {

        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);

        if (GameManager.Part1 == 3 || GameManager.Part1 == 4 || GameManager.Part1 == 5)
        {
            talk.SetMsg("안녕하세요. 저 마을 회관에서 뵌 (이름)입니다!");
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];

            }

        }

        if (GameManager.Part1 == 8) {
            talk.SetMsg("어르신! 저번에 인사드린 (이름)입니다. 여쭤 볼 게 있어서 왔어요! ");
            for (int i = 0; i < script_list_2.Length; i++)
            {

                script_list = script_list_2.Clone() as string[];

            }

        }
        else if (GameManager.Part1 == 17)
        {
            talk.SetMsg("아.. 머리야. 여기가 어디지?");
            for (int i = 0; i < script_list_3.Length; i++)
            {

                script_list = script_list_3.Clone() as string[];

            }

        }

        StartTalk();

       


    }

   
}
