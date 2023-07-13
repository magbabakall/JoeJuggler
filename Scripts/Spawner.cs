using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public LogicManager logic;
    public GameObject fruit;
    private bool created = false;
    void Update()
    {
        spawnFruit();
    }

    private void spawnFruit()
    {
        if(created == false)
        {
            if (logic.playerScore == 50)
            {
                Instantiate(fruit, transform.position, transform.rotation);
                created = true;
            }
        }
        
    }

    

   
}
