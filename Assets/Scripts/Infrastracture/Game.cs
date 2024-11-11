using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    public GameStateMachine stateMachine;
    public InputService InputService;

    public Game(ICoroutineRunner coroutineRunner,LoadingCurtain curtain)
    {
        stateMachine=new GameStateMachine(new SceneLoader(coroutineRunner),curtain);
    }
}
