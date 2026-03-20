using UnityEngine;

public class flightController : MonoBehaviour
{  [SerializeField] private float pitchSpeed  = 45f;  // degrees/second 
    [SerializeField] private float yawSpeed    = 45f;  // degrees/second 
    [SerializeField] private float rollSpeed   = 45f;  // degrees/second 
    [SerializeField] private float thrustSpeed = 5f;   // units/second 
 
    private Rigidbody planeRb; 
 
    void Start() 
    { 
        void Start()
        {
            planeRb = GetComponent<Rigidbody>();
            planeRb.freezeRotation = true;
        }
    } 
 
    void Update()// or FixedUpdate() 
    { 
        HandleRotation(); 
        HandleThrust(); 
    } 
 
    private void HandleRotation() 
    { 
        // TODO (Task 3-C): 
        // Pitch   
        // Roll    
 
    } 
 
    private void HandleThrust() 
    { 
        // TODO (Task 3-D): 
    } 
    
}
