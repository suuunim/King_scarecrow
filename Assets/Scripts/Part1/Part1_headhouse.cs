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
    public Button Yes;
    public Button No;
    public Image fadeimg;
    public int clickCount = 0;
    public static int spaceCount = 0;

    GameObject npc;
    public GameManager manager;

    int checkpoint = 0;
    int MoveToMap = 0;
    public Image img_player;
    public Image img_npc;
    
    public GameObject backgroud_home;
    public GameObject backgroud_company;

    string[] script_list_1 = new string[] { "네, (이름)라고 합니다. 잘 부탁드려요!", "어릴 적부터 시골 마을에서 농사를 지으며 사는 게 꿈이었습니다.", "힘들었던 도시 생활을 접고, 이제 그 꿈을 이뤄보려고 합니다!", "그 꿈 이루도록 내가 많이 도와주지.", "다른 이들과는 인사 안했지? 마을 회관에 있으면 내가 사람들과 함께 가겠네.", "먼저 가있게나." };
    string[] script_list_2 = new string[] { " …", "어디 가셨나? 농작물이 상하기 전에 얼른 거래처를 구해야 하는데..", " 마을 회관에 다른 분들과 함께 계시려나? 그 쪽으로 가보자!" };
    string[] script_list_3 = new string[] { "내가 아는 곳이 하나 있긴 하지만, 거기가 어디인지는 자네에게 말해줄 수 없어.", "그 사장이 하도 깐깐해서 나랑만 거래를 하거든.", "아.. 그럼 그 분과 거래할 방법은 없는 건가요?", "딱 하나 있지! 나에게 전권을 맡기는 거야.", "자네가 수확한 농작물을 내게 주면, 내가 팔아 돈을 벌고, 자네에게 나눠 주고.", "어때. 할 만하지?", "혹시 저에게 어느 정도의 수익이 돌아오는지 알 수 있을까요?", "하하! 당찬 청년이네? 내가 설마 다 떼먹겠나.", "농사꾼 할아버지도 나를 통해 거래하고 있어. 돌려줄 만큼 돌려주니 걱정 말게.", "당장 농작물 파는 일이 더 급할 텐데, 빠르게 결정하는 게 좋을 걸?", " (어떡하지.. 급한 상황인 건 맞지만, 과연 나에게 정당한 비율의 돈을 돌려줄까?)" };
    string[] script_list_4 = new string[] {" ... 허락은 개뿔. 마을 회관이 지 소유도 아니고. 그냥 따지러 가자." };
    string[] YesScript = new string[] {"그래, 잘 생각했어. 지금 바로 수확한 농작물을 내게 주게.","내가 거래처에 판 후에 자네를 찾아가겠네. 그동안 열심히 농사 짓고 있으면 돼." };
    string[] NoScript = new string[] { "진심인가? 혼자 거래처를 구하는 건 쉽지 않을 거야.", "우리 마을에서 잘 지내려면 나에게 잘 하는 게 좋을 텐데?","그래? 애석하게도 나는 그 방법을 추천하지 않아." };

    string[] script_list = new string[] { };
    
    public void OnClickNextText()
    {

        

          

        if (MoveToMap == 1)
        {
            SceneManager.LoadScene("Map");

        }

        if (GameManager.Part1 == 11)
        {
            
            if (clickCount == 10)
            {
                Yes.gameObject.SetActive(true);
                No.gameObject.SetActive(true);

            }
        }
        else if (GameManager.Part1 == 13)
        {
            if (clickCount == 1)
            {
                clickCount = 0;
                GameManager.Part1 = 14;
                SceneManager.LoadScene("Map");
            }
        }
        else if (GameManager.Part1 == 1)
        {
            if (clickCount == 6)
            {
                clickCount = 0;
                GameManager.Part1 = 2;
                SceneManager.LoadScene("Map");
            }
        }
        else if (GameManager.Part1 == 9)
        {

            if (clickCount == 3)
            {
                clickCount = 0;
                GameManager.Part1 = 10;
                SceneManager.LoadScene("Map");

            }
        }

        if (checkpoint == 1 && clickCount==2 && GameManager.Part1==11)
        {
            SceneManager.LoadScene("Map");
            GameManager.Part1 = 12;
            clickCount = 0;

        }

        string str = script_list[clickCount];




        talk.SetMsg(str);

        clickCount++;



    }

    public void NoText()
    {
        
       

        talk.SetMsg(NoScript[clickCount%3]);

        clickCount++;

    }

    public void YesText()
    {
        Yes.gameObject.SetActive(false);
        No.gameObject.SetActive(false);
        talk.SetMsg("네! 그렇게 하겠습니다.");
        for (int i = 0; i < YesScript.Length; i++)
        {

            script_list = YesScript.Clone() as string[];

        }
        clickCount = 0;
        checkpoint = 1;
    }

    public void StartTalk()
    {

        fadeimg.enabled = false;
        talkUI.transform.GetChild(1).gameObject.SetActive(true);
        if (GameManager.Part1 == 11)
        {
            StartCoroutine("FadeAway");
        }


    }


    void Start()
    {

        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);


        if (GameManager.Part1 == 1)
        {
            talk.SetMsg("처음 보는데, 자네가 바로 이번에 전입 온 청년인가?");
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];

            }

        }
        else if (GameManager.Part1 == 9)
        {
            talk.SetMsg("왜 이장님이 안계시지? 이장님! 이장님!");
            for (int i = 0; i < script_list_2.Length; i++)
            {

                script_list = script_list_2.Clone() as string[];

            }

        }
        else if (GameManager.Part1 == 11)
        {
            talk.SetMsg("그러니까.. 자네가 농작물을 수확했는데, 팔 곳이 없다 이 말이지?");
            
            for (int i = 0; i < script_list_3.Length; i++)
            {
                
                script_list = script_list_3.Clone() as string[];

            }


        }
        else if (GameManager.Part1 == 13)
        {
            talk.SetMsg("허! 이 인간 또 없네? 이번에도 마을 회관에 있나?");
            for (int i = 0; i < script_list_3.Length; i++)
            {

                script_list = script_list_4.Clone() as string[];

            }
        }
        else
        {
            for (int i = 0; i < script_list_3.Length; i++)
            {

                script_list = script_list_3.Clone() as string[];

            }
            talk.SetMsg("이곳에 볼 일은 없다.");
            MoveToMap = 1;

        }

        StartTalk();

       


    }
    IEnumerator FadeAway()
    {

        fadeimg.enabled = true;
        
        Color color = fadeimg.color;
        for (float i = 1.0f; i >= 0.0f; i -= 0.1f)
        {
            yield return new WaitForSeconds(0.1f);
            color.a = i;                   //i가 내려가면서 선언한 컬러의 알파 값에 참조

            fadeimg.color = color;       //i로 인해 내려간 알파 값을 다시 오브젝트 이미지에 참조

        }
        fadeimg.enabled = false;

    }

}
