using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class overmanager : MonoBehaviour
{
    public TextMeshProUGUI msgTxt;
    string originText;
    string subText;

    int click=0;
    public GameObject YesButton;
    
    int endcheck = 0;
    // Start is called before the first frame update
    void Start()
    {
        originText = "GAME OVER\n\n 다시 하시겠습니까?\n▶예 ▶아니오 ";
    }

    // Update is called once per frame
    void Update()
    {
       

           

            if (Input.GetMouseButtonDown(0)&&click==0)
            {
            click++;
            
                StartCoroutine("TypingAction");
            
        }

        if (endcheck == originText.Length - 1)
        {
            YesButton.SetActive(true);

        }





    }

    IEnumerator TypingAction()
    {
        
        for (int i = 0; i < originText.Length; i++)
        {

            yield return new WaitForSeconds(0.4f);
            endcheck = i;
            subText += originText.Substring(0, i);
            msgTxt.text = subText;
            subText = "";
        }
    }
}
