using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;

    public Gun gun;

    public GameObject endscreen;

    public Camera endscreencamera;

    public TMPro.TMP_Text bombsDestroyed;

    public TMPro.TMP_Text boxesColleted;

    public TMPro.TMP_Text shotsshot;
    //public GameObject instantiator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.hp <= 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            player.GetComponentInChildren<Camera>().tag = "Untagged";
            endscreencamera.tag = "MainCamera";
            player.gameObject.SetActive(false);
            endscreen.SetActive(true);
            bombsDestroyed.text = "" + gun.cantBombsShot;
            shotsshot.text = "" + gun.cantShots;
            boxesColleted.text = "" + player.cantBoxesCollected;
        }
    }
}
