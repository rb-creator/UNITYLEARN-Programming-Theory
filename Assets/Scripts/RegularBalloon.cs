using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularBalloon : Balloon
{
    public override void Pop()
    {
        GameManager.Instance.AddScore(_points);
        //Debug.Log("Regular Balloon Popped!");
        Destroy(gameObject);
    }
}
