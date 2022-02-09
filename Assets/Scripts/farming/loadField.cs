using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadField : MonoBehaviour
{
    public Sprite initial;
    public Sprite plowed;
    public Sprite seed_r;
   /* public Sprite seed_c;
    public Sprite seed_g;*/
    public Sprite completed_r;
    /*public Sprite completed_c;
    public Sprite completed_g;*/
    //밭 한칸 한칸의 상태를 로드해주는 함수
    //0 기본 상태
    //1 밭이 갈아진 상태
    //2 씨앗이 심어진 상태
    //3 물을 준 상태
    //4 ~ 초 흐름

    void loadFieldR(int[] arr)//무밭
    {
        GameObject tmp = null;
        for (int i = 0; i < 6; i++)
        {
            tmp = GameObject.Find("txt_rf" + i.ToString());
            Image img = tmp.transform.parent.GetComponent<Image>();
            Color color = img.color;
            switch (arr[i])
            {
                case 0:
                    img.sprite = initial;
                    break;
                case 1:
                    img.sprite = plowed;
                    break;
                case 6:
                    img.sprite = completed_r;
                    break;
                default:
                    img.sprite = seed_r;
                    break;

            }
            color.a = 1.0f;
            img.color = color;
            tmp.GetComponent<Text>().text = arr[i].ToString();

        }

    }
   /* void loadFieldC(int[] arr)//배추밭
    {
        GameObject tmp = null;
        for (int i = 0; i < 6; i++)
        {
            tmp = GameObject.Find("txt_cf" + i.ToString());
            Image img = tmp.transform.parent.GetComponent<Image>();
            switch(arr[i])
            {
                case 0:
                    img.sprite = initial;
                    break;
                case 1:
                    img.sprite = plowed;
                    break;
                case 2:
                    img.sprite = seed_c;
                    break;
                case 10:
                    img.sprite = completed_c;
                    break;
                default:
                    img.sprite = growing_c;
                    break;

            }
            tmp.GetComponent<Text>().text = arr[i].ToString();
            
        }

    }
    void loadFieldG(int[] arr)//파밭
    {
        GameObject tmp = null;
        for (int i = 0; i < 6; i++)
        {
            tmp = GameObject.Find("txt_gf" + i.ToString());
            Image img = tmp.transform.parent.GetComponent<Image>();
            switch (arr[i])
            {
                case 0:
                    img.sprite = initial;
                    break;
                case 1:
                    img.sprite = plowed;
                    break;
                case 2:
                    img.sprite = seed_g;
                    break;
                case 13:
                    img.sprite = completed_g;
                    break;
                default:
                    img.sprite = growing_g;
                    break;

            }
            tmp.GetComponent<Text>().text = arr[i].ToString();

        }

    }*/
    //농사게임씬 시작시 밭 상태를 불러와서 오브젝트에 저장시킴
    void Start()
    {
        //+)어떤씨앗인지 종류를 구분할 수 있는 씨앗배열, 수확한 작물 수, 밭상태 배열 로드하기

        //이부분 제이슨에서 배열 불러오는걸로 바꾸기
        int[] tmpArr = { 0, 0, 0, 0, 0, 0};
        loadFieldR(tmpArr);

        //제이슨에서 수확량, 씨앗갯수 불러오기
    }

}
