using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // declare variables 

    
    // essentials part of 
    Rigidbody2D _rigidbody2D;

    public Vector3 TargetMovement { get { return _targetMovement; } set { _targetMovement = value; } }
    private Vector3 _targetMovement;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DoTorque();

        DoStrafe();
        
        DoForward();
    }

    /// <summary>
    /// Handles forward movement using _targetMovement.y
    /// </summary>
    protected virtual void DoForward()
    {
        if (_rigidbody2D == null)
            return;
     
        // we apply force for moving forward
        // else we slow down

    }

    /// <summary>
    /// Handles forward movement using _targetMovement.z
    /// </summary>
    protected virtual void DoStrafe()
    {
        if (_rigidbody2D == null)
            return;
        
        // we apply force for moving sideways
    }

    /// <summary>
    /// Handles forward movement using _targetMovement.x
    /// </summary>
    protected virtual void DoTorque()
    {
        if (_rigidbody2D == null)
            return;

        // we apply force for rotation
        // else we slow down
    }
    
  

}
