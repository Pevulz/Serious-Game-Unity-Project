using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    float yRestriction = 1.77f;
    float BoundaryRadius = 0.1f;
    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 1f;
    private float characterVelocity = 9f;
    private Vector2 movementDirection;
    private Vector2 movementPerSecond;
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        latestDirectionChangeTime = 1f;
        calcuateNewMovementVector();
    }
    void calcuateNewMovementVector()
    {
        //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
        movementDirection = new Vector2(Random.Range(-1.0f, 1.0f), 0).normalized;
        movementPerSecond = movementDirection * characterVelocity;
    }
    // Update is called once per frame
    void Update()
    {

        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }
        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime),
        transform.position.y + 0);
        Vector3 pos = transform.position;
        //pos.y += Random.Range(-1.0f, 1.0f) * maxSpeed * Time.deltaTime;
        //pos.x += Random.Range(-1.0f, 1.0f) * maxSpeed * Time.deltaTime;
        if (pos.y + BoundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - BoundaryRadius;
        }
        if (pos.y - BoundaryRadius < -yRestriction)
        {
            pos.y = -yRestriction + BoundaryRadius;
        }

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        // Now do horizontal bounds
        if (pos.x + BoundaryRadius > widthOrtho)
        {
            spriteRenderer.flipX = false;
            pos.x = widthOrtho - BoundaryRadius;
        }
        if (pos.x - BoundaryRadius < -widthOrtho)
        {
            spriteRenderer.flipX = true;
            pos.x = -widthOrtho + BoundaryRadius;
        }
        transform.position = pos;

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("HIT!");
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
