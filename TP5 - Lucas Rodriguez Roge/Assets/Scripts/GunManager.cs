using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public GameObject gun;
    public GameObject rocketGun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gun.SetActive(true);
            rocketGun.SetActive(false);
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gun.SetActive(false);
            rocketGun.SetActive(true);
        }
    }
}
