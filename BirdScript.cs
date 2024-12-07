using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D bird;
    public LogicScript logic;
    public float flapStrength = 10;
    private bool canFlop = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        canFlop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canFlop)
        {
            bird.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canFlop = false;
        logic.gameOver();
    }

}
