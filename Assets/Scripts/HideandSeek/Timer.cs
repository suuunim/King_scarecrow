using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//들어가기전에 저장하고 돌아오면 불러오기(json, static dontdestroy)
//
public class Timer : MonoBehaviour
{

    public float Time;
    public Text text_Timer;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Time = UIManager.instance.LimitTime;
        text_Timer.text = "" + Mathf.Round(Time);
    }
}
