using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [Header("Line Atributes")]
    public LineRenderer brickRenderer;
    public Vector3 leftPosition;
    public Vector3 rightPosition;

    [Header("Movement Atributes")]
    public BrickMovement movement;
    public bool proocedMove; 

    public void Start()
    {
        brickRenderer.positionCount = 2; // bo zawsze 2 pozycje 
        brickRenderer.SetPosition(0, leftPosition);   //przypisanie pozycji 
        brickRenderer.SetPosition(1, rightPosition);
    }

    public void Update()
    {
        //aktualizacja ruchu 
        if(proocedMove)
            movement?.UpdatePosition(transform);  // transform tego obiektu 
    }


}

[System.Serializable]
public class BrickMovement
{
    public float speed;
    public float range; 

    public void UpdatePosition(Transform brickTransform)
    {
        //poruszaj od -r do r z szybkoscia speed
        var newX = Mathf.Lerp(-range, range, Mathf.InverseLerp(-1f, 1f, Mathf.Sin(Time.time * speed))); 

        //zmieniamy tylko X
        brickTransform.position = new Vector3(newX, brickTransform.position.y, brickTransform.position.z); 
        
    }
}
