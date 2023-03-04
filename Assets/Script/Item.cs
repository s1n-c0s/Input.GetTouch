using UnityEngine;

public class Item : MonoBehaviour
{
    public ModeManager modeManager;
    public RandomMode randomMode;
    public bool setMode;
    public int newModeIndex;

    public float minSpeed = 1f; // Minimum speed at which the object moves
    public float maxSpeed = 5f; // Maximum speed at which the object moves
    public float loopDistance = 5f; // Distance the object moves before looping

    private float startPosition; // Starting position of the object
    private bool movingLeft = true; // Whether the object is currently moving left or right
    private float currentSpeed; // Current speed of the object

    void Start()
    {
        startPosition = transform.position.x; // Get the starting position of the object
        currentSpeed = Random.Range(minSpeed, maxSpeed); // Set the initial speed of the object to a random value
    }

    void Update()
    {
        float direction = movingLeft ? -1f : 1f; // Determine the direction the object should move

        transform.Translate(Vector3.right * direction * currentSpeed * Time.deltaTime); // Move the object using the current speed

        // If the object has moved the loop distance, reverse its direction and set a new random speed
        if (movingLeft && transform.position.x < startPosition - loopDistance)
        {
            movingLeft = false;
            currentSpeed = Random.Range(minSpeed, maxSpeed);
        }
        else if (!movingLeft && transform.position.x > startPosition + loopDistance)
        {
            movingLeft = true;
            currentSpeed = Random.Range(minSpeed, maxSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        item_Set(setMode);
        Destroy(gameObject);
    }

    public void item_Set(bool item_setMode)
    {
        if (item_setMode)
        {
            modeManager.SetMode(newModeIndex);
        }
        else
        {
            randomMode.ChangeModeRandomly();
        }
    }
}
