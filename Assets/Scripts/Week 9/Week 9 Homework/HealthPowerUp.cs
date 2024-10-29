using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    protected override void PickUpPowerUp()
    {
        base.PickUpPowerUp();

        player.AddHealth(powerUpAmount);
    }
}
