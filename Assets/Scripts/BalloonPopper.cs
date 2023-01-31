using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPopper : MonoBehaviour
{
    private Balloon balloon;

    private void Start()
    {
        balloon = GetComponent<Balloon>();
    }

    private void Update()
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
