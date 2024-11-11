using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBootStrapper : MonoBehaviour, ICoroutineRunner
{
    public LoadingCurtain Curtain;
    private Game game;

    private void Awake()
    {
        game = new Game(this, Curtain);

    }
}
