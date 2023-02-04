using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBalloon : Balloon
{
    public override void Pop()
    {
        GameManager.Instance.AddScore(_points);
        GameManager.Instance.ActivatePowerUp();
        //Debug.Log("PowerUpBalloon Popped!");
        Destroy(gameObject);
    }
}
