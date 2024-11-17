using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;

    void Update()
    {
        // Get input for movement
        float moveX = 0;
        float moveZ = 0;

        if (Input.GetKey(KeyCode.W)) moveZ = 1;
        if (Input.GetKey(KeyCode.A)) moveX = -1;
        if (Input.GetKey(KeyCode.S)) moveZ = -1;
        if (Input.GetKey(KeyCode.D)) moveX = 1;

        // Create movement vector
        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        // Apply movement with CharacterController
        controller.Move(move * speed * Time.deltaTime);
    }
}
