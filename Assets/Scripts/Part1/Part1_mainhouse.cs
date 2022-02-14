using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_mainhouse : MonoBehaviour
{
    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;

    public int clickCount = 0;
    public static int spaceCount = 0;

    GameObject npc;
    public GameManager manager;




    public float FadeTime = 2f;
    float start;
    float end;
    float time = 0f;
    bool isPlaying = false;
    public Image img_player;
    public Image img_npc;
    public Image fadeimg;

    public GameObject backgroud_home;
    public GameObject backgroud_company;

    string[] script_list_1 = new string[] { "귀농했다가 적응 못해서 돌아오기도 한다던데, 그게 내가 되는 건 아니겠지?", "그래도 친해지면 좋으신 분들일 거야. 내가 잘하면 돼지!", " 그런데….. 그 할머님께서 하신 얘기는 뭐였을까. 내가 이 곳을 떠나야 한다고?", "별 일 아닐 거야. 걱정해봤자 할 수 있는 것도 없고.", " 씨앗이고 농기구고 이미 다 샀고, 이만큼 땅값 싼 곳 구하기도 어려워.", " 아휴! 피곤하다. 내일부터는 농사 일 시작해야 하니까… 이제 그만 자자.", "자! 오늘부터 농사 시작이다.", "좋아, 필요한 것들 다 챙겼으니까 이제 밭으로 가자!" };
    string[] script_list_2 = new string[] { "무 하나에 602원, 배추 하나엔 907원, 파는 1205원이고. ", "이걸 계산하면… (무 가격 X 개수 + 배추 가격 X 개수 + 파 가격 X 개수) 원.", "뭐야! 받은 돈이랑 너무 차이가 나는데? 이거 순 사기 아니야!!!!!!!!!!!!", "이장 미친 거 아냐? 내가 그걸 어떻게 수확했는데! 당장 찾아 가서 따져야겠어." };
    string[] script_list_3 = new string[] { "아냐! 너 왜 그래? 신상 터는 것도 모자라 협박까지 한 사람이야.", " 어떻게 다시 찾아가서 사과할 생각을 해? 사과를 받아도 모자랄 판에.", "이 마을 사람들 다 한통 속인 것 같은데... 내가 지금 뭘 할 수 있지?", "회사에 다시 돌아가? 내 편이 하나도 없는 서울로 다시? 그건 더 미친 짓이야..", "내가 여기에 어떻게 왔는데. 빚까지 내서 산 땅인데. 어떻게든 성공해야지.", "이렇게 된 이상 내 힘만으로 돈을 벌어야 해. 그러려면, 농작물을 팔아야 하고.", " 하늘이 무너져도 솟아날 구멍은 있다고. 설마 다른 거래처 하나가 없겠어? ", "내일부터 찾아보자.. 근데 정말 휴대폰 안 터지나?", "… 진짜네.", "휴우.. 무서워하지 말자. 다 괜찮을 거야. 전부 다..", "어제 내가 수확한 것들 이장이 다 가져갔었지.. 치밀한 새끼.", "얼른 수확하고, 차 타고 나가보자. 어디든 좀 정상적인 인간들이 있는 곳으로." };
    string[] script_list_4 = new string[] { "뭐야! 왜 차 키가 없어? 설마 이장이 가져 갔나? 이건 아니지.. 대놓고 범죄잖아.", "내가 미쳤지. 어제 바로 마을을 떠났어야 했어. 어제는 차 키가…….. 없었네. ", "어제도 차 키가 없었어. 허, 이제 난 어떻게 해야 하지? ", "차를 타고 나갈 수도 없고, 휴대폰도 안되고. 완전히 고립돼버렸네.", "저기요, 차 키 찾아요?", "뭐..? 너 혹시! 너가 내 차 키 숨겼니?", "네.", "그거 어디 있어. 당장 내놔!!!!!!!!!!!!!!", "싫은데요.", "차 키 절대 못 찾을 거예요. 내가 당신이라면 찾을 수 없는 곳에 숨겼으니까.", " 그러니 포기해요. 이장한테 반항해봤자 당신만 힘들어져요.", "…", "우리 할머니가 말했을 때, 새겨 들었어야죠. 이제... 돌이킬 수도 없어요.", "농사로 뭘 할 생각도 하지 마요. 어차피 당신은 농사 못 지어요.", "아랫집 사람들이 당신 농기구든 씨앗이든 뭐든 가져갈 거라고 했어요.", "너무 애쓰지 마요.. 당신도 결국 우리처럼 될 거니까. 그럼 수고하세요.", "허..", "하하하하… 다들 제 정신이 아냐. 이 마을은 미쳤어. ", "어떻게든 떠나야 돼. 농사고 뭐고 이제 필요없어. 이러다 나까지 미쳐버릴 거야.", "하아.. 어떻게 떠나야 하지? 도대체 어떻게? 차도 없는데... ", "뛰어 가자. 처음 만나는 사람 하나 붙잡고, 마을 사람들 싹 다 신고해버리자." };
    string[] script_list_5 = new string[] { "어..? ", "여긴 농사꾼 집이잖아!", "청년! 깼어? 갑자기 쓰러져서 내가 얼마나 놀랐는지 몰라.", "당신.. 누구야!? 왜 내가 지금 여기 있어?", "허어... 다짜고짜 반말인 청년은 또 처음이네? ", "당신 누구냐고.. 여긴 농사꾼 집이잖아!", "농사꾼? 아….……… 내 남편이 농사꾼이긴 한데, 영감을 봤어?", "어, 영감 왔수?", "그려, 할멈도 왔구만. 어. 마을 청년도 여기 있네?", "아! 저번에 이장님께서 말씀하신 전입 온다는 그 청년이구만?", "그런데 영감을 아는 모양인가봐. 농사꾼 얘기를 하던데.", "알지. 저 청년도 농사를 짓는대. 내가 이장님께 소개도 시켜드렸고.", "오, 이장님께? 거래는 잘 하고 있, 어디 가나? 청년! 청년!!!" };
    string[] script_list_6 = new string[] { "그 아이 말을 듣는 거야… 너무 애쓰지 말자. ", "아랫집 사람들이 다 가져갔다고 했지. 이장에게 그것들을 들고 가서 빌자.", "그러면 다 괜찮아질 거야…" };
    string[] script_list = new string[] { };

    public void OnClickNextText()
    {



        if (GameManager.Part1 == 6) {

            if (clickCount == 6)
            {

                StartCoroutine("FadeAway");
                //GameManager.Part1++;

            }
            else if (clickCount == 8)
            {
                clickCount = 0;
                GameManager.Part1 = 7;
                SceneManager.LoadScene("Map");

            }
        }
        else if(GameManager.Part1 == 12)
        {
            if (clickCount ==4)
            {
                clickCount = 0;
                GameManager.Part1 = 13;
                SceneManager.LoadScene("Map");

            }
        }
        else if(GameManager.Part1 == 14)
        {
            if (clickCount == 10)
            {
                StartCoroutine("FadeAway");

            }
            else if (clickCount == 12)
            {
                clickCount = 0;
                GameManager.Part1 = 15;
                SceneManager.LoadScene("Map");

            }
        }
        else if (GameManager.Part1 == 16)
        {
            if (clickCount == 21)
            {
                clickCount = 0;
                SceneManager.LoadScene("Load");

            }
        }
        else if (GameManager.Part1 == 18)
        {
            if (clickCount == 3)
            {
                clickCount = 0;
                GameManager.Part1 = 19;
                SceneManager.LoadScene("Map");

            }

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


        string str = script_list[clickCount];




        talk.SetMsg(str);

        clickCount++;

    }



    public void StartTalk()
    {

        fadeimg.enabled = false;
        talkUI.transform.GetChild(1).gameObject.SetActive(true);
        if (GameManager.Part1 == 18)
        {
            StartCoroutine("FadeAway");
        }
        if (GameManager.Part1 == 14)
        {
            StartCoroutine("FadeAway");
        }

    }



    void Start()
    {
       
        //fadeimg.gameObject.SetActive(false);
        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);


        if (GameManager.Part1 == 6)
        {
            talk.SetMsg("다들 쌀쌀하시네. 좀 무섭기도 하고..");
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];

            }

        }
        else if (GameManager.Part1 == 12)
        {
            talk.SetMsg("저번에 내가 무 (처음으로 수확한 무 개수)개, 배추 (처음으로 수확한 배추 개수)개, 파 (처음으로 수확한 파 개수)개를 수확했고. ");
            for (int i = 0; i < script_list_2.Length; i++)
            {

                script_list = script_list_2.Clone() as string[];

            }

        }
        else if (GameManager.Part1 == 14)
        {
            talk.SetMsg("미쳤어.. 지금이라도 가서 사과 드릴까? 내가 말을 심하게 하긴 했잖아! ");
            for (int i = 0; i < script_list_3.Length; i++)
            {

                script_list = script_list_3.Clone() as string[];

            }
        }
        else if (GameManager.Part1 == 16)
        {
            talk.SetMsg("이제 차 타고 나가기만 하면 돼. 휴대폰 없어도 뭐, 차 있으니까 괜찮네.");
            for (int i = 0; i < script_list_4.Length; i++)
            {

                script_list = script_list_4.Clone() as string[];

            }
        }
        else if (GameManager.Part1 == 18)
        {
           
            talk.SetMsg("꿈이 아니네. 나는 이 마을에 갇혔구나. 그래, 그냥 이장에게 협조하자.");
            for (int i = 0; i < script_list_6.Length; i++)
            {

                script_list = script_list_6.Clone() as string[];

            }

        }
        StartTalk();




    }

    IEnumerator FadeAway()
    {

        fadeimg.enabled = true;
        //fadeimg.gameObject.SetActive(true);
        Color color = fadeimg.color;
        for (float i = 1.0f; i >= 0.0f; i -= 0.1f)
        {
            yield return new WaitForSeconds(0.1f);
            color.a = i;                   //i가 내려가면서 선언한 컬러의 알파 값에 참조

            fadeimg.color = color;       //i로 인해 내려간 알파 값을 다시 오브젝트 이미지에 참조

        }
        fadeimg.enabled = false;

    }

    void Awake()
    {


      
       


    }
  
    
}
