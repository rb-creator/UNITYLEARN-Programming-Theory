using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBalloon : Balloon
{
    public override void Pop()
    {
        GameManager.instance.AddScore(points * 2);
        Destroy(gameObject);
    }
}
