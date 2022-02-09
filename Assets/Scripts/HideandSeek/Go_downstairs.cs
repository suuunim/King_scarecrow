using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Go_downstairs : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("downstairs");
    }
}
