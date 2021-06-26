using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public Vector2 speed = new Vector2(4, 4);
    //private float timeAttack;
    private Vector2 moviment;
    private Vector2 direction = new Vector2(0, -1);
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        moviment = new Vector2(direction.x * speed.x, direction.y * speed.y);
            Weapon weapon = GetComponent<Weapon>();
            if(weapon != null)
            {
                weapon.Attack();
            }
       
        
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = moviment;
    }
}
