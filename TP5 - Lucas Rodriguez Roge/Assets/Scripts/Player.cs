using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hp = 100;
    public float score = 0;
    public int cantBoxesCollected = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.GetComponent<Box>())
        {
            cantBoxesCollected++;
            score += 250;
            Destroy(hit.transform.gameObject);
        }
        if (hit.gameObject.GetComponent<Bomb>())
        {
            score -= 100;
            hp -= 50;
            Destroy(hit.transform.gameObject);
        }
    }
}
