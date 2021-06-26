using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShoot : MonoBehaviour
{
    //velocidade do tiro
    public Vector2 speed = new Vector2(4, 4);
    //direção do tiro
    public Vector2 direction = new Vector2(0, 1);
    //movimento do tiro
    private Vector2 moviment;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moviment = new Vector2(direction.x * speed.x, direction.y * speed.y);

    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = moviment;
    }
}
