﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalOther : MonoBehaviour
{
    public bool inverted2;
    // Start is called before the first frame update
    void Start()
    {
        inverted2 = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Gravity")
        {
            inverted2 = !inverted2;
            Destroy(other.gameObject);
        }
    }
}
