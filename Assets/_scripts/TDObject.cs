using UnityEngine;
using System.Collections;

public enum TDTYPE { WALL, ENEMY, INTERACT}

public class TDObject
{

    public bool TDColliding;
    public bool TDCollidingNext;
    public TDTYPE TDType;
    public Transform TDTransform;
     
    float width;
    float height;

    //create out of type and transform
    public void Set(TDTYPE objectType, Transform objectTransform)
    {
        TDColliding = false;
        TDCollidingNext = false;
        TDType = objectType;
        TDTransform = objectTransform;
    }

    //take player as tdbox and check collision

    //player input

    //player movement

    //player update

}
