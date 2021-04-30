﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OjamaBlockGenerator : MonoBehaviour
{
    public GameObject OjamaBlockPrefab;
    float span = 3.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(OjamaBlockPrefab) as GameObject;
            go.transform.position = new Vector2(15, 3);
        }
    }
}
