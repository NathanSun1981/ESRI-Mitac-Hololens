﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMenu : MonoBehaviour
{
    private GameObject terrain;
    // Use this for initialization
    void Start()
    {
        terrain = GameObject.Find("TerrainMap");
    }
    void FixedUpdate()
    {
        if (terrain != null)
            this.transform.position = terrain.transform.position + new Vector3(0f, 0.1f, -0.7f);
    }
}
