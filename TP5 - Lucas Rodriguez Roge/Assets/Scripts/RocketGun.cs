using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketGun : MonoBehaviour
{
    public void Appear()
    {
        Debug.Log("Estoy mostrando la arma cohete");
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            gameObject.SetActive(false);
        }
    }
}
