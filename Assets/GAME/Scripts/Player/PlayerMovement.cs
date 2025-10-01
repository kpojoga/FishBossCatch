using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;
    public Camera playerCamera;


    float maxVelocityChange = 10.0f;

    Rigidbody _rigidbody;
    Vector2 rotation = Vector2.zero;
    [SerializeField] private Animator _animator;
    [SerializeField] private FloatingJoystick _joystick;
    [SerializeField] private PlayerData _playerData;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.freezeRotation = true;
        _rigidbody.useGravity = false;
        _rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        rotation.y = transform.eulerAngles.y;
    }

    private void FixedUpdate()
    {
        Vector3 forwardDir = Vector3.Cross(transform.up, -playerCamera.transform.right).normalized;
        Vector3 rightDir = Vector3.Cross(transform.up, playerCamera.transform.forward).normalized;


        Vector3 targetVelocity = (forwardDir * _joystick.Vertical + rightDir * _joystick.Horizontal) * speed;

        Vector3 velocity = transform.InverseTransformDirection(_rigidbody.velocity);
        velocity.y = 0;
        velocity = transform.TransformDirection(velocity);
        Vector3 velocityChange = transform.InverseTransformDirection(targetVelocity - velocity);
        velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
        velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
        velocityChange.y = 0;
        velocityChange = transform.TransformDirection(velocityChange);

        _rigidbody.AddForce(velocityChange, ForceMode.VelocityChange);


        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            if (velocity.magnitude > 0.1f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(velocity.normalized);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.6f);
            }


            _animator.SetBool("isWalking", true);
        }
        else
        {
            _animator.SetBool("isWalking", false);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Tree")
        {
            _animator.SetBool("isWalking", false);
        }
    }
}
