using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularBalloon : Balloon
{
    public override void Pop()
    {
        Destroy(gameObject);
    }
}
