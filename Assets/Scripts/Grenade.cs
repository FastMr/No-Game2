﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float delay = 3;
    public GameObject ExplosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explosion", delay);
    }
    private void Explosion()
    {
        Destroy(gameObject);
        var explosion = Instantiate(ExplosionPrefab);
        explosion.transform.position = transform.position;
    }
}
