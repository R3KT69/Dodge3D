using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int p_health = 3;

    void printHealth()
    {
        Debug.Log(p_health);
    }
    
    void Start()
    {
        InvokeRepeating("printHealth", 0f,1f);
    }
}
