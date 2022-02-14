using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterInputField : MonoBehaviour
{
    public InputField inputField_name;
    private Button btn_game_start;

    bool check()
    {
        btn_game_start = GameObject.Find("btn_gameStart").GetComponent<Button>();
        if(inputField_name.text.Length > 0 && Input.GetKey(KeyCode.Return))//사용자가 이름을 입력했을 때
        {
            Debug.Log("사용자가 엔터 누름");
            btn_game_start.gameObject.SetActive(true);

        }
        return true;
    }
    // Start is called before the first frame update
    void Update()
    {
        
    }

}
