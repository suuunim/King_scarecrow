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

    GameObject npc;
    public GameManager manager;

   

    public Image img_player;
    public Image img_npc;
    static string a = "수아";
    public GameObject backgroud_home;
    public GameObject backgroud_company;

    string[] script_list;


    public void OnClickNextText()
    {
        if (clickCount == 2)
        {
            backgroud_home.SetActive(false);
            backgroud_company.SetActive(true);
        }

        if (clickCount == 7)
        {
            backgroud_company.SetActive(false);
            backgroud_home.SetActive(true);
            

        }
       

        if (clickCount == 11) {
            clickCount = 0;
            GameManager.Part1 = 1;
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
        img_player.transform.gameObject.SetActive(true);
        //img_npc.transform.gameObject.SetActive(true);
    }

    

    void Start()
    {
        a = DataController.Instance.gameData.userName;
        script_list = new string[]{ "공기도 좋고, 하늘도 맑고. 농사가 아주 잘 되겠어. 이 곳에서는 내 꿈을 이룰 수 있을 거야!", "뭔들 내 도시 생활보다는 낫겠지.. 하하.", a + "씨는 정신을 놓고 다니나? 회사 들어온 지 1년이 넘었는데 아직도 그런 실수를 하면 어떡해!?", "죄송합니다, 죄송합니다… 시정하겠습니다.", a + "씨. 이건 지난 달에도 말해주지 않았나?" + a + "씨 때문에 나까지 욕먹고 이게 뭐지? ", "거래처 분들께 사과 말씀드리고 수정해서 다시 보내 드려요.", "네, 알겠습니다. 바로 전화 드리겠습니다.", "어우, 진짜 끔찍했다. 내가 일을 더럽게 못하긴 했어.", "근데 지금 난 퇴사했잖아? 이번에는 잘해보자! 여기서 내 꿈을 이루는 거야. ", "짐 정리는 끝냈으니까… 마을 분들께 인사부터 드려야겠다. ", "이장님께 먼저 찾아가자!" };
        
        Debug.Log(a);
        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);

        img_player.transform.gameObject.SetActive(false);
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
