﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    public PowerUp powerUp;

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject == powerUp.player || col.gameObject.tag == "Bullets")
        {
            powerUp.player.isProjectileExplosive = true;
            powerUp.player.DisablePowerup(ResetExplosive(powerUp.duration));
        }

        Destroy(this.gameObject);
    }

    IEnumerator ResetExplosive (float delay)
    {
        yield return new WaitForSeconds(delay);
        powerUp.player.isProjectileExplosive = false;
    }
}
