using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_fieldscript : MonoBehaviour
{
    public Text nametagText;
    GameData gd;
    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;
    int MoveToMap = 0;
    public int clickCount = 0;
    public static int spaceCount = 0;
    public int seedNum;

    GameObject npc;
    public GameManager manager;

    string a;
    public Image img_player;
    public Image img_npc;
    public GameObject panel;

    public GameObject backgroud_home;
    public GameObject backgroud_company;

    string[] script_list_1 = new string[] { "돈을 벌려면 거래처가 필요한데.. 그걸 어디서 구하지?", "아! 농사꾼 할아버지께 여쭤볼까? 도움을 주실 수도 있어!" };
    string[] script_list_2 = new string[] { "값을 아주 비싸게 받았어. 거래처 사장에게 한 소리까지 들었다고?", "그럼 지금 수확한 것들도 가져가겠네, 수고해.", "뭔가 이상한데.. 이 값이 말이 돼?", "이장님을 믿고는 싶지만, 이 정도의 돈은 도저히 납득이 안가.","집에 가서 내가 직접 계산해봐야겠어." };
    string[] script_list_3 = new string[] { "차 타고 멀리 나가 보면, 거래처를 찾을 수 있을 거야. 집으로 가자."};
    string[] script_list = new string[] { };

    
    public void OnClickNextText()
    {

        if (MoveToMap == 1)
        {
            clickCount = 0;
            SceneManager.LoadScene("Map");

        }
    }



    public void StartTalk()
    {


        talkUI.transform.GetChild(1).gameObject.SetActive(true);


    }



    public void Start()
    {
        gd = DataController.Instance.gameData;

        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
        if (!(GameManager.Part1 == 7|| GameManager.Part1 == 15|| GameManager.Part1 == 12))
        {
            nametagText.text = "???";
            panel.SetActive(true);
            talkUI.SetActive(true);
            talkUI.transform.GetChild(1).gameObject.SetActive(true);
            img_player.gameObject.SetActive(true);
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];


            }

            talk.SetMsg("이곳에 볼 일은 없다.");
            MoveToMap = 1;

            StartTalk();
        }
      
       
    }

}
