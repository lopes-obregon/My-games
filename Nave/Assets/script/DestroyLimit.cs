using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLimit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "inimigo")
        {
            Destroy(collision.gameObject);
        }else if(collision.gameObject.tag == "Shoot")
        {
            Destroy(collision.gameObject);
        }
    }
}
