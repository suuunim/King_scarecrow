using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;
public class FindTalk_abandoned : MonoBehaviour
{
    string a;
    public GameObject Gameoverimg;
    public GameObject headimg;
    public Text nametagText;
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
        if (GameManager.FindRoot == 9 || GameManager.FindRoot == 15 || GameManager.FindRoot == 23 || GameManager.FindRoot == 33 || GameManager.FindRoot ==41)
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

                    
                    talk.SetMsg("정신이 흐려진다..");
                    Gameoverimg.SetActive(true);

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
        a = DataController.Instance.gameData.userName;
        nametagText.text = a;
        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);


        StartTalk();

    }
}
