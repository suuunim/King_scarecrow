using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int placeNow; //0은 맵, 1은 집, 2는 허수아비, 3은 아주머니 이런식
    public int npcNow;
    public int[] task = { 0, 0, 0 };  // index 0은 허수아비, 1은 아주머니, 2는 이장 이런식
    public string[] npc = {"허수아비", "아주머니"};

    void Awake()
    {
        placeNow = 2;
    }
    void Start()
    {
        npcNow = placeNow - 2;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
