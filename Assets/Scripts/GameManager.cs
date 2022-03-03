using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int placeNow; //0은 맵, 1은 집, 2는 허수아비, 3은 아주머니 이런식
    public int npcNow;
    public int[] task = { 0, 0, 0 };  // index 0은 허수아비, 1은 아주머니, 2는 이장 이런식
    public string[] npc = {"허수아비", "아주머니"};

    public static int FindRoot;
    public static int explaincheck=0;
    public static int overcheck=0;
    public static GameManager instance; //어디서나 접근할 수 있도록 static(정적)으로 자기 자신을 저장할 변수를 만듭니다.
    public Text scoreText; //점수를 표시하는 Text객체를 에디터에서 받아옵니다.
    public Text StoneText;
    public static int StoneN = 50;
    public static int score = 0; //점수를 관리합니다.
    public static int Part1=0;
    public static int grandmother_check = 0;
    public static int down_check = 0;
    public static int farmer_check = 0;
    public Slider Head;
    public Slider Main;
    void Awake()
    {
        if (!instance) //정적으로 자신을 체크합니다.
            instance = this; //정적으로 자신을 저장합니다.
        FindRoot = 0;
    }

    public void AddScore(int num) //점수를 추가해주는 함수를 만들어 줍니다.
    {
        score += num; //점수를 더해줍니다.
        scoreText.text = " X " + score; //텍스트에 반영합니다.
    }

    public void stoneNumber()
    {
        --StoneN;

        StoneText.text = " X " + StoneN;

    }

   

    void Start()
    {
        
    }

    void Update()
    {
       
    }
}
