using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_field : MonoBehaviour
{
    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;
    public Button Yes;
    public Button No;
    public int clickCount = 0;
    public static int spaceCount = 0;

    GameObject npc;
    public GameManager manager;

    int MoveToMap = 0;
    public GameObject scarecrow;
    //public Image img_scarecrow;


    string[] script_list_1 = new string[] { "… 뭐지?", "불쌍하네.", "누구야.. 내가 모르는 마을 주민이 또 있는 거야? 어우, 질린다 질려.", "멍청한 놈. 바로 네 옆에 있잖아.", "내 옆에..? 허수아비 밖에 없는데.", "그래, 허수아비.", " 내가 허수아비야. 안녕?", "으아아아아아악!!!!!!!!!!!!!!!!!!", "이젠 하다하다 헛것까지 들리네. 마을 덕분에 내 정신이 멀쩡하지가 않아요…", "날 못 믿는 구나? 난 헛것 아닌데.", "제발.. 마음의 소리야, 조용히 좀 해줄래?", "나는 너의 마음의 소리가 아니라, 생명이 있는 허수아비라니까!", "이야.. 그럼 내가 지금 살아 있는 허수아비랑 대화를 하고 있는 거네?", "응! 어떻게 하면 내 말을 믿을 거야?", "네가 살아 있다는 증거를 대봐. 이게 내 망상이 아니라는 걸 증명해보라고.", "음… 네 차 키가 어디 있는지 궁금하지 않아?", "뭐? 네가 내 차 키 일을 어떻게 알아?", "내가 허수아비라, 여기 쭉 서있거든. 그럼 마을의 시시콜콜한 일을 좀 알게 돼. ", "차 키 찾아주면, 내 말 믿을래? 내가 살아 있다는 걸 증명하는 거잖아.", "살아 있는 마을 사람 말을 들어서, 너한테 알려준 거니까!", "(만약 이 허수아비가 정말 내 차 키의 행방을 안다면?", "물론, 이게 내 망상일 확률이 크지. 그런데, 만약 진짜라면.", "정말 살아 있는 허수아비라서 마을의 일을 많이 아는 거라면. ", "손해 보는 장사는 아냐. 찾으면 좋고. 못 찾으면, 환청인 게 증명되는 거니까. )", "그래! 너를 한 번 믿어볼게. 내 차 키 어디 있어?", "내 발 밑에.", "와, 정말이네..? 내 차 키가 네 발 밑에 있었어.", "하하하! 지금 이게 내 망상은 아니구나? 허수아비가 생명인 게 진짜.. 맞구나? ", "그래.. 나도 생명이라니까? 보다시피 허수아비라 팔은 못 흔들지만, 안녕! ", "너 이제 그 차 키로 뭘 할 거야? 또 도망칠 거야?", "당연하지. 내가 지금 뭘 할 수 있는데? 이 마을은.. 확실히 이상해! 떠나야 돼.", "맞아, 이 마을은 이상해. 그런데… 너 여기 왜 왔어?", "공기 좋은 마을에서 농사 지으며 살고 싶었던 거 아냐? 이걸 전부 포기하게?", "그래.. 그건 내 꿈이지. 하지만 그 꿈을 이 곳에서 이루는 건 불가능해.", "내가 도와줄게. ", "내 도움을 받으면, 넌 이 마을에서 제 정신으로 네 꿈을 이룰 수 있어.", "나도 이장 싫어해.. 우린 같은 마음을 가지고 있다고?", "마을 사람들 전부 이장에게 미쳐 있던데, 너는 싫어하는 게 신기하네.", " 딱 봐도 이상하잖아. 그런 인간에게 미쳐 있는 사람들이 더 제정신 아니지.", "너 절망하고 있었잖아. 마을에 질려서 꿈도 버리고, 인생을 포기하려고 했잖아.", "내가 그 절망을 희망으로 바꿔줄게.. 어때? 나랑 친구 한 번 해볼래?", "내가 정말 힘들긴 했나봐. 살아 있는 허수아비랑 친구하고 싶어지네.", "그래! 여기서 내 꿈 이뤄보지 뭐. 어차피 다시 서울로 가봤자, 빚 밖에 없어.", "차 키도 있으니까 좀 위험해지면 도망가면 되는 거 아냐?", "그래! 이제야 좀 사람 같네. 제 정신으로 꿈 이루자, 나랑.", "반가워, 친구야!", "내 이름은 (이름)이야, 친구야. 허.. 허수아비한테까지 자기 소개를 하네.", "그래서 내가 어떻게 해야 제 정신으로 꿈을 이룰 수 있는데?", "음.. 근데... 그 전에 내 부탁 하나만 들어줘.", "뭐? 너도 나 협박하려고 그러는 거지?", "아냐! 절대 아냐! 나는 이장처럼 미치지 않았다니까?", "내 부탁은 정말 사소해. 부러진 팔 좀 고쳐줘. 참새가 자꾸 쪼아대서 아프다..", "아.. 그런 거였어? 마을 사람들한테 너무 데여서 그래, 미안해.", "괜찮아.. 그럼, 내 부탁 들어줄 거지?", "괜찮아.. 그럼, 내 부탁 들어줄 거지?" };
    string[] script_list = new string[] { };

    // Start is called before the first frame update
    string[] script_list_2 = new string[] {  " 다행이다.. 혹시 또 부탁할 거 있으면 말해! 내가 해줄게.", "응, 당연하지.. 이제 내가 너의 꿈을 이루는 방법을 알려줄게!", "나를 뽑아서 들고 뒷산으로 가. 그러면 이장이 너를 찾아올 거야.", "그게 다야? 너를 데리고 뒷산으로 가면… 이장이 나를 찾아온다고.", "왜? 이장도 너가 생명이라는 걸 알아?", "그리고.. 이장이 나를 찾아오는 게 왜 내 꿈을 이루는 방법이야?", "이장은 내가 생명이 있다는 걸 몰라. 그리고 우린 이장을.. 이용해야 해.", "나 네 말이 잘 이해가 안가. 앞은 그렇다 치고, 그 자를 어떻게 이용하는데?", "그게 왜 내가 행복해지기 위한 방법이냐니까?", "음, 말하자면 긴데.. 자세한 건 뒷산에 갔을 때 얘기해 줘도 돼?", "왜, 내 말에 믿음이 안가? 너가 차 키를 찾은 게 누구 덕분이더라?", "못 믿겠으면 도망쳐. 내가 찾아준 차 키를 이용해서. 친구까지 버리고 즐겁겠다.", "야, 뭘 또 말을 그렇게 해.. 내가 언제 도망간대? 난 널 믿어.", "뒷산으로 가자!" };
    string[] NoScript = new string[] {"친구야.. 한 번만 다시 생각해주면 안될까?","우리 마을에서 지내려면 나를 믿는 게 좋을 텐데?","나는 살아 있는 허수아비라 고통을 느낄 수 있어." };

    public void OnClickNextText()//다음으로 넘어가는 버튼 클릭 시 실행되는 함수
    {
        if (MoveToMap == 1)
        {
            clickCount = 0;
            SceneManager.LoadScene("Map");

        }

        if (GameManager.Part1 == 20)
        {
            if (clickCount == 54)
            {
                GameManager.Part1 = 21;
                Yes.gameObject.SetActive(true);
                No.gameObject.SetActive(true);
            }
            else if (clickCount == 6)
            {
                scarecrow.SetActive(true);
            }
            else if (clickCount == 55)
            {
                clickCount = 54;
            }



        }
        else if(GameManager.Part1 == 22)
        {
            if(clickCount == 14)
            {
                clickCount = 0;
                SceneManager.LoadScene("Map");
                GameManager.Part1 = 23;
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

    public void NoText()
    {



        talk.SetMsg(NoScript[clickCount % 3]);

        clickCount++;

    }

    public void YesText()
    {
        Yes.gameObject.SetActive(false);
        No.gameObject.SetActive(false);

        SceneManager.LoadScene("Slingshot");
        GameManager.Part1 = 21;
        clickCount = 0;
        
    }

    void Start()
    {

        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);

        if (GameManager.Part1 == 20)
        {
            talk.SetMsg("미친 놈.");
            for (int i = 0; i < script_list_1.Length; i++)
            {
                
                script_list = script_list_1.Clone() as string[];


            }

        }
        else if (GameManager.Part1 == 22)
        {
            scarecrow.SetActive(true);
            talk.SetMsg("와, 너무 고마워. 나 이제 팔이 아프지가 않아!! 너 덕분이야, "+ DataController.Instance.gameData.userName+ "아!!!!");
            for (int i = 0; i < script_list_2.Length; i++)
            {

                script_list = script_list_2.Clone() as string[];


            }

        }
        else
        {
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
