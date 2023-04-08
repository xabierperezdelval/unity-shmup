using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyShot;
    private Vector3 enemyPos;
    private float spawnTimer;

    void Start()
    {
        spawnTimer = Random.Range(1F, 4F);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            enemyShotSpawn();
            spawnTimer = Random.Range(4F, 7.5F);
        }
    }

    void enemyShotSpawn()
    {
        enemyPos = new Vector3(transform.position.x, transform.position.y);
        var shot = Instantiate(enemyShot, enemyPos, transform.rotation);
        if (shot)
        {
            Destroy(shot, 8.0f);
        }
    }
}
