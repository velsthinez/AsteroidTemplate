using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Asteroid : MonoBehaviour
{
    public float MinForce = 1f;
    public float MaxForce = 10f;

    public GameObject DeathParticles;
    public GameObject DeathSound;

    public int Health = 1;
    public int Score = 100;
    private Rigidbody2D _rigidbody;

    protected ScorePanel _scorePanel;

    // Start is called before the first frame update
    void Start()
    {
        // we shall add a randomDirection when we are spawned
    }

    /// <summary>
    /// Take Damage through SendMessage
    /// Will destroy gameObject when health drops to 0 or lower
    /// </summary>
    void Damage()
    {
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        // sendMessage to the collided gameObject
    }

    public void SetupScorePanel(ScorePanel scorePanel)
    {
        _scorePanel = scorePanel;
    }
}
