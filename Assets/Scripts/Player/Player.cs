using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void collidedWithEnemy(Enemy enemy)
    {
        // Enemy attack code
        enemy.Attack(this);
        if(health <= 0)
        {
            //todo
            if(onPlayerDeath != null)
            {
                onPlayerDeath(this);
            }
        }
    }

  
    void OnCollisionEnter(Collision col)
    {
        Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();

        if (enemy)
        {
            collidedWithEnemy(enemy);
        }
    }

    //unity event
    public event Action<Player> onPlayerDeath;

}