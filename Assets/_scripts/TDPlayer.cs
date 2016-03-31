using UnityEngine;
using System.Collections;

public class TDBox
{
    public float x;
    public float y;
    public float width;
    public float height;
}

public class TDPlayer
{
    public Transform TDTransform;
    float width;
    float height;


    public void Set(Transform playerTransform)
    {
        TDTransform = playerTransform;
    }

    //return tdbox of player width and height

}