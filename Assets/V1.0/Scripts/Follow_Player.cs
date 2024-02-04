using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public Transform player; // Transform gives the information about the position
    
    public Vector3 offset; // Vector3 is a datatype in which we can store 3 floats, basically a x, y, and z-axis.

    // Update is called once per frame
    void Update()
    {
        //transform.position refers to the position of current game object i.e. main camera
        transform.position = player.position + offset; //Here the position of main camera is equals to player position + the position with a custom values of x, y, z-axis.
    }
}
