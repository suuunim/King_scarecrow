using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stone : MonoBehaviour
{
    private bool isPressed = false;

    private float releaseDelay = .1f;
    private float maxDragDistance = 3f;
    private Rigidbody2D rb;
    private SpringJoint2D sj;
    private Rigidbody2D slingRb;

    public AudioClip dragSound;
    public AudioClip shootSound;
    public AudioSource audioSource;



    public GameObject NextStone;
    public float stonePositionOffset;
    private float circleRadius;

    Rigidbody2D stone;
    Collider2D stoneCollider;

    private void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        sj = GetComponent<SpringJoint2D>();
        slingRb = sj.connectedBody;
        releaseDelay = 0.3f;

    }

    void playSound(string action)
    {

        switch (action)
        {
            case "dragSound":
                audioSource.clip = dragSound;
                break;
            case "shootSound":
                audioSource.clip = shootSound;
                break;



        }

        audioSource.Play();

    }


    // Update is called once per frame
    void Update()
    {

        if (isPressed)
        {
            
            DragStone();

            

        }

      
    }



    private void DragStone()
    {

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float distance = Vector2.Distance(mousePosition, slingRb.position);

        if (distance > maxDragDistance)
        {
            Vector2 direction = (mousePosition - slingRb.position).normalized;
            rb.position = slingRb.position + direction * maxDragDistance;

        }
        else { rb.position = mousePosition; }



    }

    private void OnMouseDown()
    {
        playSound("dragSound");
        isPressed = true;
        rb.isKinematic = true;

    }



    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        GameManager.instance.stoneNumber();

        playSound("shootSound");
        StartCoroutine(Release());
    }

    private IEnumerator Release()
    {

        yield return new WaitForSeconds(releaseDelay);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(releaseDelay);
        if (NextStone != null)
        {

            NextStone.SetActive(true);
        }
    }

    private void DeactiveStone() {
        gameObject.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "bird") {

            if (NextStone != null)
            {

                NextStone.SetActive(true);
            }
            //StartCoroutine(Release());
            Invoke("DeactiveStone", 0.1f);

        }

    }


}
