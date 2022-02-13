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
        if (SceneManager.GetActiveScene().name == "Farming")
        {
            target = GameObject.Find("field1").transform.GetChild(i);
            img = target.GetComponent<Image>();
            txt = target.GetChild(0).GetComponent<Text>();
            txt.text = "6";

            //씨앗 배열, 씨앗의 갯수 각각 json에 저장해두기
            //씨앗 배열에 저장된 확률에 따라 성공 또는 실패

            /*
             int num = json무씨앗배열[json에서 씨앗갯수 가져온거];
             if(Random.Range(1, 100) <= num)
            {
            img.sprite = completeR;
            json에서 수확물 결과 저장하기
            수확한 작물 개수 텍스트 바꾸기
            //성공
            }
            else
            {
            fail;
            }
             */
            int num = 50;
            if (Random.Range(1, 100) <= num)
                img.sprite = completeR;
            
            else
                img.sprite = rottenR;

        }
    }

    private void timesUpC(int i)
    {
        cTimer[i] = 0.0f;
        if (SceneManager.GetActiveScene().name == "Farming")
        {
            target = GameObject.Find("field2").transform.GetChild(i);
            img = target.GetComponent<Image>();
            txt = target.GetChild(0).GetComponent<Text>();
            txt.text = "10";

            //씨앗 배열, 씨앗의 갯수 각각 json에 저장해두기
            //씨앗 배열에 저장된 확률에 따라 성공 또는 실패

            /*
             int num = json무씨앗배열[json에서 씨앗갯수 가져온거];
             if(Random.Range(1, 100) <= num)
            {
            img.sprite = completeR;
            json에서 수확물 결과 저장하기
            수확한 작물 개수 텍스트 바꾸기
            //성공
            }
            else
            {
            fail;
            }
             */
            int num = 50;
            if (Random.Range(1, 100) <= num)
                img.sprite = completeC;

            else
                img.sprite = rottenC;

        }
    }

    private void timesUpG(int i)
    {
        gTimer[i] = 0.0f;
        if (SceneManager.GetActiveScene().name == "Farming")
        {
            target = GameObject.Find("field3").transform.GetChild(i);
            img = target.GetComponent<Image>();
            txt = target.GetChild(0).GetComponent<Text>();
            txt.text = "13";

            //씨앗 배열, 씨앗의 갯수 각각 json에 저장해두기
            //씨앗 배열에 저장된 확률에 따라 성공 또는 실패

            /*
             int num = json무씨앗배열[json에서 씨앗갯수 가져온거];
             if(Random.Range(1, 100) <= num)
            {
            img.sprite = completeR;
            json에서 수확물 결과 저장하기
            수확한 작물 개수 텍스트 바꾸기
            //성공
            }
            else
            {
            fail;
            }
             */
            int num = 50;
            if (Random.Range(1, 100) <= num)
                img.sprite = completeG;

            else
                img.sprite = rottenG;

        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 6; i++)
        {

            if (rTimer[i] >= 6)
            {
                timesUpR(i);
                //json파일의 배열값 변화시키기
            }

            else if (rTimer[i] >= 3)
            { 
                rTimer[i] += Time.deltaTime;
                Debug.Log(rTimer[i]);
            }

            if (cTimer[i] >= 10)
            {
                timesUpC(i);
                //json파일의 배열값 변화시키기
            }

            else if (cTimer[i] >= 3)
            {
                cTimer[i] += Time.deltaTime;
                Debug.Log(cTimer[i]);
            }

            if (gTimer[i] >= 13)
            {
                timesUpG(i);
                //json파일의 배열값 변화시키기
            }

            else if (gTimer[i] >= 3)
            {
                gTimer[i] += Time.deltaTime;
                Debug.Log(gTimer[i]);
            }



        }
    }
}
