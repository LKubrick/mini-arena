using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;

public class GetIn : MonoBehaviour
{
    public GameObject tank;
    public GameObject character;

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        tank.SetActive(true);
        character.SetActive(false);
    }
}
