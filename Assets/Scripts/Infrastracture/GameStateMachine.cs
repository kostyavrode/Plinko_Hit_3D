using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameStateMachine
{
    private Dictionary<Type, IExitableState> states;
    private IExitableState activeState;

    public GameStateMachine(SceneLoader sceneLoader,LoadingCurtain loadingCurtain)
    {
        states = new Dictionary<Type, IExitableState>
        {
            //[typeof(Boots)]
        };
    }
}
