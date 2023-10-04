using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Public Global/Members Variables
    public int Score = 0; // declare a whole number
    public float ItemAmount = 19.95f; // declare decimal number
    public string PlayerName = "John Doe"; //declare a text
    public bool IsPlayerActive = true; //declare a true/false statement.

    //Private Global/Member Variables
    private int _collectivbleAmount = 0; // declare a whole number
    private float _horizontalInput = 0f;
    private string _UserName = "John007";
    private bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        //make a  Score Variable is = 0
        Score = 0; //assigning a Global/Member variable
        // declare a local variable to track Starty Position
        Vector3 startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //trying to update a local variables value
        // we can not update a loca lvariable
        //startPosition = new vector(Vector.right);

        //Create a variable to determine object key movement
        float verticalInput = Input.GetAxis("Vertical");
    }
}
