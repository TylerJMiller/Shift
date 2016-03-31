using UnityEngine;
using System.Collections;

public class FlatHandler : MonoBehaviour
{

    TDObject[] tdWalls;
    TDObject[] tdEnemies;
    TDObject[] tdInteractables;
    TDObject tdPlayer;

    bool orthoMode;

    // Use this for initialization
    void Start()
    {
        //search for all walls and set wall array
        //search for all enemies and set enemies array
        //search for all interactables and set interactables array

        //search for player
        //fail if no player or player is null
        //set player


    }

    // Update is called once per frame
    void Update ()
    {

        //COORDINATES MUST BE IN LOCAL SPACE NOT WORLD SPACE
        //TRANSFORMS PROBABLY WON'T WORK
        //GET/SET EVERY FRAME? (EXPENSIVE?)

        //check player against all walls
        //check player against all enemies
        //check player against all interactables

        //player movement input

        //check future player against all walls
        //check future player against all enemies
        //check future player against all interactables

        //player movement input against collision

        //player movement logic



    }
}
