using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class TalkManager : MonoBehaviour
{
    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;

    public int clickCount;
    public static int spaceCount = 0;

    GameObject npc;
    public GameManager manager;

    private bool isTask = false;
    private bool choiceMade = false;

    public Image img_player;
    public Image img_npc;

    public void OnClickNextText()
    {
        clickCount++;
        if (isTask == true) talk.SetMsg(manager.npc[manager.npcNow] + "의 일을 도와주는중입니다..." + clickCount);
        else talk.SetMsg("안녕!" + clickCount);
    }

    public void OnClickAct()
    {
        npc = EventSystem.current.currentSelectedGameObject;
        if (npc.name == "ButtonTask") isTask = true;

        ButtonTalk.gameObject.SetActive(false);
        ButtonTask.gameObject.SetActive(false);

        if (isTask == false) Invoke("StartTalk", 1.0f);
        else Invoke("StartTask", 1.0f);
    }

    public void StartTalk()
    {
        choiceMade = true;
        Debug.Log("현재 npc: " + manager.npcNow);
        Debug.Log("현재 npc 이름: " + manager.npc[manager.npcNow]);
        talk.SetMsg(manager.npc[manager.npcNow] + "와의 대화를 시작합니다.");
        talkUI.transform.GetChild(1).gameObject.SetActive(true);
        img_player.transform.gameObject.SetActive(true);
        img_npc.transform.gameObject.SetActive(true);
    }

    public void StartTask()
    {
        choiceMade = true;
        talk.SetMsg("도와준다고? 고마워!");
        talkUI.transform.GetChild(1).gameObject.SetActive(true);
        img_player.transform.gameObject.SetActive(true);
        img_npc.transform.gameObject.SetActive(true);
    }

    void Start()
    {
        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(false);

        img_player.transform.gameObject.SetActive(false);
        img_npc.transform.gameObject.SetActive(false);

        Debug.Log("현재 npc: " + manager.npcNow);
        Debug.Log("현재 npc 이름: " + manager.npc[manager.npcNow]);
        ButtonTalk.transform.GetComponentInChildren<TextMeshProUGUI>().text = manager.npc[manager.npcNow] + "와(과) 대화하기";
        ButtonTask.transform.GetComponentInChildren<TextMeshProUGUI>().text = manager.npc[manager.npcNow] + "를(을) 도와주기";

        ButtonTalk.gameObject.SetActive(true);
        ButtonTask.gameObject.SetActive(true);

        clickCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && choiceMade == true)

        {
            clickCount++;
            if (isTask == true) talk.SetMsg(manager.npc[manager.npcNow] + "의 일을 도와주는중입니다..." + clickCount);
            else talk.SetMsg("안녕!" + clickCount);
        }

    }
}
