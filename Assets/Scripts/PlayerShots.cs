using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShots : MonoBehaviour
{
    public GameObject playerShot;
    private Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnShoot (InputValue value)
    {
        playerPos = new Vector3(transform.position.x, transform.position.y);
        var shot = Instantiate(playerShot, playerPos, transform.rotation);
        if (shot)
        {
            Destroy(shot, 8.0f);
        }
    }
}
