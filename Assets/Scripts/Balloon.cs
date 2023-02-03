using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField]
    private protected float speed;

    [SerializeField]
    private protected int points;

    public virtual void Pop()
    {

    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
