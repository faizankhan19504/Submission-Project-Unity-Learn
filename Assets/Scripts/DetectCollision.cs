using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Triggered when the projectile overlaps with another collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy hit by a projectile!");

            // Call AddScore function from MainManager singleton instance
            MainManager.Instance.AddPoint(1);

            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
