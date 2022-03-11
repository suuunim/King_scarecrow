using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_R : MonoBehaviour
{
   
    Vector2 vel = Vector2.zero;
    public int RandomInt;
    public GameObject gameoverimg;
    float birdSpeed;
    int birdDir;
    public AudioClip hitSound;
    public AudioClip killSound;
    public AudioSource audioSource;
    int endcheck = 0;
    void Awake()
    {
        GameManager.RCheck = 0;
        GameManager.overcheck = 0;
        
        gameObject.SetActive(false);
        
        this.audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        if (GameManager.explaincheck == 1)
            gameObject.SetActive(true);
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

    void HitEvent()
    {


        gameObject.SetActive(false);
        GameManager.instance.FAddScore(1);

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

    void Update()
    {
      
        if (GameManager.Mscore == 15 && GameManager.Fscore == 15)
        {

            //게임성공하면 넘어갈 씬

        }
        else if (GameManager.StoneN == 0)
        {
            StopCoroutine("BirdMove");
            CancelInvoke("Hit");

            gameoverimg.SetActive(true);
            GameManager.overcheck = 1;


        }


    }

    private void OnEnable()
    {
      
            StartCoroutine("BirdMove");
        

    }

    IEnumerator BirdMove()
    {
        birdSpeed = 9f;
        if (transform.position.x > 0)
        {
            birdDir = -1;
            GetComponent<SpriteRenderer>().flipX = false;

        }
        if (transform.position.x < 0)
        {
            birdDir = 1;
            GetComponent<SpriteRenderer>().flipX = true;
        }


        while (true)
        {
            SpriteRenderer spr = GetComponent<SpriteRenderer>();

            Color color = spr.color;
            color.a = 1.0f;                   //i가 내려가면서 선언한 컬러의 알파 값에 참조

            spr.color = color;
            transform.Translate(Vector2.right * birdDir * birdSpeed * Time.deltaTime);

            if (Mathf.Abs(transform.position.x) > 13)
            {
                StopCoroutine("BirdMove");
                gameObject.SetActive(false);
            }

            yield return null;
        }
    }
}
