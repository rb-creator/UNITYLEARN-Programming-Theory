using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBalloon : Balloon
{
    public override void Pop()
    {
        GameManager.Instance.AddScore(points * 2);
        Debug.Log("Bonus Balloon Popped!");
        Destroy(gameObject);
    }
}
