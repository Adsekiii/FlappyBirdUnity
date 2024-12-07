using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float pipeScrollSpeed = 10;
    public float deadZone = -50;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * pipeScrollSpeed * Time.deltaTime);

        if (transform.position.x < deadZone)
        {
            Debug.Log("pipe deleted!");
            Destroy(gameObject);
        }

    }


}
