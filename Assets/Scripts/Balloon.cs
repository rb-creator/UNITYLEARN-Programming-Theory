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
        FallingMotion(); //ABSTRACTION
        DestroyWhenOutOfBounds(); //ABSTRACTION
    }

    void FallingMotion() //ABSTRACTION
    {
        transform.position += Vector3.down * _speed * Time.deltaTime;
    }

    public virtual void Pop()
    {
        // INHERITANCE
    }

    private void DestroyWhenOutOfBounds() //ABSTRACTION
    {
        if (transform.position.y < -_yBoundary)
        {
            //Debug.Log("Should be destroyed now");
            Destroy(gameObject);
        }
    }

}
