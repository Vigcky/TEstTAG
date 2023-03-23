using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BDIE : MonoBehaviour
{

    public GameObject bullet;


    private void Awake()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(10000);
        Destroy(bullet);
    }
}