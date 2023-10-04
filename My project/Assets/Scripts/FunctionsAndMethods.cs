using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsAndMethods : MonoBehaviour
{
    public int Score = 0;

    private int _playerHealthAmount = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Method Examples

    //This Method is accesible from other files because it is Public.
    public void updatePlayerHealth(int amount)
    {
        _playerHealthAmount -= amount;
    }

    //This Method is not accesible from other files
    private void IncreaseScore()
    {
        Score++; //Score = Score + 1;
    }

    private void MovePLayer()
    {
      transform.Translate(Vector3.forward);
    }
}
