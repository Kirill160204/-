using UnityEngine;
[RequireComponent(typeof(RigidBody)))]
public class PlayerMotor : MonoBehaviour
{
    [SeralizeField]
    private Camera cam;


    private RigidBody rb;

    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private Vector3 rotationCamera = Vector3.zero;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetCopmonent<RigidBody>();
    }

    public void Move (Vector3 _vellocity)
    {
        velocity = _vellocity;
    }

    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation;
    }

    public void RotateCam(Vector3 _rotationCam)
    {
        rotationCamera = _rotationCam;
    }
    void FixedUpdate ()
    {
        PerformMove();
        PerformRotation ();
    }

    void PerformMove()
    {
        if (elocity != Vector3.zero)
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
    void PerformRotation()
    {
        rb.MoveRotation(rb.rotation * Quarternion.Euler (rotation));
        if (cam != null)
            cam.transform.Rotate (-rotationCamera);
    }
}