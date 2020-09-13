﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [HideInInspector] public bool isOpen;

    private Vector3 startPosition;
    private float timeFraction;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        startPosition = transform.position;
        timeFraction = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeFraction += Time.deltaTime;

        if(isOpen) {
            transform.position = Vector3.Lerp(startPosition, startPosition + new Vector3(0.0f, 2.0f, 0.0f), timeFraction);
        }
        else {
            transform.position = Vector3.Lerp(transform.position, startPosition, timeFraction);
        }
    }
}
