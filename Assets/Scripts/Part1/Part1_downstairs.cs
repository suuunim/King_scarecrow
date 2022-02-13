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

    string[] script_list_1 = new string[] {  "여긴 왜 왔수?", "한 분 한 분께 제대로 인사 드리러 왔습니다.", "위쪽 집에 살고 있는데, 잘 부탁드려요!", " 어! 안녕? 새로 이사 온 사람이야. 잘 부탁해!", "뭘 꼬라 봐요?", "우리 딸, 왔어? 밥 먹어야지.", "이제 좀 가시죠? 가족끼리 밥 좀 먹고 싶은데.", "아이고, 죄송합니다. 밥 맛있게 드세요!" };
    string[] script_list_2 = new string[] { "아닌데요.", "거짓말 하지마. 다른 집 아이한테서 다 들었어.", "그걸로 나쁜 짓 할 거 아니야. 이장님께 사과하러 가는 거야. ", "아, 그럼 뭐.. 근데 어쩌죠? 가져온 농작물은 다 불태워버렸는데.", "농기구들이나 씨앗은 가져가셔도 돼요. 저쪽에 놔뒀어요.", "다... 불태웠다고? 미쳤구나, 다들.", " 너희 도대체 이장에게 왜 이렇게 맹목적으로 구는 거야? 그 사람이 뭐라고.. ", "아니지, 그 자는 사람도 아냐. 다들 정신 좀 차려. 이건 정상이 아니라고!!!!!!!", "웬 급발진? 저희가 왜 이러는지는, 모르겠는데요? ", "더 드릴 말씀은 없네요. 농기구 가져가실 거면 가져가시고, 아님 마세요. ", " 제가 고3이라 공부해야 돼서, 이만.", "망했네. 그래.. 이장 니가 이겼다. ", "농기구들이 다 무슨 소용이야. 들판에다 버려버리자. 다 포기하자." };
    string[] script_list = new string[] { };

    public void OnClickNextText()//다음으로 넘어가는 버튼 클릭 시 실행되는 함수
    {

        

        if (GameManager.Part1 == 5)
        {
            if (clickCount == 8)
            {
                clickCount = 0;
                SceneManager.LoadScene("Mmainhouse");
                GameManager.Part1++;
            }
        }
        else if(GameManager.Part1 == 19)
        {
            if (clickCount == 13)
            {

                clickCount = 0;
                SceneManager.LoadScene("Map");
                GameManager.Part1 = 20;
            }
        }
        else
        {
            if (clickCount == 8)
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
            talk.SetMsg("안녕하세요! 저 아까 마을 회관에서 인사 드린 (이름)입니다.");
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];
               

            }

        }
        else if (GameManager.Part1 ==19)
        {
            talk.SetMsg("저기.. 너희 가족이 내 농작물이랑 농사 도구들 다 가져갔지?");
            for (int i = 0; i < script_list_2.Length; i++)
            {

                script_list = script_list_2.Clone() as string[];


            }

        }

        StartTalk();

       


    }

   
}
