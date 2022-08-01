using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Camera _mainCamera;

    Vector2 _oldMousePosition;

    void OnMouseDown()
    {
        Debug.Log("down");
        _oldMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDrag()
    {
        Debug.Log("drag");
        Vector2 currentMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.Translate(currentMousePosition - _oldMousePosition, Space.World);
        _oldMousePosition = currentMousePosition;
    }

    void OnMouseUp()
    {
        Debug.Log("up");

    }
}
