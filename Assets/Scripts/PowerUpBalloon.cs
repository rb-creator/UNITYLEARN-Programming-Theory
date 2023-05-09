using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBalloon : Balloon // INHERITANCE
{
    public override void Pop() // POLYMORPHISM
    {
        GameManager.Instance.AddScore(_points);
        GameManager.Instance.ActivatePowerUp();
        //Debug.Log("PowerUpBalloon Popped!");
        Destroy(gameObject);
    }
}
