using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 350f;     // Adjust the speed of the camera movement
    public float smoothness = 0.5f;   // Adjust the smoothness of camera movement
    public float minDistance = 10f;    // Minimum distance from the target
    public float maxDistance = 50f;   // Maximum distance from the target
    public Transform target;          // The target object to follow (optional)
    private float currentDistance;    // Current distance from the target
    
    void Awake()
    {
        float newDistance = Mathf.Clamp(Vector3.Distance(transform.position, target.position) - 1, minDistance, maxDistance);
        transform.position = target.position - transform.forward * newDistance;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentDistance = Mathf.Clamp(Vector3.Distance(transform.position, target.position), minDistance, maxDistance);
    }

    // Update is called once per frame
    void Update()
    {
        Scroll(GetInput());
    }

    float GetInput(){
        return Input.GetAxis("Mouse ScrollWheel");
    }

    void Scroll(float input){
        // Limit input values
        input = Mathf.Clamp(input, -1f, 1f);
        float moveDelta = input * moveSpeed;

        // Calculate the new distance from the target
        currentDistance = Mathf.Clamp(currentDistance - moveDelta, minDistance, maxDistance);

        // Update the camera's position smoothly
        Vector3 targetPosition = target.position - transform.forward * currentDistance;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothness);
    }
}
