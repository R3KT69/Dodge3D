using Unity.VisualScripting;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public GameObject Object;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public PlayerHealth health;
    void OnTriggerEnter()
    {
        if (Object.CompareTag("Weight"))
        {
            if (health.p_health == 3)
            {
                Destroy(heart3);
            }
            if (health.p_health == 2)
            {
                Destroy(heart2);
            }
            if (health.p_health == 1)
            {
                Destroy(heart1);
            }
            Debug.Log("Hit head");
            health.p_health -= 1;
            
        }
    }
}
