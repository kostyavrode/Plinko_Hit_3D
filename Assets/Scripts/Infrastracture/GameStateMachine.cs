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
            [typeof(BootStrapState)] = new BootStrapState(this, sceneLoader),
            [typeof(LoadLevelState)] = new LoadLevelState(this, sceneLoader, loadingCurtain),
            [typeof(GameLoopState)] = new GameLoopState(this)
        };
    }

    public void Enter<TState>() where TState : class, IState
    {
        IState state = ChangeState<TState>();
        state.Enter();
    }

    public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>
    {
        TState state = ChangeState<TState>();
        state.Enter(payload);
    }

    private TState ChangeState<TState>() where TState : class, IExitableState
    {
        activeState?.Exit();

        TState state = GetState<TState>();
        activeState = state;

        return state;
    }

    private TState GetState<TState>() where TState : class, IExitableState =>
      states[typeof(TState)] as TState;
}
