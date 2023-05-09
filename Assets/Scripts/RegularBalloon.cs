using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularBalloon : Balloon // INHERITANCE
{
    public override void Pop() // POLYMORPHISM
    {
        GameManager.Instance.AddScore(_points);
        //Debug.Log("Regular Balloon Popped!");
        Destroy(gameObject);
    }
}
