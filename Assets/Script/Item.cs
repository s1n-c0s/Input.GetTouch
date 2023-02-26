using UnityEngine;

public class Item : MonoBehaviour
{
    public ModeManager modeManager;
    public RandomMode randomMode;
    public bool SetMode;
    public int newModeIndex;


    public float speed = 3f; // Speed at which the object moves
    public float loopDistance = 5f; // Distance the object moves before looping

    private float startPosition; // Starting position of the object
    private bool movingLeft = true; // Whether the object is currently moving left or right

    void Start()
    {
        startPosition = transform.position.x; // Get the starting position of the object
    }


    void Update()
    {
        float direction = movingLeft ? -1f : 1f; // Determine the direction the object should move

        transform.Translate(Vector3.right * direction * speed * Time.deltaTime); // Move the object

        // If the object has moved the loop distance, reverse its direction
        if (movingLeft && transform.position.x < startPosition - loopDistance)
        {
            movingLeft = false;
        }
        else if (!movingLeft && transform.position.x > startPosition + loopDistance)
        {
            movingLeft = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        item_Set(SetMode);
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
