using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TalkEffect : MonoBehaviour
{
    public int CharPerSeconds;
    public GameObject EndCursor;
    string targetMsg;
    public TextMeshProUGUI msgTxt;
    int index;
    float interval;

    public void SetMsg(string msg)
    {
        
        targetMsg = msg;
        EffectStart();
    }

    void EffectStart()
    {
        msgTxt.text = "";
        index = 0;
        EndCursor.SetActive(false);

        interval = 1.0f / CharPerSeconds;
        Invoke("Effecting", interval);
    }

    void Effecting()
    {
        if(msgTxt.text == targetMsg)
        {
            EffectEnd();
            return;
        }
        msgTxt.text += targetMsg[index];
        index++;
        Invoke("Effecting", interval);
    }

    void EffectEnd()
    {
        EndCursor.SetActive(true);
    }
}
