using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(gameObject);
    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        gameObject.SetActive(false);
        UIManager.instance.LimitTime = 30;
        UIManager.instance.Main = 70;
        UIManager.instance.Head += 30;
        GameManager.FindRoot = 0;



    }
}
