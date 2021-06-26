using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform shotPrefab;
    //tempo que deve aguardar
    public float shootintRate = 0.25f;

    private float shootCooldown;
    // Start is called before the first frame update
    void Start() => shootCooldown = 0;

    // Update is called once per frame
    void Update()
    {
        if(shootCooldown > 0)
        {
            //pega a cada tempo do jogo a cada frame
            //decremeta 0.002 segundos
            shootCooldown -= Time.deltaTime;
        }
    }
    public void Attack()
    {
        if(shootCooldown <= 0)
        {
            shootCooldown = shootintRate;
            var shotTransform = Instantiate(shotPrefab) as Transform;
            SoundEffects.Instance.MakeShotSound();
            /* (transform.position.y > 0)
            {
            transform.position.Set(transform.position.x, transform.position.y + 5, transform.position.z);

            }
            else
            {
                //ransform.position.Set(transform.position.x, transform.position.y - 5, transform.position.z);
                transform.position
            }*/
            shotTransform.position = transform.position;
           
           
        }
    }
    public float GetshootCooldown()
    {
        return shootCooldown;
    }
}
