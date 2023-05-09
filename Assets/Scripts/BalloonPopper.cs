using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPopper : MonoBehaviour
{
    private Balloon _balloon;

    private void Start()
    {
        _balloon = GetComponent<Balloon>();
    }

    private void Update()
    {
        InputController(); //ABSTRACTION
    }

    void InputController() //ABSTRACTION
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Balloon hitBalloon = hit.transform.GetComponent<Balloon>();
                if (hitBalloon != null)
                {
                    hitBalloon.Pop();
                }
            }
        }
    }

}
