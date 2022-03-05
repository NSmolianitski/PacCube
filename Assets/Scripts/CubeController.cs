using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Camera cam;
    
    private Rigidbody2D _rigidbody;
    private Vector3 _difference;
    private Vector3 _position;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_position);
    }

    private void OnMouseDown()
    {
        var mousePos = GetClickPosition();
        _difference = transform.position - mousePos;
    }

    private void OnMouseDrag()
    {
        var mousePos = GetClickPosition();
        _position = mousePos + _difference;
    }

    private Vector3 GetClickPosition()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
