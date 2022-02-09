using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public GameObject backgroud_map;
    public GameObject Hint1;
    public GameObject Hint2;
    // Start is called before the first frame update
    public bool m_IsButtonDowning;

    void Update()
    {
        if (m_IsButtonDowning)
        {
            if (GameManager.FindRoot == 0)
            {

                backgroud_map.SetActive(false);
                Hint1.SetActive(true);

            }
            else if (GameManager.FindRoot == 1)
            {
                backgroud_map.SetActive(false);
                Hint2.SetActive(true);


            }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }
            else if (GameManager.FindRoot == 1) { }

        }
        else
        {
            backgroud_map.SetActive(true);
            Hint1.SetActive(false);
            Hint2.SetActive(false);

        }
    }

    public void PointerDown()
    {
        m_IsButtonDowning = true;
    }

    public void PointerUp()
    {
        m_IsButtonDowning = false;
    }



    
    
}
