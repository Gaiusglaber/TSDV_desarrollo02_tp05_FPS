using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketGun : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPoint;
    public float range = 15f;
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

        if (Input.GetMouseButtonDown(0))
        {
            GameObject instanciateBall= Instantiate(ball,
                new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z),
                Quaternion.identity);
            instanciateBall.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);
        }
    }
}
