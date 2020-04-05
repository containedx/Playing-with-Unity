using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    public Brick previousBrick;  
    public Brick currentBrick;

    public float threshold;

    public Brick brickPrefab; 

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StackBricks(); 
        }
    }

    public void CreateNewBrick()
    {
        previousBrick = currentBrick;
        currentBrick = Instantiate(brickPrefab); 
    }

    public void StackBricks()
    {
        CutBrick(); 

        //CreateNewBrick(); 
    }

    public void CutBrick()
    {
        float difference = previousBrick.leftEdge - currentBrick.leftEdge;

        currentBrick.movement.proocedMove = false;
        currentBrick.transform.position = previousBrick.transform.position + Vector3.up;

        if (difference > threshold)
        {
            currentBrick.UpdateLine(previousBrick.leftPosition.x, currentBrick.rightPosition.x - difference);
            CreateLeftOver(currentBrick.leftPosition.x - difference, currentBrick.leftPosition.x);
        }
        else if (difference < -threshold)
        {
            currentBrick.UpdateLine(currentBrick.leftPosition.x - difference, previousBrick.rightPosition.x);
            CreateLeftOver(currentBrick.rightPosition.x, currentBrick.rightPosition.x - difference);
        }
    }

    public void CreateLeftOver(float leftEdge, float rightEdge)
    {
        Brick leftover = Instantiate(brickPrefab);
        leftover.transform.position = currentBrick.transform.position;
        leftover.UpdateLine(leftEdge, rightEdge);
        leftover.AddGravity(); 
    }

}
