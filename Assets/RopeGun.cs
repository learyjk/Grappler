using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeGun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject hookPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        //Debug.Log("Pressed the mouse!");
        Instantiate(hookPrefab, firePoint.position, firePoint.rotation);
    }
}
