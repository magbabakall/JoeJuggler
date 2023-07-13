using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monke : MonoBehaviour
{
    public LogicManager logic;
    public Animator animator;

    [SerializeField] public AudioSource monke100;
    [SerializeField] public AudioSource monke200;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(logic.playerScore == 100)
        {
            monke100.Play();
            animator.SetTrigger("Score100");
        }

        if(logic.playerScore == 200)
        {
            monke200.Play();
            animator.SetTrigger("Score200");
        }
    }
}
