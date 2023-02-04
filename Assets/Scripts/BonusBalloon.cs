using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBalloon : Balloon
{
    public override void Pop()
    {
        GameManager.Instance.AddScore(_points);
        //Debug.Log("Bonus Balloon Popped!");
        Destroy(gameObject);
    }
}
