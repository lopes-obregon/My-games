using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Scroollin : MonoBehaviour
{
    public Vector2 speed = new Vector2(1, 1);
    public Vector2 direction = new Vector2(0, -1);
    private List<Transform> list_child = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        int i;
        //adiciona na lista os filhos do objeto
        for(i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            if(child != null)
            {
                list_child.Add(child);
            }
            
        }
        list_child = list_child.OrderBy(t => t.position.y).ToList();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
        //movimento de assets texturas objetos qualquer coisa em tela multiplica pelo deltaTime 
        movement *= Time.deltaTime;
        transform.Translate(movement);
       
        SpawnChild();
       
    }

    private void SpawnChild()
    {

        Transform first_child = list_child.FirstOrDefault();
        if(first_child != null)
        {
            if (first_child.position.y < -11)
            {
                Transform last_child = list_child.LastOrDefault();
                /*Vector3 last_position = last_child.position;
                Vector3 last_size = last_child.render.bounds.max - last_child.render.bounds.min;
                */
                first_child.position = new Vector3(last_child.position.x, last_child.position.y+11.2f, 0);

                list_child.Remove(first_child);
                list_child.Add(first_child);
                 
            }
        }
    }
}
