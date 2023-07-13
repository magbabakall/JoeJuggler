using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickForce : MonoBehaviour
{

    Collider2D col;
    public bool clickBlocked = false;
    public float clickTimer;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchCollider)
                {
                    GetComponent<Rigidbody2D>().AddForce(transform.up * 500);
                    Debug.Log("Clicked");
                }
            }
            
            
        }
    }
   
}
