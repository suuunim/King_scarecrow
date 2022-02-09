using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainHealth : MonoBehaviour
{
    public Slider MainBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MainBar.value = UIManager.instance.Main;
    }
}
