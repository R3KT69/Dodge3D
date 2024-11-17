using UnityEngine;

public class CheckGameState : MonoBehaviour
{
    public PlayerHealth health;    // Reference to the player's health
    public GameObject textPrefab;  // Text prefab to instantiate
    public Vector3 textPosition = new Vector3(0, 0, 0); // Custom position for the text

    void EndGame()
    {
        GameObject textInstance = Instantiate(textPrefab, transform);

        // Get the RectTransform of the instantiated text
        RectTransform textRectTransform = textInstance.GetComponent<RectTransform>();
        
        if (textRectTransform != null)
        {
            // Set the position of the text (can be customized)
            textRectTransform.localPosition = textPosition;

            // Optionally, reset the local scale if needed
            textRectTransform.localScale = Vector3.one;
        }

        Time.timeScale = 0f;
    }
    void Update()
    {
        // Check if the player's health is less than or equal to 0
        if (health.p_health <= 0)
        {
            Debug.Log("Game Over");

            Invoke("EndGame", 0f);
            this.enabled = false;
        }
    }
}
