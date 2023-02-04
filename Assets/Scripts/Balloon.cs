using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField]
    private protected float _speed;

    [SerializeField]
    private protected int _points;

    private int _yBoundary = 10;
    
    void Update()
    {
        FallingMotion();
        DestroyWhenOutOfBounds();
    }

    void FallingMotion()
    {
        transform.position += Vector3.down * _speed * Time.deltaTime;
    }

    public virtual void Pop()
    {

    }

    private void DestroyWhenOutOfBounds()
    {
        if (transform.position.y < -_yBoundary)
        {
            //Debug.Log("Should be destroyed now");
            Destroy(gameObject);
        }
    }

}
