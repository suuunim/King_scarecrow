using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;
public class FindTalk_mountain : MonoBehaviour
{
    public Text nametagText;
    string a;
    public GameObject Gameoverimg;
    public GameObject headimg;
    public Image fadeimg;
    public TalkEffect talk;
    public GameObject talkUI;
    public void OnClickNextText()
    {
        SceneManager.LoadScene("HideansSeek");

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
        if (GameManager.FindRoot == 5|| GameManager.FindRoot == 17|| GameManager.FindRoot == 28|| GameManager.FindRoot == 30|| GameManager.FindRoot == 43)
        {
            StartCoroutine("FadeAway");
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
            //img_npc.transform.gameObject.SetActive(true);
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
