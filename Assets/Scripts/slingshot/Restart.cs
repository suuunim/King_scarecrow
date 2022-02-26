using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SceneChange()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameManager.explaincheck = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
