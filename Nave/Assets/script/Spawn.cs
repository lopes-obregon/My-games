using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //variavel para receber a instancia do inimigo
    public Transform enemyPrefab;
    public float spawnRate = 2f; // 2 segundos
    private bool isPositionPlayer = false;
    public Transform playerTrabsform;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);    
    }
    private void SpawnEnemy()
    {
        isPositionPlayer = !isPositionPlayer;
        Vector3 spawnPositon = isPositionPlayer && playerTrabsform != null
            ? new Vector3(playerTrabsform.position.x, transform.position.y, transform.position.z)
            : new Vector3(Random.Range(-10, 10), transform.position.y, transform.position.z);
        var enemyTransform = Instantiate(enemyPrefab) as Transform;
        //posição do objeto

        enemyTransform.position = spawnPositon;
    }
    
}
