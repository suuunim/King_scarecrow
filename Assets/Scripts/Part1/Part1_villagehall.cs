using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;
using System;
using UnityEngine.SceneManagement;
public class Part1_villagehall : MonoBehaviour
{
    public TalkEffect talk;
    public GameObject talkUI;
    public Button ButtonTalk;
    public Button ButtonTask;

    public int clickCount = 0;
    public static int spaceCount = 0;

    GameObject npc;
    public GameManager manager;

    public Image fadeimg;
    public Image img_player;
    public Image img_npc;

    public GameObject background_in;
    public GameObject background_out;

    string[] script_list_1 = new string[] { "안녕하세요! 저는 (이름)라고 합니다.", "공기 좋은 마을에서 농사를 지으며 살고 싶어, 마을에 내려오게 되었습니다.", "일손이 부족하시면 저를 불러주세요! 마다 않고 달려가겠습니다.", "아직 농사에 대해 잘 몰라, 이웃 분들께서 많이 도와 주시면 감사하겠습니다.", "여러분들과 함께 즐겁게 지내고 싶어요! 잘 부탁드립니다.", "…", "…", "…", "그래요. 이제 다들 해산해도 됩니다. (이름)씨도 가보세요.", "이 분위기 뭐지.. 내가 뭘 잘못 한 게 있나?", "흐음... 한 분 한 분 직접 찾아가서 인사 드려야겠어.", "농사를 성공적으로 마치려면 그분들의 도움이 꼭 필요해." };
    string[] script_list_2 = new string[] { "이장님! 여기 계셨네요? 여쭐 게 있어서 찾고 있었어요.", "자네 미쳤나!? 내 허락도 없이 왜 이 곳에 들어오지?", "제정신이 아니구만. 제정신이 아니야!", "아.. 죄송합니다. 제가 잘 몰랐어요. 다음부터는 그러지 않겠,", "나가게나!!!!", "그래서. 내게 하고 싶었던 말이 뭔가? 얼마나 중요한 일인지 들어나 보지.", "아, 그게.. 농작물을 수확했는데 혹시 거래할 곳이 있는지 여쭈러 온 거 였어요.", "농사꾼 할아버지께 들렀는데, 그 분께서 이장님께 가면 된다고 하셔서..", "아하.. 그런 거였구만. 내가 너무 과민 반응을 했어, 미안하네.", "우리, 자세한 이야기는 집에 가서 할까?", "네, 알겠습니다..!" };
    string[] script_list_3 = new string[] { "자네, 이번에도 내 허락 없이 여기에 들어왔네? 내가 저번에도 말했을 텐,", "이장님. 저는 그 안에서 이장님께서 뭘 하시는지엔 관심 없습니다.", "궁금한 건 딱 하나입니다. 어제 (이장이 준 액수)원을 주셨죠. 좀 너무하신 거 아닙니까?", "이장님께 드린 농작물 개수와 현재 시가만 생각해도 15049원을 훌쩍 넘겨요.", " 아뇨! 훌쩍 넘기다 못해 10배는 되죠. 이게 정말 저를 챙겨 주신 겁니까?", "말이 안되잖아요, 말이. 상식적으로 생각해보시라고요.", "하. 하. 하. 하. 하. 그래서 자네가 어쩔건가?", "예? 당연히 저에게 돈을 더 주셔야죠! 수익의 절반은 받아야 한다고 생각합니다.", "그래... 하지만. 자네는 이 곳에서 이방인이고, 자네를 도와줄 사람들도 없지.", "그렇다고 이 곳까지 와서 도와줄 사람들도, 없을 거야. 자네는 늘 혼자였으니까.", "제 신상에 대해 조사했습니까? 이거 범죄입니다!!!!!!! 경찰에 신고 할 거예요.", "푸하하하하하하. 경찰에 신고? 진심인가?", " 여기를 몰라도 너무 모르네. 우리 마을은 그런 상식적인 행동이 통하지 않아. ", "바빠서 신경 못썼나 본데, 이 곳은 전화도 안터져. 그런데, 신고? 할 수가 없지.", "명심해. 자네는 지금 상식 밖의 구역에 와 있는 거야.", "그러니 주제를 알고 내 말을 거역하지 않는 게.. 좋을 걸?", "당신 미쳤네요! 맞아요, 저는 이방인이고 절 도와줄 사람도 없어요.", "그런데.. 그렇다고 당신에게 협조하고 싶진 않아요! 받은 돈 돌려드리겠습니다.", "앞으로는 뭐든 제가 알아서 할 테니, 제 일에 간섭하지 말아주십쇼." };
    string[] script_list = new string[] { };

    public void OnClickNextText()
    {


        if (clickCount == 5)
        {
            if (GameManager.Part1 == 10)
            {
                background_in.SetActive(false);
                background_out.SetActive(true);
            }
        }

        if (clickCount == 12)
        {
            if (GameManager.Part1 == 2)
            {
                clickCount = 0;
                GameManager.Part1 = 3;
                SceneManager.LoadScene("Map");
            }

        }

        if (clickCount == 11)
        {
            if (GameManager.Part1 == 10)
            {
                clickCount = 0;
                GameManager.Part1 = 11;
                SceneManager.LoadScene("Mheadhouse");
            }


        }

        if (clickCount == 19)
        {
            if (GameManager.Part1 == 14)
            {
                clickCount = 0;
               
                SceneManager.LoadScene("Mmainhouse");
            }

        }
        //if (clickCount == 2)
        //{
        //    backgroud_home.SetActive(false);
        //    backgroud_company.SetActive(true);
        //}

        //if (clickCount == 7)
        //{
        //    backgroud_company.SetActive(false);
        //    backgroud_home.SetActive(true);


        //}


        string str = script_list[clickCount];




        talk.SetMsg(str);

        clickCount++;

    }



    public void StartTalk()
    {

        
        talkUI.transform.GetChild(1).gameObject.SetActive(true);
        
    
    }



    void Start()
    {

        talkUI.SetActive(true);
        talkUI.transform.GetChild(1).gameObject.SetActive(true);

        if (GameManager.Part1 == 2)
        {

            talk.SetMsg("신고할 용건이 있습니다. (이름)씨! 이리로 와서 자기 소개해요.");
            background_in.SetActive(true);
            for (int i = 0; i < script_list_1.Length; i++)
            {

                script_list = script_list_1.Clone() as string[];

            }

        }
        else if (GameManager.Part1 == 10)
        {
            background_in.SetActive(true);
            talk.SetMsg("!!!!!!!!!!!!");
            for (int i = 0; i < script_list_2.Length; i++)
            {
                
                script_list = script_list_2.Clone() as string[];

            }

        }
        else if(GameManager.Part1 == 14)
        {
            background_in.SetActive(true);
            talk.SetMsg("여기에도 없나? 아냐, 이장이 저 문에서 나왔었잖아. 들어가보자.");
            for (int i = 0; i < script_list_3.Length; i++)
            {

                script_list = script_list_3.Clone() as string[];

            }
        }

        StartTalk();

    }

    IEnumerator FadeAway()
    {

        fadeimg.enabled = true;
        //fadeimg.gameObject.SetActive(true);
        Color color = fadeimg.color;
        for (float i = 1.0f; i >= 0.0f; i -= 0.1f)
        {
            yield return new WaitForSeconds(0.1f);
            color.a = i;                   //i가 내려가면서 선언한 컬러의 알파 값에 참조

            fadeimg.color = color;       //i로 인해 내려간 알파 값을 다시 오브젝트 이미지에 참조

        }
        fadeimg.enabled = false;

    }
}
