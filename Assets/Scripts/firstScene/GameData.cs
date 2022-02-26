using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameData
{
    public bool isFirstTime = true;
    public string userName = "";
    public int soundV = 0;

    //맵 단위로 자동 저장
    public int part1=0;


    //획득한 작물 갯수
    public int raddishNum = 0;
    public int cabbageNum = 0;
    public int greenOnionNum = 0;

    //획득한 씨앗 수
    public int seedRNum = 15;
    public int seedCNum = 15;
    public int seedGNum = 15;

    //씨앗 확률 배열
    public int[] seedRArr = new int[30];
    public int[] seedCArr = new int[30];
    public int[] seedGArr = new int[30];

    //밭 상태 배열
    public int[] fieldR = new int[6];
    public int[] fieldC = new int[6];
    public int[] fieldG = new int[6];

}
