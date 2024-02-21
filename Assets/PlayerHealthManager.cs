using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager  : MonoBehaviour
{
    private int playerHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
       DisplayHealth(playerHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ReduceHealth(20);

        }

    }

    void DisplayHealth(int health)
    { Debug.Log("Player Health:" + health);
    }

    void ReduceHealth(int amount)
    {
        playerHealth -= amount;
            DisplayHealth(playerHealth);
        if (playerHealth <= 0)
        { Debug.Log("Player is defeated!");
        }
    }
}
