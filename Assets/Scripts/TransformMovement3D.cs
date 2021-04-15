using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement3D : MonoBehaviour, IGetMovementInput
{
    public PlayerInput input;
    public float period;
    float time;
    Queue<Vector2> directions;

    public void GiveInput(Vector2 direction)
    {
        directions.Enqueue(direction);
    }

    // Start is called before the first frame update
    void Start()
    {
        directions = new Queue<Vector2>();
    }

    /************
     * We're currently using keys to control movement
     * so the values of the input will be 0, 1, or -1
     * for stick input we may want to handle movement
     * in a different way
     */
    void Update()
    {
        time -= Time.deltaTime;
        if (directions.Count < 1) return;
        if (time > 0) return;
        time = period;
        Vector2 tempDir = directions.Dequeue();
        transform.Translate(tempDir.x, 0, tempDir.y);
    }
}
