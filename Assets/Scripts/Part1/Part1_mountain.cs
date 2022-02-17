using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_mountain : MonoBehaviour
{
    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;
    int MoveToMap = 0;
    public int clickCount = 0;
    public static int spaceCount = 0;

    GameObject npc;
    public GameManager manager;

    public AudioClip grasssteps;
    public AudioSource audioSource;


    public float FadeTime = 2f;
    float start;
    float end;
    float time = 0f;
    bool isPlaying = false;
    public Image img_player;
    public Image img_npc;
   


    public GameObject scarecrow;
    public GameObject headimg;

    public GameObject backgroud_home;
    public GameObject backgroud_company;
    // Start is called before the first frame update
    string[] script_list_1 = new string[] { "진짜 소원? 당연히 여기서 농사 지으면서 행복하게 사는,", "돈은? 돈 많이 버는 것도 포함이지? 마을 사람들이랑 잘 지내는 것도.", "… 그건 당연한 거지.", "하긴, 그치? 이제 말해줄게… 그 방법은 이장을 네 편으로 삼는 거야.", "어이가 없네.. 난 이미 그 사람이랑 척을 졌다고.", "맞아. 그럼 농사가 성공할 수 있을까? 아니라는 건 이미 경험해서 알 거고.", "이장은 마을에서 신이야! 그의 말 한 마디면 모두가 껌뻑 죽어.", "그런데… 왜 사람들이 이장한테 미쳐 있는지 궁금하지 않아?", "..!?", "나야, 나. ", "마을 수호신 취급을 받는 허수아비 덕분이라고.", "자세한 건 말해주기 힘들지만, 그가 마을을 장악할 수 있었던 이유가 나야.", "난 그에게 특별해. 그런데, 네가 날 들판에서 뽑아 함께 마을을 돌아다닌다?", "아주 불안할 거야. 아까 널 본 마을 사람들 표정 봤어? 이장 보듯이 하더라.", "허수아비가 네 소유가 되어버리면, 마을의 권력은 너한테 옮겨갈 거야.", "그게 이장이 가장 싫어할 일일 거고. 날 지키기 위해 널 찾아오겠지.", "바로 그때, 이장을 우리편으로 삼아서 마구 이용해주는 거지. ", " 봐! 저기 오잖아.", "날 절대 그에게 넘기지마. 대화할 때 무조건 내 얘기를 들어.", "자네, 잠시 나와 얘기 좀 하지? ", "… 예, 그러시죠." };
    
    string[] script_list = new string[] { };


    public void OnClickNextText()
    {

        if (MoveToMap == 1)
        {
            clickCount = 0;
            SceneManager.LoadScene("Map");

        }

        if (GameManager.Part1 == 23)
        {

            if (clickCount == 23)
            {
                clickCount = 0;
                GameManager.Part1 = 24;


            }
            else if (clickCount == 19)
            {
                headimg.SetActive(true);
                scarecrow.SetActive(false);
                playSound("grasssteps");

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

        //fadeimg.gameObject.SetActive(false);
        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);


        if (GameManager.Part1 == 23)
        {
            scarecrow.SetActive(true);
            talk.SetMsg(" 네가 행복해지기 위한 방법은, 그 전에. 너 진짜 소원이 뭐야?");
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];

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

    void playSound(String action)
    {

        switch (action)
        {
            case "grasssteps":
                audioSource.clip = grasssteps;
                break;

          

        }

        audioSource.Play();

    }

    void Awake()
    {




        this.audioSource = GetComponent<AudioSource>();

    }
}
