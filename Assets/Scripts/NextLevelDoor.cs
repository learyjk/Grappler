﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelDoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log(other.name);
        if (other.gameObject.tag == "Player")
        {
            GameMaster.NextLevel();
        }        
    }
}
