﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBehaviour : MonoBehaviour {
    // Use this for initialization

    public Image health;
    float hp, maxHp = 100f;
    //float amount = 10f;

    // Use this for initialization
    void Start()
    {
        hp = maxHp;
    }

    public void TakeDamage(float amount)
    {
        hp = Mathf.Clamp(hp - amount, 0f, maxHp);
        health.transform.localScale = new Vector2(hp / maxHp, 0.2560809f);
    }

    public void TakeHealth(float amount)
    {
        hp = Mathf.Clamp(hp + amount, 0f, maxHp);
        health.transform.localScale = new Vector2(hp / maxHp, 0.2560809f);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 0f)
        {
            
            TakeHealth(100f);

        }
    }
}
