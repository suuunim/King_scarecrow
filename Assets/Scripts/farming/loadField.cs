using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadField : MonoBehaviour
{
    private GameData gd;
    public Sprite initial;
    public Sprite plowed;
    public Sprite seed_r;
    public Sprite seed_c;
    public Sprite seed_g;
    public Sprite completed_r;
    public Sprite completed_c;
    public Sprite completed_g;
    public Sprite rotten_r;
    public Sprite rotten_c;
    public Sprite rotten_g;
    public Sprite sprout;


    //밭 한칸 한칸의 상태를 로드해주는 함수
    //0 기본 상태
    //1 밭이 갈아진 상태
    //2 씨앗이 심어진 상태
    //3 물을 준 상태
    //4 ~ 초 흐름

    //json 받아와서 썩은 상태의 작물일 때 로드하는 코드 넣기


    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;
    int MoveToMap = 0;
    public int clickCount = 0;
    public static int spaceCount = 0;
    public int seedNum;

    GameObject npc;
    public GameManager manager;


    public Image img_player;
    public Image img_npc;
    public GameObject panel;

    public GameObject backgroud_home;
    public GameObject backgroud_company;

    string[] script_list_1 = new string[] { "돈을 벌려면 거래처가 필요한데.. 그걸 어디서 구하지?", "아! 농사꾼 할아버지께 여쭤볼까? 도움을 주실 수도 있어!" };
    string[] script_list_2 = new string[] { "값을 아주 비싸게 받았어. 거래처 사장에게 한 소리까지 들었다고?", "그럼 지금 수확한 것들도 가져가겠네, 수고해.", "뭔가 이상한데.. 이 값이 말이 돼?", "이장님을 믿고는 싶지만, 이 정도의 돈은 도저히 납득이 안가.", "집에 가서 내가 직접 계산해봐야겠어." };
    string[] script_list_3 = new string[] { "차 타고 멀리 나가 보면, 거래처를 찾을 수 있을 거야. 집으로 가자." };
    string[] script_list = new string[] { };


    public void OnClickNextText()
    {

        if (MoveToMap == 1)
        {
            clickCount = 0;
            SceneManager.LoadScene("Map");

        }

        if (GameManager.Part1 == 7)
        {
            if (clickCount == 2)
            {
                clickCount = 0;
                GameManager.Part1 = 8;
                SceneManager.LoadScene("Map");
            }


        }
        else if (GameManager.Part1 == 12)
        {
            if (clickCount == 5)
            {
                clickCount = 0;

                SceneManager.LoadScene("Mmainhouse");
            }
        }
        else if (GameManager.Part1 == 15)
        {
            if (clickCount == 1)
            {
                clickCount = 0;
                GameManager.Part1 = 16;
                SceneManager.LoadScene("Map");
            }
        }



        string str = script_list[clickCount];




        talk.SetMsg(str);

        clickCount++;



    }



    public void StartTalk()
    {


        talkUI.transform.GetChild(1).gameObject.SetActive(true);


    }



    public void AfterHarvest()
    {
        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);
        img_player.gameObject.SetActive(true);
        if (GameManager.Part1 == 7)
        {
            img_player.gameObject.SetActive(true);
            talk.SetMsg("힘드네.. 농사 정말 쉬운 일이 아니구나. 그래도 나름 꽤 수확한 것 같아.");
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];

            }

        }
        else if (GameManager.Part1 == 12)
        {
            int num = gd.raddishNum * 602 + gd.greenOnionNum * 1205 + gd.cabbageNum * 907;
            img_npc.gameObject.SetActive(true);
            talk.SetMsg("열심히 수확하고 있었구만! 자, 여기 " + (num * 0.1) + "원.");
            for (int i = 0; i < script_list_2.Length; i++)
            {

                script_list = script_list_2.Clone() as string[];

            }

        }
        else if (GameManager.Part1 == 15)
        {
            talk.SetMsg("이만하면 됐어. 아직 해가 지진 않았으니까, 마을 밖으로 나가보자.");
            for (int i = 0; i < script_list_3.Length; i++)
            {

                script_list = script_list_3.Clone() as string[];

            }

        }

        StartTalk();
    }

    public void ScriptStart()
    {
        gd = DataController.Instance.gameData;

        if (!(GameManager.Part1 == 7 || GameManager.Part1 == 15 || GameManager.Part1 == 12))
        {
            panel.SetActive(true);
            talkUI.SetActive(true);
            talkUI.transform.GetChild(1).gameObject.SetActive(true);
            img_player.gameObject.SetActive(true);
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];


            }

            talk.SetMsg("이곳에 볼 일은 없다.");
            MoveToMap = 1;

            StartTalk();
        }


    }

    void loadFieldR(int[] arr)//무밭
    {
        GameObject.Find("btn_raddish").transform.GetChild(0).GetComponent<Text>().text = gd.seedRNum.ToString();
        GameObject.Find("result_bar").transform.GetChild(1).GetComponent<Text>().text = gd.raddishNum.ToString();
        GameObject tmp = null;
        for (int i = 0; i < 6; i++)
        {
            tmp = GameObject.Find("txt_rf" + i.ToString());
            Image img = tmp.transform.parent.GetComponent<Image>();
            Color color = img.color;
            Debug.Log("무" + i + " " + arr[i]);
            switch (arr[i])
            {
                case 0:
                    img.sprite = initial;
                    break;
                case 1:
                    img.sprite = plowed;
                    break;
                case 2:
                    img.sprite = seed_r;
                    break;
                case 6:
                    img.sprite = completed_r;
                    break;
                case 7:
                    img.sprite = rotten_r;
                    break;
                default:
                    img.sprite = sprout;
                    break;

            }
            color.a = 1.0f;
            img.color = color;
            tmp.GetComponent<Text>().text = arr[i].ToString();
            Debug.Log(i+": 무밭"+arr[i].ToString());

        }

    }
    void loadFieldC(int[] arr)//배추밭
    {
        GameObject.Find("btn_cabbage").transform.GetChild(0).GetComponent<Text>().text = gd.seedCNum.ToString();
        GameObject.Find("result_bar").transform.GetChild(2).GetComponent<Text>().text = gd.cabbageNum.ToString();
        GameObject tmp = null;
        for (int i = 0; i < 6; i++)
        {
            tmp = GameObject.Find("txt_cf" + i.ToString());
            Image img = tmp.transform.parent.GetComponent<Image>();
            Color color = img.color;
            Debug.Log("배추" + i + " " + arr[i]);
            switch (arr[i])
            {
                case 0:
                    img.sprite = initial;
                    break;
                case 1:
                    img.sprite = plowed;
                    break;
                case 2:
                    img.sprite = seed_c;
                    break;
                case 10:
                    img.sprite = completed_c;
                    break;
                case 11:
                    img.sprite = rotten_c;
                    break;
                default:
                    img.sprite = sprout;
                    break;

            }
            color.a = 1.0f;
            img.color = color;
            Debug.Log(i + ": 배추밭" + arr[i].ToString());
            tmp.GetComponent<Text>().text = arr[i].ToString();
            
        }

    }
    void loadFieldG(int[] arr)//파밭
    {
        GameObject.Find("btn_green_onion").transform.GetChild(0).GetComponent<Text>().text = gd.seedGNum.ToString();
        GameObject.Find("result_bar").transform.GetChild(3).GetComponent<Text>().text = gd.greenOnionNum.ToString();
        //result_txt_greeon_onion

        GameObject tmp = null;
        for (int i = 0; i < 6; i++)
        {
            tmp = GameObject.Find("txt_gf" + i.ToString());
            Image img = tmp.transform.parent.GetComponent<Image>();
            Color color = img.color;
            Debug.Log("파" + i + " " +arr[i]);
            switch (arr[i])
            {
                case 0:
                    img.sprite = initial;
                    break;
                case 1:
                    img.sprite = plowed;
                    break;
                case 2:
                    img.sprite = seed_g;
                    break;
                case 13:
                    img.sprite = completed_g;
                    break;
                case 14:
                    img.sprite = rotten_g;
                    break;
                default:
                    img.sprite = sprout;
                    break;

            }
            color.a = 1.0f;
            img.color = color;
            tmp.GetComponent<Text>().text = arr[i].ToString();
            
            Debug.Log(i + ": 파밭" + arr[i].ToString());

        }

    }
    //농사게임씬 시작시 밭 상태를 불러와서 오브젝트에 저장시킴
    void Start()
    {
        //+)어떤씨앗인지 종류를 구분할 수 있는 씨앗배열, 수확한 작물 수, 밭상태 배열 로드하기

        //이부분 제이슨에서 배열 불러오는걸로 바꾸기
        
        gd = DataController.Instance.gameData;

        if((gd.seedCNum + gd.seedGNum + gd.seedRNum) == 0)
        {
            AfterHarvest();
        }

        else
        {
            int[] tmpArr = gd.fieldR;
            int[] tmpArr2 = gd.fieldC;
            int[] tmpArr3 = gd.fieldG;

            loadFieldR(tmpArr);
            loadFieldC(tmpArr2);
            loadFieldG(tmpArr3);
        }
        

    }

}
