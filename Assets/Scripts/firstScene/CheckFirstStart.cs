using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckFirstStart : MonoBehaviour
{
    public Button btn_userName;
    public Button btn_gameStart;

    // Start is called before the first frame update
    void Start()
    {
        if(!DataController.Instance.gameData.isFirstTime)//첫시작이 아니라면
        {
            btn_userName.gameObject.SetActive(false);
            btn_gameStart.gameObject.SetActive(true);
        }
    }
}
