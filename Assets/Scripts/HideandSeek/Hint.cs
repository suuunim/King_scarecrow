using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public GameObject backgroud_map;
    public GameObject villagehall;
    public GameObject down;
    public GameObject mainhome;
    public GameObject bench;
    public GameObject abandoned;
    public GameObject farmer;
    public GameObject field;
    public GameObject mountain;
    public GameObject mainfield;
    public GameObject headhouse;
    // Start is called before the first frame update
    public bool m_IsButtonDowning;

    int hintcount=3;
    public Text hintcount_text;
    void Start()
    {
        hintcount_text.text = "" + hintcount;
    }
    void Update()
    {
        hintcount_text.text = "" + hintcount;
        if (m_IsButtonDowning&&hintcount>=0)
        {
            if (GameManager.FindRoot == 0)
            {


                mainfield.SetActive(true);

                villagehall.SetActive(true);
            }
            else if (GameManager.FindRoot == 1)
            {
                mountain.SetActive(true);
                headhouse.SetActive(true);


            }
            else if (GameManager.FindRoot == 2) {
                mainhome.SetActive(true);
                mainfield.SetActive(true);
            }
            else if (GameManager.FindRoot == 3) {
                farmer.SetActive(true);
                headhouse.SetActive(true);
            }
            else if (GameManager.FindRoot == 4) {
                villagehall.SetActive(true);
                field.SetActive(true);
            }
            else if (GameManager.FindRoot == 5) {
                mountain.SetActive(true);
                abandoned.SetActive(true);
            }
            else if (GameManager.FindRoot == 6) {
                mainfield.SetActive(true);
            }
            else if (GameManager.FindRoot == 7) {
                headhouse.SetActive(true);
                down.SetActive(true);
            }
            else if (GameManager.FindRoot == 8) {

                mainhome.SetActive(true); 
                bench.SetActive(true);
            }
            else if (GameManager.FindRoot == 9) {
                abandoned.SetActive(true);
                headhouse.SetActive(true);
            }
            else if (GameManager.FindRoot == 10) {
                villagehall.SetActive(true); 
                mainhome.SetActive(true);
            }
            else if (GameManager.FindRoot == 11) {
                down.SetActive(true);
                field.SetActive(true);
            }
            else if (GameManager.FindRoot == 12) {
                field.SetActive(true);
                bench.SetActive(true);
            }
            else if (GameManager.FindRoot == 13) {
                mainfield.SetActive(true);
                headhouse.SetActive(true);
            }
            else if (GameManager.FindRoot == 14) {
                headhouse.SetActive(true);
                villagehall.SetActive(true);
            }
            else if (GameManager.FindRoot == 15) {
                abandoned.SetActive(true);
                mountain.SetActive(true);
            }
            else if (GameManager.FindRoot == 16) {
                headhouse.SetActive(true);
                field.SetActive(true);
            }
            else if (GameManager.FindRoot == 17) {
                mountain.SetActive(true);
            }
            else if (GameManager.FindRoot == 18) {
                headhouse.SetActive(true);
                farmer.SetActive(true);
            }
            else if (GameManager.FindRoot == 19) {
                bench.SetActive(true);
                down.SetActive(true);
            }
            else if (GameManager.FindRoot == 20) {
                field.SetActive(true);
            }
            else if (GameManager.FindRoot == 21) {
                villagehall.SetActive(true);
                mainfield.SetActive(true);
            }
            else if (GameManager.FindRoot == 22) {
                bench.SetActive(true);
                mountain.SetActive(true);
            }
            else if (GameManager.FindRoot == 23) {
                abandoned.SetActive(true);
                mainfield.SetActive(true);
            }
            else if (GameManager.FindRoot == 24) {
                mainhome.SetActive(true);
                headhouse.SetActive(true);
            }
            else if (GameManager.FindRoot == 25) {
                villagehall.SetActive(true);
                mountain.SetActive(true);
            }
            else if (GameManager.FindRoot == 26) {
                villagehall.SetActive(true); 
                mainhome.SetActive(true);
            }
            else if (GameManager.FindRoot == 27) {
                down.SetActive(true);
                bench.SetActive(true);
            }
            else if (GameManager.FindRoot == 28) {
                headhouse.SetActive(true);
                mountain.SetActive(true);
            }
            else if (GameManager.FindRoot == 29) {
                farmer.SetActive(true);
                down.SetActive(true);
            }
            else if (GameManager.FindRoot == 30) {
                mountain.SetActive(true);
                field.SetActive(true);
            }
            else if (GameManager.FindRoot == 31) {
                mainhome.SetActive(true);
                villagehall.SetActive(true);
            }
            else if (GameManager.FindRoot == 32) {
                villagehall.SetActive(true);
                headhouse.SetActive(true);
            }
            else if (GameManager.FindRoot == 33) {
                abandoned.SetActive(true);
                down.SetActive(true);
            }
            else if (GameManager.FindRoot == 34) {
                mainfield.SetActive(true);
                bench.SetActive(true);
            }
            else if (GameManager.FindRoot == 35) {
                mainhome.SetActive(true);
                field.SetActive(true);
            }
            else if (GameManager.FindRoot == 36) {
                farmer.SetActive(true);
                villagehall.SetActive(true);
            }
            else if (GameManager.FindRoot == 37) {
                field.SetActive(true);
                mainfield.SetActive(true);
            }
            else if (GameManager.FindRoot == 38) {
                bench.SetActive(true);
                mountain.SetActive(true);
            }
            else if (GameManager.FindRoot == 39) {
                villagehall.SetActive(true);
                down.SetActive(true);
            }
            else if (GameManager.FindRoot == 40) {
                bench.SetActive(true);
                headhouse.SetActive(true);
            }
            else if (GameManager.FindRoot == 41) { 
                abandoned.SetActive(true);
                down.SetActive(true);
            }
            else if (GameManager.FindRoot == 42) {
                villagehall.SetActive(true);
                mainfield.SetActive(true);
            }
            else if (GameManager.FindRoot == 43) {
                mainhome.SetActive(true);
                mountain.SetActive(true);
            }
            else if (GameManager.FindRoot == 44) {
                field.SetActive(true);
                farmer.SetActive(true);
            }
            else if (GameManager.FindRoot == 45) {
                down.SetActive(true);
                mountain.SetActive(true);
            }
            else if (GameManager.FindRoot == 46) {
                villagehall.SetActive(true);
                farmer.SetActive(true);
            }
            else if (GameManager.FindRoot == 47) {
                headhouse.SetActive(true);
                down.SetActive(true);
            }
            else if (GameManager.FindRoot == 48) {
                mainfield.SetActive(true);
                villagehall.SetActive(true);
            }
            else if (GameManager.FindRoot == 49) {
                headhouse.SetActive(true);
                mainhome.SetActive(true);
            }
           

        }
        else
        {
            mainhome.SetActive(false);
            mainfield.SetActive(false);
            headhouse.SetActive(false);
            farmer.SetActive(false);
            down.SetActive(false);
            field.SetActive(false);
            mountain.SetActive(false);
            villagehall.SetActive(false);
            abandoned.SetActive(false);
            bench.SetActive(false);
        }
    }

    public void PointerDown()
    {
        hintcount--;
        m_IsButtonDowning = true;
    }

    public void PointerUp()
    {
        m_IsButtonDowning = false;
    }



    
    
}
