using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class loaduserName : MonoBehaviour
{
    public Text existingUserName;
    // Start is called before the first frame update
    public void clickSetting()
    {
        existingUserName.text = DataController.Instance.gameData.userName;
    }
}
