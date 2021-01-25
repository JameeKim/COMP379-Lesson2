using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce = 5;
    public Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            // move right
            rigidBody.AddForce(Vector3.right * movementForce);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            // move left
            rigidBody.AddForce(Vector3.left * movementForce);
        }
    }
}
