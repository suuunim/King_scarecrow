using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeToMap : MonoBehaviour
{
    private void saveField()
    {
        GameObject field;//밭 한줄 전체
        Transform target;//밭 한칸
        GameData gd = DataController.Instance.gameData;
        string str;
        int stateNum;

        for(int i =1; i<=3; i++)
        {
            field = GameObject.Find("field" + i.ToString());
            for(int j =0; j<6; j++)
            {
                target = field.transform.GetChild(j);
                str = target.transform.GetChild(0).GetComponent<Text>().text;
                stateNum = int.Parse(str);
                Debug.Log(target.name +" " + str +"\n");
                
                switch(i)
                {
                    case 1:
                        gd.fieldR[j] = stateNum;
                        break;
                    case 2:
                        gd.fieldC[j] = stateNum;
                        break;
                    case 3:
                        gd.fieldG[j] = stateNum;
                        break;
                }
            }
        }
    }
    //지도맵으로 가는 화살표 버튼 클릭 이벤트 함수
    //여기서 json파일에 밭 상태 저장하기
    public void goToMapScene()
    {
        saveField();
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        SceneManager.LoadScene("Map");

    }
}
