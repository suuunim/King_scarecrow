using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class OpeningTalk : MonoBehaviour
{
    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;

    public int clickCount=0;
    public static int spaceCount = 0;
    int spacecheck = 0;
    GameObject npc;
    public GameManager manager;
    public Text nametagText;
    string a;
    public SpriteRenderer sp;
    public Transform t_player;
    public Transform t_npc;
    private Sprite player_basic;
    public Sprite player_company;
   
    public GameObject backgroud_home;
    public GameObject backgroud_company;

    string[] script_list;
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space) && spacecheck == 0)
    //    {
    //        OnClickNextText();
    //    }
    //}

    public void OnClickNextText()
    {
        spacecheck = 1;
        if (clickCount == 2)
        {
            nametagText.text = "박과장";
            spacecheck = 1;
            sp.sprite = player_company;
            backgroud_home.SetActive(false);
            backgroud_company.SetActive(true);
            t_npc.gameObject.SetActive(true);
        }

        if (clickCount == 4)
        {
            nametagText.text = a;
            
        }

        if (clickCount == 5)
        {
            sp.sprite = player_basic;
            t_npc.gameObject.SetActive(false);
            backgroud_company.SetActive(false);
            backgroud_home.SetActive(true);
            

        }
       

        if (clickCount == 7) {
            clickCount = 0;

            GameManager.Part1 = 1;
            DataController.Instance.gameData.part1 = GameManager.Part1;
            SceneManager.LoadScene("Map");

        }



        string str = script_list[clickCount];
        talk.SetMsg(str);

        clickCount++;

    }



    public void StartTalk()
    {
        
        //Debug.Log("현재 npc: " + manager.npcNow);
        //Debug.Log("현재 npc 이름: " + manager.npc[manager.npcNow]);
        //talk.SetMsg(manager.npc[manager.npcNow] + "와의 대화를 시작합니다.");
        talkUI.transform.GetChild(1).gameObject.SetActive(true);
        t_player.gameObject.SetActive(true);
        //img_npc.transform.gameObject.SetActive(true);
    }

    

    void Start()
    {
        t_player.gameObject.SetActive(true);
        sp = t_player.gameObject.GetComponent<SpriteRenderer>();
        player_basic = sp.sprite;
        a = DataController.Instance.gameData.userName;
        script_list = new string[]{ "공기도 좋고, 하늘도 맑고. 농사가 아주 잘 될 것 같아.",  "이 곳에서 내 꿈을 이뤄보는 거야! 뭔들 내 도시 생활보단 낫겠지.. 하하.", a + "씨는 정신을 놓고 다니나?", "회사 들어온 지 1년이 넘었는데 아직도 그런 실수를 해!?", "죄송합니다, 죄송합니다… 시정하겠습니다.", "정말 끔찍했어.. 그래도, 여긴 회사가 아니니까! 잘해보자.", "우선 마을 분들께 인사부터 드려야지. 이장님께 먼저 찾아가자!" };
        nametagText.text = a;

        Debug.Log(a);
        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);

        t_player.transform.gameObject.SetActive(false);
        //img_npc.transform.gameObject.SetActive(false);

        //Debug.Log("현재 npc: " + manager.npcNow);
        //Debug.Log("현재 npc 이름: " + manager.npc[manager.npcNow]);
        StartTalk();
       
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space) && choiceMade == true)

    //    {
    //        clickCount++;
            
    //        talk.SetMsg("안녕!" + clickCount);
    //    }

    //}
}
