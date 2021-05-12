using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Input = UnityEngine.Input;
using KeyCode = UnityEngine.KeyCode;

public class Gun : MonoBehaviour
{
    public Player player;
    private GameObject bomb = null;
    private float distance = 5.0f;
    public int munition = 15;
    public int maxmunition = 15;
    public float time_reload = 0;
    private bool reloaded = false;
    public int cantShots = 0;
    public int cantBombsShot = 0;
    void Start()
    {
        
    }

    public void Appear()
    {
        Debug.Log("Estoy mostrando la pistola");
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            gameObject.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            gameObject.SetActive(false);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (munition > 0)
            {
                cantShots++;
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
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
        {
            if (hit.transform.GetComponent<Bomb>())
            {

                bomb = hit.transform.gameObject;
                Destroy(bomb);
                cantBombsShot++;
                player.score += 100;
            }
        }
    }
}
