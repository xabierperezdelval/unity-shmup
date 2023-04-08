using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private float random;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        random = Random.Range(1F, 3F);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * random * Time.deltaTime);
        if (gameObject)
        {
            Destroy(gameObject, 10.0f);
        }
    }
}
