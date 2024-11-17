using System;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject weight;
    public GameObject player;
    int dropHeight = 25;
    int dropOffset;
    //  (UnityEngine.Random.Range(-19, 19) UnityEngine.Random.Range(-9, 9)
    
    void Spawn()
    {
        
        Vector3 playerpos = new Vector3(UnityEngine.Random.Range(-19, 19), player.transform.position.y + dropHeight, UnityEngine.Random.Range(-9, 9));
        Vector3 playerpos2 = new Vector3(player.transform.position.x + UnityEngine.Random.Range(-4, 4),player.transform.position.y + dropHeight, player.transform.position.z + UnityEngine.Random.Range(-4, 4));
        
        Instantiate(weight, playerpos, quaternion.identity);
        Instantiate(weight, playerpos2, quaternion.identity);
        
    }

    void SpawnQuad()
    {
        dropOffset = UnityEngine.Random.Range(3, 7);
        Vector3 playerposQ1 = new Vector3(player.transform.position.x + dropOffset,player.transform.position.y + dropHeight, player.transform.position.z);
        Vector3 playerposQ2 = new Vector3(player.transform.position.x - dropOffset,player.transform.position.y + dropHeight, player.transform.position.z);
        Vector3 playerposQ3 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z + dropOffset);
        Vector3 playerposQ4 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z - dropOffset);
        Instantiate(weight, playerposQ1, quaternion.identity);
        Instantiate(weight, playerposQ2, quaternion.identity);
        Instantiate(weight, playerposQ3, quaternion.identity);
        Instantiate(weight, playerposQ4, quaternion.identity);
    }

    void SpawnStar()
    {
        dropOffset = UnityEngine.Random.Range(3, 5);
        Vector3 playerposQ1 = new Vector3(player.transform.position.x + dropOffset,player.transform.position.y + dropHeight, player.transform.position.z + dropOffset);
        Vector3 playerposQ2 = new Vector3(player.transform.position.x - dropOffset,player.transform.position.y + dropHeight, player.transform.position.z - dropOffset);
        Vector3 playerposQ3 = new Vector3(player.transform.position.x + dropOffset,player.transform.position.y + dropHeight, player.transform.position.z - dropOffset);
        Vector3 playerposQ4 = new Vector3(player.transform.position.x - dropOffset,player.transform.position.y + dropHeight, player.transform.position.z + dropOffset);
        Instantiate(weight, playerposQ1, quaternion.identity);
        Instantiate(weight, playerposQ2, quaternion.identity);
        Instantiate(weight, playerposQ3, quaternion.identity);
        Instantiate(weight, playerposQ4, quaternion.identity);
    }

    void SpawnWallHorizontal()
    {
        Vector3 playerposQ1 = new Vector3(player.transform.position.x + 5,player.transform.position.y + dropHeight, player.transform.position.z);
        Vector3 playerposQ2 = new Vector3(player.transform.position.x + 7,player.transform.position.y + dropHeight, player.transform.position.z);
        Vector3 playerposQ3 = new Vector3(player.transform.position.x + 9,player.transform.position.y + dropHeight, player.transform.position.z);
        Vector3 playerposQ4 = new Vector3(player.transform.position.x + 11,player.transform.position.y + dropHeight, player.transform.position.z);
        Instantiate(weight, playerposQ1, quaternion.identity);
        Instantiate(weight, playerposQ2, quaternion.identity);
        Instantiate(weight, playerposQ3, quaternion.identity);
        Instantiate(weight, playerposQ4, quaternion.identity);
    }

    void SpawnWallVertical()
    {
        Vector3 playerposQ1 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z + 5);
        Vector3 playerposQ2 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z + 7);
        Vector3 playerposQ3 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z + 9);
        Vector3 playerposQ4 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z + 11);
        Instantiate(weight, playerposQ1, quaternion.identity);
        Instantiate(weight, playerposQ2, quaternion.identity);
        Instantiate(weight, playerposQ3, quaternion.identity);
        Instantiate(weight, playerposQ4, quaternion.identity);
    }

    void SpawnWallHorizontal_L()
    {
        Vector3 playerposQ1 = new Vector3(player.transform.position.x - 5,player.transform.position.y + dropHeight, player.transform.position.z);
        Vector3 playerposQ2 = new Vector3(player.transform.position.x - 7,player.transform.position.y + dropHeight, player.transform.position.z);
        Vector3 playerposQ3 = new Vector3(player.transform.position.x - 9,player.transform.position.y + dropHeight, player.transform.position.z);
        Vector3 playerposQ4 = new Vector3(player.transform.position.x - 11,player.transform.position.y + dropHeight, player.transform.position.z);
        Instantiate(weight, playerposQ1, quaternion.identity);
        Instantiate(weight, playerposQ2, quaternion.identity);
        Instantiate(weight, playerposQ3, quaternion.identity);
        Instantiate(weight, playerposQ4, quaternion.identity);
    }

    void SpawnWallVertical_L()
    {
        Vector3 playerposQ1 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z - 5);
        Vector3 playerposQ2 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z - 7);
        Vector3 playerposQ3 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z - 9);
        Vector3 playerposQ4 = new Vector3(player.transform.position.x,player.transform.position.y + dropHeight, player.transform.position.z - 11);
        Instantiate(weight, playerposQ1, quaternion.identity);
        Instantiate(weight, playerposQ2, quaternion.identity);
        Instantiate(weight, playerposQ3, quaternion.identity);
        Instantiate(weight, playerposQ4, quaternion.identity);
    }

    void Phase1()
    {
        InvokeRepeating("Spawn", 0f, 2f);
        Debug.Log("Started Phase1");
    }

    void Phase2()
    {
        InvokeRepeating("SpawnQuad", 0f, 5f);
        InvokeRepeating("SpawnStar", 0f, 5f);
        Debug.Log("Started Phase2");
        
        
    }

    void Phase3()
    {
        InvokeRepeating("SpawnWallHorizontal_L", 0f, 2.5f);
        InvokeRepeating("SpawnWallHorizontal", 0f, 2.5f);
        Debug.Log("Started Phase3");
    }

    void Phase4()
    {
        InvokeRepeating("SpawnWallVertical", 0f, 2.5f);
        InvokeRepeating("SpawnWallVertical_L", 0f, 2.5f);
        Debug.Log("Started Phase4");
    }
    
    void Start()
    {
        Invoke("Phase1", 2f);
        Invoke("Phase2", 12f);
        Invoke("Phase3", 24f);
        Invoke("Phase4", 48f);
        
        
    }

    


}
