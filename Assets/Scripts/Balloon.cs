using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Balloon : MonoBehaviour
{
    public float speed;
    public int points;

    public abstract void Pop();

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
