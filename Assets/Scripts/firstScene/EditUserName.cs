using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditUserName : MonoBehaviour
{
    public InputField newUserName;
    public Text txt_newName;
    public void clickEdit()
    {
        DataController.Instance.gameData.userName = newUserName.text;
        txt_newName.text = newUserName.text;
    }
}
