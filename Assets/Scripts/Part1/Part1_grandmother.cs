using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_grandmother : MonoBehaviour
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


    public Transform t_player;
    public Transform t_grandmother;
    public Transform t_grandchild;

    public GameObject backgroud_home;
    public GameObject backgroud_company;

    string[] script_list_1 = new string[] { "… 청년은 몇 살이예요?", " 25살입니다!", "6살이나 많구만..", "아, 혹시 손주 분이랑 같이 지내시나요?", "할머니, 언제 들어오세요?", "어.. 손주가 많이 어리네요?", "청년.", "이곳은위험한곳이야.나쁜일에휘말리기전에얼른떠나는게좋을거야.나는이미다늙었고이곳을떠날수도없지만,자네는미래가창창하잖나.그러니내조언을새겨듣기를바라.그래야만청년이정상적으로살아갈수있어.", "꼭.꼭.떠나게나.", "뭐지... 방금?" };
    string[] script_list = new string[] { };

    public void OnClickNextText()
    {


        if (MoveToMap == 1)
        {
            clickCount = 0;
            SceneManager.LoadScene("Map");

        }


        if (clickCount == 10)
            {

                
            if (GameManager.Part1 == 5)
            {
                clickCount = 0;
                SceneManager.LoadScene("Mmainhouse");
                GameManager.Part1++;
            }
            else
            {
                clickCount = 0;
                SceneManager.LoadScene("Map");
                GameManager.Part1++;
            }

        }

        if(GameManager.Part1 == 3|| GameManager.Part1 == 4|| GameManager.Part1 == 5)
        {
            if (clickCount == 4)
            {
                //사운드 문열림 추가
                t_grandchild.transform.gameObject.SetActive(true);
                t_grandmother.transform.gameObject.SetActive(false);
            }
            else if (clickCount == 5)
            {

                t_grandchild.transform.gameObject.SetActive(false);
                t_grandmother.transform.gameObject.SetActive(true);
            }
            else if (clickCount == 8)
                t_grandmother.transform.gameObject.SetActive(true);
        }

        if (GameManager.Part1 == 5)
        {
            if (clickCount == 10)
            {
                clickCount = 0;
                SceneManager.LoadScene("Mmainhouse");
                GameManager.Part1++;
            }


        }
        else
        {
            if (clickCount == 10)
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
        string name = DataController.Instance.gameData.userName;

        if (GameManager.Part1 == 3 || GameManager.Part1 == 4 || GameManager.Part1 == 5)
        {
            t_grandmother.transform.gameObject.SetActive(true);
            talk.SetMsg("안녕하세요. 새로 이사 온 "+name+"입니다!");
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

   
}
