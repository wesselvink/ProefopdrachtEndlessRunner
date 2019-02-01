﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject destructionPoint;
    void Start()
    {
        destructionPoint = GameObject.Find("PlatformDestroyer");
    }

    void Update()
    {
        if (transform.position.x < destructionPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
