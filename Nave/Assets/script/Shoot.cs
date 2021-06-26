using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{

    public int damage = 1;
    public  string objectTag;
    private int temp_string = 0;
    public Transform explosion_prefab;

    // Start is called before the first frame update
    void Start() => Destroy(gameObject, 10); //destroi depois de 10 segundos

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Shoot")
        {
            SoundEffects.Instance.MakeExplosionSound();
            var explosion = Instantiate(explosion_prefab) as Transform;
            explosion.position = gameObject.GetComponent<Transform>().position;
            Destroy(collider.gameObject);
           

        }else if(collider.gameObject.tag == objectTag)
        {
#pragma warning disable UNT0014 // Invalid type for call to GetComponent
            Health healt = collider.gameObject.GetComponent<Health>();
#pragma warning restore UNT0014 // Invalid type for call to GetComponent
           if(healt != null)
            {
                healt.Damage(damage);
                if(collider.gameObject.tag == "inimigo")
                {
                    //cria variavel do tipo texto
                    var textEditor = GameObject.FindGameObjectsWithTag("Score");
                    foreach (var item in textEditor)
                    {
                        Text msg = item.GetComponent<Text>();
                        temp_string = int.Parse(msg.text) + 1;
                        msg.text = temp_string.ToString();
                        
                    }
                    
                }
                //ocorreu o dano 
                Destroy(gameObject);

            }
            else
            {
                print("Falhou");
            }
        }
    }
}
