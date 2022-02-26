using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_Load : MonoBehaviour
{
    public Text nametagText;
    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;
    int MoveToMap = 0;
    public int clickCount = 0;
    public static int spaceCount = 0;

    GameObject npc;
    public GameManager manager;
    public AudioClip engine;
    public AudioSource audioSource;

    public GameObject farmer_F;
    string a;
    public GameObject mainface;
    public GameObject backgroud_home;
    public GameObject backgroud_company;

    string[] script_list_1 = new string[] { "이젠 휴대폰 배터리마저 없네. 이제 진짜 힘든데..", "어디 지나가는 사람 한 명만 나타났으면 좋겠다. 아무나라도 제발 좀..", "청년!", " 어… 와, 사람이다.", "여기서 뭐하고 있어? 상태가 많이 안 좋아보이는데, 내가 좀 도와줘?", "네.. 네!!!!! 감사합니다. 정말 감사해요..", "차에 좀 타도 될까요? 제가 지금 너무 힘들어서요.", "그럼! 얼른 타." };
    string[] script_list_2 = new string[] { "이건 꿈일 거야. 집에 가서 잤다가 깨면, 나는… 다른 곳에 있을 거야. 제발." };
    string[] script_list = new string[] { };

    void Awake()
    {




        this.audioSource = GetComponent<AudioSource>();

    }

    public void OnClickNextText()
    {



        if (MoveToMap == 1)
        {
            clickCount = 0;
            SceneManager.LoadScene("Map");

        }



        if (GameManager.Part1 == 16)
        {

            if (clickCount == 8)
            {
                clickCount = 0;
                GameManager.Part1 = 17;
               
                SceneManager.LoadScene("Mfarmer");
            }
            else if (clickCount == 2)
            {
                nametagText.text = "???";
                farmer_F.SetActive(true);
                playSound("engine");
            }
            else if (clickCount == 3)
            {
                nametagText.text = a;
                mainface.SetActive(false);
            }
            else if (clickCount == 4)
            {
                nametagText.text = "???";
            }
            else if (clickCount == 5)
            {
                nametagText.text = a;
            }
            else if (clickCount == 7)
            {
                nametagText.text = "???";
            }




        }
        else if (GameManager.Part1 == 17)
        {

            if (clickCount == 1)
            {
                clickCount = 0;
                GameManager.Part1 = 18;
               
                SceneManager.LoadScene("Mmainhouse");
            }


        }


        string str = script_list[clickCount];




        talk.SetMsg(str);

        clickCount++;




    }


    void playSound(String action)
    {

        switch (action)
        {
            case "engine":
                audioSource.clip = engine;
                break;



        }

        audioSource.Play();

    }
    public void StartTalk()
    {


        talkUI.transform.GetChild(1).gameObject.SetActive(true);


    }



    void Start()
    {
        a= DataController.Instance.gameData.userName;
        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);

        if (GameManager.Part1 == 16)
        {
            nametagText.text = a;
            mainface.SetActive(true);
            talk.SetMsg("지금이 몇 시지. 도대체 얼마나 걸은 걸까. 목도 마르고, 다리도 아프고..");
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];

            }

        }
        else if (GameManager.Part1 == 17)
        {
            nametagText.text = a;
            mainface.SetActive(true);
            farmer_F.SetActive(false);
            talk.SetMsg("허… 정신 나간 마을 주민이 한 명 더 있었어! 돌고 돌아 또 이 마을이라니.");
            for (int i = 0; i < script_list_2.Length; i++)
            {

                script_list = script_list_2.Clone() as string[];

            }
        }
        else
        {
            nametagText.text = a;
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];


            }
            talk.SetMsg("이곳에 볼 일은 없다.");
            MoveToMap = 1;

        }



        StartTalk();




    }
}
