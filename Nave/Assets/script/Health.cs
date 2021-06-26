using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp = 1;
    public Transform explo_prefab;
    private Transform position_object;
    public void Damage(int damageCount)
    {
        hp -= damageCount;
        if(hp <= 0)
        {
            
            //criando o som
            SoundEffects.Instance.MakeExplosionSound();
            //criando a explosão
            var explosion = Instantiate(explo_prefab) as Transform;
            position_object = gameObject.GetComponent<Transform>();
            explosion.position = position_object.position;
            Destroy(gameObject);
        }
    }
     
   
}
