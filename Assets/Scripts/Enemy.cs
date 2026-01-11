using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Variable Declare
    private float zRange = -12f;
    
    private void Update()
    {
        Action();
        BoundaryLimiter();
    }
    
    // Override Function
    public virtual void Action()
    {
        Debug.Log("Action Done!");
    }
    
    // Check for Boundary 
    private void BoundaryLimiter()
    {
        if (transform.position.z < zRange)
        {
            Debug.Log("limit reached");
            Destroy(gameObject);
            Player.Instance.TriggerManualGameOver();
        }
    }
}
