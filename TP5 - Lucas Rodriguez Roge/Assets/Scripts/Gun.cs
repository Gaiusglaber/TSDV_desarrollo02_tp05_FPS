using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gun : MonoBehaviour
{
    private float distance = 5.0f;
    public int munition = 15;
    public int maxmunition = 15;
    public float time_reload = 0;
    private bool reloaded = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (munition > 0)
            {
                Shoot();
                munition--;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            reloaded = true;
        }

        if (reloaded)
        {
            if (time_reload > 1)
            {
                munition = maxmunition;
                time_reload = 0;
                reloaded = false;
            }
            time_reload += Time.deltaTime;
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance);

    }
}
