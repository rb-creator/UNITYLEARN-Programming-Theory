using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBalloon : Balloon // INHERITANCE
{
    public override void Pop() // POLYMORPHISM
    {
        GameManager.Instance.AddScore(_points);
        //Debug.Log("Bonus Balloon Popped!");
        Destroy(gameObject);
    }
}
