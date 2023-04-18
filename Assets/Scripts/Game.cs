using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    Ball ball;

    [SerializeField]
    Paddle bottomPaddle, topPaddle;

    void Awake() => ball.StartNewGame();

    void Start()
    {
        
    }

    void Update()
    {
        ball.Move();
        ball.UpdateVisualization();
    }
}
