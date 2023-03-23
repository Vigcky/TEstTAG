using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunLogic : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet1;
    public float bulletSpeed = 100f;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            var bul = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            bul.GetComponent<Rigidbody>().velocity = bulletSpeed * spawnPoint.forward;
        }
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            var bul = Instantiate(bullet1, spawnPoint.position, spawnPoint.rotation);
            bul.GetComponent<Rigidbody>().velocity = bulletSpeed * spawnPoint.forward;
        }
    }
}
