﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public GameObject impact;
    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }

    }

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            Target tar = hit.transform.GetComponent<Target>();

            if (tar != null)
            {
                tar.Damage(damage);
            }

            Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
