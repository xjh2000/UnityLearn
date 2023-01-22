using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 5.0f;
    private Rigidbody _playerRb;
    private float _zBound = 6;


    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        _playerRb.AddForce(Vector3.forward * (_speed * verticalInput));
        _playerRb.AddForce(Vector3.right * (_speed * horizontalInput));

        if (transform.position.z < -_zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -_zBound);
        }

        if (transform.position.z > _zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, _zBound);
        }
    }
}