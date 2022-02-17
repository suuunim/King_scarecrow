using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FieldTimer : MonoBehaviour
{
    public float[] rTimer = new float[6];
    public float[] cTimer = new float[6];
    public float[] gTimer = new float[6];
    Transform target;
    Image img;
    Text txt;
    public Sprite completeR;
    public Sprite completeC;
    public Sprite completeG;

    public Sprite rottenR;
    public Sprite rottenC;
    public Sprite rottenG;

    Scene scene;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    private void Start()
    {
        Debug.Log("FieldTimer is initialized");
        for (int i = 0; i < 6; i++)
            rTimer[i] = 0.0f;
        for (int i = 0; i < 6; i++)
            cTimer[i] = 0.0f;
        for (int i = 0; i < 6; i++)
            gTimer[i] = 0.0f;
    }
    
    private void timesUpR(int i)
    {
        rTimer[i] = 0.0f;
        GameData gd = DataController.Instance.gameData;
        int num = gd.seedRArr[gd.seedRNum--];
        int p = Random.Range(1, 100);
        if (SceneManager.GetActiveScene().name == "Farming")
        {
            target = GameObject.Find("field1").transform.GetChild(i);
            img = target.GetComponent<Image>();
            txt = target.GetChild(0).GetComponent<Text>();

            if (p <= num)
            {
                img.sprite = completeR;
                txt.text = "6";
            }
            else
            { 
                img.sprite = rottenR;
                txt.text = "7";
            }

        }
        else//농사게임 화면이 아닐 때 작물이 다 자란 경우
        {
            Debug.Log(i + "무가 농사게임 아닌곳에서 작물이 다자람");
            if (p <= num)
                gd.fieldR[i] = 6;
            else
                gd.fieldR[i] = 7;

        }
    }

    private void timesUpC(int i)
    {
        cTimer[i] = 0.0f;
        GameData gd = DataController.Instance.gameData;
        int num = gd.seedCArr[gd.seedCNum--];
        int p = Random.Range(1, 100);
        if (SceneManager.GetActiveScene().name == "Farming")
        {
            target = GameObject.Find("field2").transform.GetChild(i);
            img = target.GetComponent<Image>();
            txt = target.GetChild(0).GetComponent<Text>();

            
            if (p <= num)
            {
                txt.text = "10";
                img.sprite = completeC;
            }
            else
            {
                txt.text = "11";
                img.sprite = rottenC; 
            }
        }
        else//농사게임 화면이 아닐 때 작물이 다 자란 경우
       {
            Debug.Log(i + "배추가 농사게임 아닌곳에서 작물이 다자람");
            if (p <= num)
               gd.fieldC[i] = 10;
           else
               gd.fieldC[i] = 11;

       }
    }

    private void timesUpG(int i)
    {
        gTimer[i] = 0.0f;
        GameData gd = DataController.Instance.gameData;
        int num = gd.seedGArr[gd.seedGNum--];
        int p = Random.Range(1, 100);
        if (SceneManager.GetActiveScene().name == "Farming")
        {
            target = GameObject.Find("field3").transform.GetChild(i);
            img = target.GetComponent<Image>();
            txt = target.GetChild(0).GetComponent<Text>();
            txt.text = "13";

            if (p <= num)
            { 
                img.sprite = completeG;
                txt.text = "13";
            }

            else
            {
                img.sprite = rottenG;
                txt.text = "14";
            }
        }
        else//농사게임 화면이 아닐 때 작물이 다 자란 경우
         {
            Debug.Log(i + "파가 농사게임 아닌곳에서 작물이 다자람");
            if (p <= num)
              gd.fieldG[i] = 13;
          else
              gd.fieldG[i] = 14;

         }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 6; i++)
        {

            if (rTimer[i] >= 6)
                timesUpR(i);
            

            else if (rTimer[i] >= 3)
            { 
                rTimer[i] += Time.deltaTime;
                Debug.Log(rTimer[i]);
            }

            if (cTimer[i] >= 10)
                timesUpC(i);

            else if (cTimer[i] >= 3)
            {
                cTimer[i] += Time.deltaTime;
                Debug.Log(cTimer[i]);
            }

            if (gTimer[i] >= 13)
                timesUpG(i);

            else if (gTimer[i] >= 3)
            {
                gTimer[i] += Time.deltaTime;
                Debug.Log(gTimer[i]);
            }



        }
    }
}
