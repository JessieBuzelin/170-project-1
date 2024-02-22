using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EnemyHealth : MonoBehaviour
{
    private int enemyHealth = 100;
        public int enemyAgility = 10;
    public int enemyHaste = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("haste is " + enemyHaste);
    }
}
