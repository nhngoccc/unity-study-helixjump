using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMovement : MonoBehaviour
{
    private Vector3 prePos;
    private Vector3 deltaPos;
    public float rotateSpeed;
    private void Update()
    {

        if(Input.GetMouseButton(0))
        {
            deltaPos = Input.mousePosition - prePos;
            transform.Rotate(transform.up, -deltaPos.x*rotateSpeed);
        }
        prePos = Input.mousePosition;
    }

}
