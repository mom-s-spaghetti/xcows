using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prova : MonoBehaviour
{
    public Transform move;

    private void Awake()
    {
        move = gameObject.GetComponent<Transform>();
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(move.position.x);
        move.position.Set(1, 1, 1);
        Debug.Log(move.position.x);
    }

 }    
