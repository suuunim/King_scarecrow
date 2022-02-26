using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class bird : MonoBehaviour
{
    int check = 0;
    private SpriteRenderer _spriteRenderer;
    float birdSpeed;
    int birdDir;
    public GameObject targetPosition0;
    public GameObject targetPosition1;
    public GameObject targetPosition2;
    public GameObject targetPosition3;
    public GameObject targetPosition4;
    public GameObject targetPosition5;
    public GameObject targetPosition6;
    public GameObject targetPosition7;
    public GameObject gameoverimg;
    int endcheck = 0;
    public AudioClip hitSound;
    public AudioClip killSound;
    public AudioSource audioSource;

    List<GameObject> targetlist_L = new List<GameObject>();

    List<GameObject> targetlist_R = new List<GameObject>();

    public Slider HealthBar;
    Vector2 vel = Vector2.zero;
    public int RandomInt;

    void Awake() {

        this.audioSource = GetComponent<AudioSource>();

        targetlist_L.Add(targetPosition0);
        targetlist_L.Add(targetPosition1);
        targetlist_L.Add(targetPosition2);
        targetlist_L.Add(targetPosition3);


        targetlist_R.Add(targetPosition4);
        targetlist_R.Add(targetPosition5);
        targetlist_R.Add(targetPosition6);
        targetlist_R.Add(targetPosition7);

    }

    void playSound(string action)
    {

        switch (action)
        {
            case "hitSound":
                audioSource.clip = hitSound;
                break;
            case "killSound":
                audioSource.clip = killSound;
                break;



        }

        audioSource.Play();

    }

    private void Start()
    {
        if (GameManager.explaincheck == 1&&HealthBar.value>0)
        {
            BirdSet();
            StartCoroutine("BirdMove");
            InvokeRepeating("Hit", 5, 1);//5초후에 한번 실행 그 뒤로는 1초마다 반복 Hit 새가 허수아비 공격하여 체력바 줄어드는 부분


        }

      
    }


   

    void BirdSet()
    {

        birdSpeed = Random.Range(1f, 3f);
        if (transform.position.x > 0)
        {


            
            GetComponent<SpriteRenderer>().flipX = false;


        }

        if (transform.position.x < 0)
        {


            
            GetComponent<SpriteRenderer>().flipX = true;


        }
    }


    void Hit()
    {
        HealthBar.value -= 5.5f;//줄어드는 체력
        playSound("hitSound");
    }

    


    IEnumerator BirdMove()
    {


        RandomInt = Random.Range(0, 4);
        while (true)
        {
            if (transform.position.x < 0)
            {
               
                transform.position = Vector2.SmoothDamp(gameObject.transform.position, targetlist_L[RandomInt].transform.position, ref vel, 1f);//1f가 새 이동 속도
            }

            if (transform.position.x > 0)
            {
               
                transform.position = Vector2.SmoothDamp(gameObject.transform.position, targetlist_R[RandomInt].transform.position, ref vel, 1f);
            }

            check = 1;


            yield return null;


        }





    }

    void HitEvent()
    {


        gameObject.SetActive(false);
        GameManager.instance.AddScore(1);

    }

    public void OnDamaged()
    {


        StartCoroutine("FadeAway");


        Invoke("HitEvent", 1);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Stone")
        {

            StopCoroutine("BirdMove");
            CancelInvoke("Hit");
            OnDamaged();
            playSound("killSound");
            //gameObject.SetActive(false);
            //Destroy(gameObject);
        }

    }


    IEnumerator FadeAway()
    {
       
        SpriteRenderer spr = GetComponent<SpriteRenderer>();

        Color color = spr.color;
        for (float i = 1.0f; i >= 0.0f; i -= 0.1f)
        {
            yield return new WaitForSeconds(0.1f);
            color.a = i;                   //i가 내려가면서 선언한 컬러의 알파 값에 참조

            spr.color = color;       //i로 인해 내려간 알파 값을 다시 오브젝트 이미지에 참조

        }


    }

    void delayLoad() {

        SceneManager.LoadScene("Mfield");

    }

    void Update() {

        if (GameManager.score == 1)
        {
            GameManager.Part1 = 22;
            Invoke("delayLoad", 2);
        }
        else if (GameManager.StoneN == 0)
        {
            StopCoroutine("BirdMove");
            CancelInvoke("Hit");

            gameoverimg.SetActive(true);
            GameManager.overcheck = 1;


        }
        else if (HealthBar.value <= 0)
        {
            StopCoroutine("BirdMove");
            CancelInvoke("Hit");
            gameoverimg.SetActive(true);
            GameManager.overcheck = 1;
            
        }

    }

    

    
}
