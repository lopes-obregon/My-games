using System;
using UnityEngine;

public class player : MonoBehaviour
{
    //variaveis
    //velocidade da nave
    public Vector2 speed = new Vector2(10, 10);//movimenta 10 pixel direita ou esquerda
   //movimento do personagem
    private Vector2 movement;

    public Joystick joystick;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        // o quanto o jogador precionou no teclado
        //coleta os eixos de movimentação
        //movimento do teclado
        /*float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");*/
        float inputX = joystick.Horizontal;
        float inputY = joystick.Vertical;
        //movimentação pela direção
        movement = new Vector2(inputX * speed.x, inputY * speed.y);
        
        //Input.GetButtonDown("Fire1") to computer
        if ((Input.touchCount == 2) || touchFire(inputX, inputY, Input.touchCount))
        {
            Weapon weapon = GetComponent<Weapon>();
            if(weapon != null)
            {
                weapon.Attack();
            }
        }
   

 }
    private bool touchFire(float inputX, float inputY, int touchCount)
    {
            bool aux;
        if(inputX == 0 && touchCount == 1)
            {
                aux = true;
            }else if(inputY == 0 && touchCount == 1)
            {
                aux = true;
            }
            else
            {
                aux = false;
            }
            return aux;
    }
    void FixedUpdate()
    {

        //movimento do objeto
        GetComponent<Rigidbody2D>().velocity = movement;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool damePlayer = false;
        inimigo enemy = collision.gameObject.GetComponent<inimigo>();
        if(enemy != null)
        {
            Health enemyHealth = enemy.GetComponent<Health>();
            if(enemyHealth != null){
                enemyHealth.Damage(enemyHealth.hp);
            
            }
            damePlayer = true;
        }
        if (damePlayer)
        {
            Health playerHealth = GetComponent<Health>();
            if(playerHealth != null)
            {
                playerHealth.Damage(playerHealth.hp);
            }
        }
    }
    private void OnDestroy()
    {
        if(transform.parent.gameObject.AddComponent<Score>().SaveScore() ==0 || transform.parent.gameObject.AddComponent<Score>().SaveScore() == -1)
        {
            Time.timeScale = 0;
            transform.parent.gameObject.AddComponent<GameOver>();

        }
        else
        {
            Debug.Log("Error");
        }        
    }
}
