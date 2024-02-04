using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb; // This is a reference to the Rigidbody component called "rb".

    public float Forward_Force = 2000f; // Variable that determines the forward force and In 2000f, f is used for float.
    public float Sideways_Force = 500f; //Variable that determines the sideways force.

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, User!"); //Prints Hello User in the console.
    }

    // Update is called once per frame
    void FixedUpdate() // We changed Update to "FixedUpdate" because we are using it to properly work with physics.
    {
        rb.AddForce(0,0,Forward_Force * Time.deltaTime); // It adds a force of 2000 on the z-axis, whereas time.deltatime is multiplied to achieve frame rate stabilisation.
        
        if(Input.GetKey("d")) //Only executes when condition is met i.e. When the user presses "d".
        {
            // Adds a force to the right.
            rb.AddForce(Sideways_Force * Time.deltaTime,0,0,ForceMode.VelocityChange); 
        }

         if(Input.GetKey("a")) //Only executes when condition is met i.e. When the user presses "a".
        {
            // Adds a force to the left.
            rb.AddForce(-Sideways_Force * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f) // If the player reaches below the ground then this condition executes.
        {
            // This will call the function EndGame of GameManager script. 
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }
}
