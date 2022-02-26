using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;
public class FindTalk_bench : MonoBehaviour
{
   
    public GameObject Gameoverimg;
    public GameObject headimg;
   
    public TalkEffect talk;
    public GameObject talkUI;
    public void OnClickNextText()
    {
        SceneManager.LoadScene("HideansSeek");

    }
  
    public void ClickGameOver()
    {

        SceneManager.LoadScene("HideansSeek");
        GameManager.FindRoot = 0;
        UIManager.instance.Head += 30;
        UIManager.instance.Main = 70;
        UIManager.instance.LimitTime = 60;

    }
    public void StartTalk()
    {

        talkUI.transform.GetChild(1).gameObject.SetActive(true);
        if (GameManager.FindRoot == 8 || GameManager.FindRoot == 19 || GameManager.FindRoot == 22 || GameManager.FindRoot == 38 || GameManager.FindRoot == 40)
        {
            
            headimg.SetActive(true);
            talk.SetMsg("찾  았  다");
            GameManager.FindRoot++;
            UIManager.instance.Head -= 7;
        }
        else
        {
            if (UIManager.instance.Head >= 100)
            {


                if (UIManager.instance.Main <= 10)
                {
                    Gameoverimg.SetActive(true);
                    
                    talk.SetMsg("정신이 흐려진다..");


                }
                else
                {
                    talk.SetMsg("이 곳에는 오지 않은 것 같다.");
                    UIManager.instance.Main -= 10;
                }


            }
            else
            {

                talk.SetMsg("이 곳에는 오지 않은 것 같다.");
            }

        }
        //img_npc.transform.gameObject.SetActive(true);
    }


    void Start()
    {
       
        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);


        StartTalk();

    }
}
