using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrapState : IState
{
    private const string Initial = "Initial";
    private GameStateMachine stateMachine;
    private readonly SceneLoader sceneLoader;


    public BootStrapState(GameStateMachine stateMachine,SceneLoader sceneLoader)
    {
        this.stateMachine = stateMachine;
        this.sceneLoader = sceneLoader;
    }

    public void Enter()
    {
        RegisterServices();
        sceneLoader.Load(Initial,EnterLoadLevel);
    }

    public void Exit()
    {
        
    }

    private void EnterLoadLevel()
    {
        stateMachine.Enter<LoadLevelState,string>("Main");
    }

    private void RegisterServices()
    {
        //Game.InputService = RegisterServiceInput();
    }

    private static IInputService RegisterServiceInput()
    {
        if (Application.isEditor)
        {
            return new StandaloneInputService();
        }
        else
        {
            return new MobileInputService();
        }
    }
}
