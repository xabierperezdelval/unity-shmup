using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyGeneratorBehaviour : MonoBehaviour
{
    [SerializeField] private float initialPosX, shipNumberRandom, spawnTimer;
    public GameObject enemyShip;
    private bool enableSpawn;
    // Start is called before the first frame update
    void Start()
    {
        initialPosX = Random.Range(-4.79F, 4.79F);
        shipNumberRandom = Mathf.Round(Random.Range(3F, 10F));
        spawnTimer = Random.Range(2F, 6F);
        enableSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            StartCoroutine(spawnShips());
            spawnTimer = Random.Range(3F, 6F);
            initialPosX = Random.Range(-4.79F, 4.79F);
            shipNumberRandom = Mathf.Round(Random.Range(3F, 6F));
        }
    }

    private IEnumerator spawnShips()
    {
        for (int i = 0; i < shipNumberRandom; i++)
        {
                Instantiate(enemyShip, new Vector3(initialPosX, 6.4F, 0), Quaternion.identity);
                yield return new WaitForSeconds(0.8F);
        }
    }
}
