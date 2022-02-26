using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class texteffect : MonoBehaviour
{
    public TextMeshProUGUI msgTxt;
    string originText;
    string subText;
    // Start is called before the first frame update
    void Start()
    {

        originText = "GAME OVER\n\n 다시 하시겠습니까? \n▶예 ▶아니오 ";

        StartCoroutine("TypingAction");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator TypingAction()
    {
        for (int i = 0; i < originText.Length; i++)
        {

            yield return new WaitForSeconds(0.4f);

            subText += originText.Substring(0, i);
            msgTxt.text = subText;
            subText = "";
        }
    }
}
