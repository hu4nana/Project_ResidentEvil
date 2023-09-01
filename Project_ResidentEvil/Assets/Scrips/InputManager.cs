using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Vector3 InputWASD()
    {
        Vector3 inputWASD = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            inputWASD.x = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            inputWASD.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputWASD.y = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            inputWASD.y = -1;
        }

        return inputWASD;
    }
    public bool InputShift()
    {
        return Input.GetKey(KeyCode.LeftShift);
    }
}
