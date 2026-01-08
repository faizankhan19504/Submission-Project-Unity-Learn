using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Direct Hit on Enemy!");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
