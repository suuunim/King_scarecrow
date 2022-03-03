using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameSetting : MonoBehaviour
{
    public InputField _userName;
    // Start is called before the first frame update
    public void clickGameStart()
    {
        
        Debug.Log(_userName.text);
        if (DataController.Instance.gameData.isFirstTime)//첫 시작일때
        {
            DataController.Instance.gameData.userName = _userName.text;
            DataController.Instance.gameData.isFirstTime = false;
            SceneManager.LoadScene("Opening");
        }

        else//첫시작이 아닐 때
        {
            GameManager.Part1 = DataController.Instance.gameData.part1;
            if (GameManager.Part1 == 0)
            {
                SceneManager.LoadScene("Opening");
            }
            else {
                SceneManager.LoadScene("Map");
            }
            
        }
    }
}
