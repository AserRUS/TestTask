using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float MouseX;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float turningSpeed;
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private Transform model;
    [SerializeField] private float movementBorder;
    
    private float angle;
    

    private void FixedUpdate()
    {
        Vector3 targetMovePosition = transform.InverseTransformPoint(model.position + model.right * MouseX);        
        targetMovePosition.x = Mathf.Clamp(targetMovePosition.x,  -movementBorder,  movementBorder);
        model.localPosition = targetMovePosition;

        playerRigidbody.velocity = transform.forward * movementSpeed;
    }

    private void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0,angle, 0), turningSpeed * Time.deltaTime);
    }
    public void Rotation(float angle)
    {
        this.angle = angle;
    }
    
    public void Move()
    {
        enabled = true;
    }
    public void Stop()
    {
        playerRigidbody.velocity = Vector3.zero;
        enabled = false;
    }
}
