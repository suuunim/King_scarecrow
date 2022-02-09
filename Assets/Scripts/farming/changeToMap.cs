using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeToMap : MonoBehaviour
{
    //지도맵으로 가는 화살표 버튼 클릭 이벤트 함수
    //여기서 json파일에 밭 상태 저장하기
    public void goToMapScene()
    {

        SceneManager.LoadScene("MapTmp");

    }
}
