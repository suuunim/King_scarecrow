﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class csvReader : MonoBehaviour
{
    public List<Dictionary<int, string>> Read(string file)
    {
        var list = new List<Dictionary<int, string>>();
        StreamReader sr = new StreamReader(Application.dataPath + "/" + file);

        bool endOfFile = false;
        while (!endOfFile)
        {
            string data_String = sr.ReadLine();
            if (data_String == null)
            {
                endOfFile = true;
                break;
            }
            var data_values = data_String.Split(','); //string, string타입
            var tmp = new Dictionary<int, string>();
            tmp.Add(int.Parse(data_values[0]), data_values[1]); //int, string으로 바뀜
            list.Add(tmp);
        }

        return list;
    }
}