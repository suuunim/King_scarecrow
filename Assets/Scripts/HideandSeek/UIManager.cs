using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{

    public static UIManager instance = null;
    public GameObject Restart_btn;

    // Start is called before the first frame update
    private void Awake()
    {

        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
           

        }
        else
        {

            if (instance != this)
                Destroy(this.gameObject);
            

        }

    }

    void Start() {

        
    }

    
    // Update is called once per frame
    void Update()
    {
        LimitTime -= Time.deltaTime;
        if (Mathf.Round(LimitTime) == -1)
        {

            Head += 5;
            if (Head <= 30)
                LimitTime = 30;
            else if (Head <= 10)
                LimitTime = 15;
            else
                LimitTime = 60;


           

        }

        if (Main <= 0) {

            
            Time.timeScale = 0;
        }

    }

    public void restart()
    {
        
        LimitTime = 30;
        instance.Main = 70;
        instance.Head += 30;
        GameManager.FindRoot = 0;



    }

    public int Main = 100;
    public int Head = 70;
    public float LimitTime;

}
