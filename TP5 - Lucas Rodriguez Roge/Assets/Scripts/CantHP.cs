﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantHP : MonoBehaviour
{
    public Player player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TMP_Text>().text = "" + player.hp;
    }
}
