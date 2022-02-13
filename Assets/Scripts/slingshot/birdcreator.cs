using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdcreator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] bird;



    public float birdTime;


    private void Start()
    {

        StartCoroutine(BirdCreate(bird, birdTime));
    }

    void CreateBird(GameObject[] birdbox)
    {

        int x = Random.Range(0, 2);
        if (x == 0)
            x = -11;
        if (x == 1)
            x = 11;

        for (int i = 0; i < birdbox.Length; i++)
        {


            if (!birdbox[i].activeSelf)
            {
                birdbox[i].transform.position = new Vector2(x, Random.Range(-2f, 3f));
                birdbox[i].SetActive(true);
                return;

            }

        }


    }

    IEnumerator BirdCreate(GameObject[] birdbox, float birdTime)
    {

        while (true)
        {


            yield return new WaitForSeconds(birdTime);
            CreateBird(birdbox);
        }

    }

}
