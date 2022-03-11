using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explainmanager : MonoBehaviour
{
    public GameObject gameexplain;
    public GameObject openingimg;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            openingimg.SetActive(false);
            gameexplain.SetActive(false);
            GameManager.explaincheck = 1;
        }
    }
}
