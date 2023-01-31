using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBalloon : Balloon
{
    public override void Pop()
    {
        GameManager.instance.ActivatePowerUp();
        Destroy(gameObject);
    }
}
