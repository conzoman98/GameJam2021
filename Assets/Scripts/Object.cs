using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Declare object qualifiers
    public enum Colour
    {
        red,
        yellow,
        blue,
        green
    };

    public enum Shape
    {
        square,
        triangle,
        circle,
        freeform
    };

    public enum Quality
    {
        shiny,
        rusty,
        broken,
        standard
    };

    public Colour objectColour;
    public Shape objectShape;
    public Quality objectQuality;

    public int value;

    // Start is called before the first frame update
    private void Start()
    {
        Generate();
    }

    public void Generate()
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                objectColour = Colour.red;
                break;
            case 1:
                objectColour = Colour.yellow;
                break;
            case 2:
                objectColour = Colour.blue;
                break;
            case 3:
                objectColour = Colour.green;
                break;
        }

        switch (Random.Range(0, 3))
        {
            case 0:
                objectShape = Shape.square;
                break;
            case 1:
                objectShape = Shape.triangle;
                break;
            case 2:
                objectShape = Shape.circle;
                break;
            case 3:
                objectShape = Shape.freeform;
                break;
        }

        switch (Random.Range(0, 3))
        {
            case 0:
                objectQuality = Quality.shiny;
                break;
            case 1:
                objectQuality = Quality.rusty;
                break;
            case 2:
                objectQuality = Quality.broken;
                break;
            case 3:
                objectQuality = Quality.standard;
                break;
        }

        value = Random.Range(1, 5);
    }

    public int compare(Object otherObject, int difficulty)
    {
        int differences = 0;

        if (objectShape != otherObject.objectShape) differences++;
        if (difficulty > 0 && objectColour != otherObject.objectColour) differences++;
        if (difficulty > 1 && objectQuality != otherObject.objectQuality) differences++;

        return differences;
    }
}
