using UnityEngine;

public class CameraOffset : MonoBehaviour
{
    public GameObject player;
    float offsetX = 11.55f;
    float offsetZ = 3.55f;
    int cameraHeight = 23;
    
    void Update()
    {
        Vector3 playerpos; 
        

        // Horizontal checks (left and right)
        if (player.transform.position.x > offsetX)
        {
            playerpos = new Vector3(offsetX, player.transform.position.y + cameraHeight, player.transform.position.z);
            transform.position = playerpos;
        }
        else if (player.transform.position.x < -offsetX)
        {
            playerpos = new Vector3(-offsetX, player.transform.position.y + cameraHeight, player.transform.position.z);
            transform.position = playerpos;
        }

        // Vertical checks (top and bottom)
        if (player.transform.position.z > offsetZ)
        {
            playerpos = new Vector3(player.transform.position.x, player.transform.position.y + cameraHeight, offsetZ);
            transform.position = playerpos;
        }
        else if (player.transform.position.z < -offsetZ)
        {
            playerpos = new Vector3(player.transform.position.x, player.transform.position.y + cameraHeight, -offsetZ);
            transform.position = playerpos;
        }

        // Diagonal checks (top-right, top-left, bottom-right, bottom-left)
        if (player.transform.position.x > offsetX && player.transform.position.z > offsetZ)
        {
            playerpos = new Vector3(offsetX, player.transform.position.y + cameraHeight, offsetZ);
            transform.position = playerpos;
        }
        else if (player.transform.position.x < -offsetX && player.transform.position.z > offsetZ)
        {
            playerpos = new Vector3(-offsetX, player.transform.position.y + cameraHeight, offsetZ);
            transform.position = playerpos;
        }
        else if (player.transform.position.x > offsetX && player.transform.position.z < -offsetZ)
        {
            playerpos = new Vector3(offsetX, player.transform.position.y + cameraHeight, -offsetZ);
            transform.position = playerpos;
        }
        else if (player.transform.position.x < -offsetX && player.transform.position.z < -offsetZ)
        {
            playerpos = new Vector3(-offsetX, player.transform.position.y + cameraHeight, -offsetZ);
            transform.position = playerpos;
        }

        // Center position check to prevent camera jittering
        if (player.transform.position.x >= -offsetX && player.transform.position.x <= offsetX &&
            player.transform.position.z >= -offsetZ && player.transform.position.z <= offsetZ)
        {
            // If the player is within the "center" bounds, ensure the camera remains centered.
            playerpos = new Vector3(player.transform.position.x, player.transform.position.y + cameraHeight, player.transform.position.z);
            transform.position = playerpos;
        }




    }
}
