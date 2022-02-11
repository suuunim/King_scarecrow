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
        DataController.Instance.gameData.userName = _userName.text;
        if (DataController.Instance.gameData.isFirstTime)//첫 시작일때
        {
            DataController.Instance.gameData.isFirstTime = false;
            SceneManager.LoadScene("Opening");
        }

        else//첫시작이 아닐 때
        {
            //SceneManager.LoadScene("Gameplay");
        }
    }
}
