using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantBalas : MonoBehaviour
{
    public Gun gun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TMP_Text>().text = "" + gun.balas;
    }
}
