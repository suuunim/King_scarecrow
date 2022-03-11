using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdcreator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] bird;
    public GameObject[] birdB;
    int XR;
    int XL;

    public float birdTime;


    private void Start()
    {
        
            StartCoroutine("BirdCreate_M",5);
            StartCoroutine("BirdCreate_F",5);
        
        
    }
    void Update()
    {
        if (GameManager.Mscore == 15)
        {
            StopCoroutine("BirdCreate_M");
            bird[0].SetActive(false);
            bird[1].SetActive(false);
            bird[2].SetActive(false);
        }
        else if (GameManager.Fscore == 15)
        {
            StopCoroutine("BirdCreate_F");
            birdB[0].SetActive(false);
            birdB[1].SetActive(false);
            birdB[2].SetActive(false);
        }
        
            
    }
    void CreateBird(GameObject[] birdbox)
    {

        int x = Random.Range(0, 2);
        if (x == 0)
        {
            if (XL == 4)
            {
                x = 11;
                XL = 0;
            }
            else
            {
                ++XL;
                x = -11;
            }
        }
        if (x == 1)
        {
            if (XL == 4)
            {
                x = -11;
                XR = 0;
            }
            else
            {
                ++XR;
                x = 11;
            }
           
        }

        for (int i = 0; i < birdbox.Length; i++)
        {


            if (!birdbox[i].activeSelf)
            {
                birdbox[i].transform.position = new Vector2(x, Random.Range(-1f, 3f));
                birdbox[i].SetActive(true);
                return;

            }

        }


    }

    IEnumerator BirdCreate_F()
    {

        while (true)
        {


            yield return new WaitForSeconds(birdTime);
            CreateBird(birdB);
        }

    }

    IEnumerator BirdCreate_M()
    {

        while (true)
        {


            yield return new WaitForSeconds(birdTime);
            CreateBird(bird);
        }

    }

}
