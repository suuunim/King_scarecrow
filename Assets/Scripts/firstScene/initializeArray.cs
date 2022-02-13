using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initializeArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(DataController.Instance.gameData.isFirstTime)
        {
            for (int i = 0; i < 15; i++)
            {
                DataController.Instance.gameData.seedRArr[i] = 50;
                DataController.Instance.gameData.seedCArr[i] = 50;
                DataController.Instance.gameData.seedGArr[i] = 50;
            }

            Debug.Log(DataController.Instance.gameData.seedRArr[14]);
            Debug.Log(DataController.Instance.gameData.seedCArr[14]);
            Debug.Log(DataController.Instance.gameData.seedGArr[14]);

            for (int i = 0; i < 6; i++)
            {
                DataController.Instance.gameData.fieldR[i] = 0;
                DataController.Instance.gameData.fieldC[i] = 0;
                DataController.Instance.gameData.fieldG[i] = 0;
            }
        }
    }
}
