using UnityEngine;
[RequireComponent (tipeof (PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float LookSpeed = 3f;
    private PlayerMotor motor;


    void Start ()
    {
        motor = GetComponent<PlayerMotor>();
    
    
    }

    void Update ()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 movHor = transform.right * xMov;
        Vector3 movVer = transform.forward * zMov;

        Vector3 velociti = (movHor + movVer).normalized * speed;

        motor.Move(velocity);

        float yRot = Input.GetAxisRaw("Mouse X");
        Vector 3 rotation = new Vector3(0f, yRot, 0f) * LookSpeed;

        motor.Rotate(rotation);

        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector 3 camRotation = new Vector3(xRot, 0f, 0f) * LookSpeed;

        motor.RotateCam(camRotation);
    }

}
