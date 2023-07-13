using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
    public float fallSpeed;
    public GameObject UpperLimmit;
    Collider2D col;
    public bool clickBlocked = false;
    public float clickTimer;
    public LogicManager scoreBoard;
    public GameObject clickArea;


    [SerializeField] private AudioSource fruitHit;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * fallSpeed) * Time.deltaTime;

        if(transform.position.y < clickArea.transform.position.y)
        {
            click();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "UpperLimmit")
        {
            scoreBoard.addScore(10);
            fallSpeed = -fallSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            fallSpeed = 0;
        }

    }

    private void screenTouch()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchCollider)
                {
                    fallSpeed = -fallSpeed;
                    clickBlocked = true;
                    StartCoroutine(clickDelay());
                    Debug.Log("Clicked");
                    fruitHit.Play();
                }
            }
        }
    }

    public void click()
    {
        if (clickBlocked == false)
        {
            screenTouch();
        }
        else if(clickBlocked)
        {
            return;
        }
        
    }

    private IEnumerator clickDelay()
    {
        yield return new WaitForSeconds(1);
        clickBlocked = false;
    }

   

}
