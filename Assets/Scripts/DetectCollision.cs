using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Triggered when the projectile overlaps with another collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Direct Hit on Enemy!");

            // Find the MainManager in the scene and call the AddScore function
            GameObject.Find("MainManager").GetComponent<MainManager>().AddPoint(1);

            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
