using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    [SerializeField]
    private Brick previousBrick;
    [SerializeField]
    private Brick currentBrick;

    public float threshold; 

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StackBricks(); 
        }
    }

    public void StackBricks()
    {
        float difference = previousBrick.leftEdge - currentBrick.leftEdge;
        //Debug.Log(difference); 

        currentBrick.proocedMove = false;
        currentBrick.transform.position = previousBrick.transform.position + Vector3.up; 

        if(difference > threshold)
        {
            currentBrick.UpdateLine(previousBrick.leftPosition.x, currentBrick.rightPosition.x - difference);
            currentBrick.UpdateLine(); 
        }
        else if ( difference < -threshold )
        {
            currentBrick.UpdateLine(currentBrick.leftPosition.x - difference, previousBrick.rightPosition.x);
            currentBrick.UpdateLine();
        }
    }
}
