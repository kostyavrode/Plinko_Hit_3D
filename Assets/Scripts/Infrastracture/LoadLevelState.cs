using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevelState : IPayloadedState<string>
{

    private const string BallPath = "Ball/ball";
    private const string InitialPointTag = "InitialPoint";
    private const string HudPath = "Hud/hud";

    private readonly GameStateMachine stateMachine;
    private readonly SceneLoader sceneLoader;
    private readonly LoadingCurtain loadingCurtain;

    public LoadLevelState(GameStateMachine stateMachine, SceneLoader sceneLoader, LoadingCurtain loadingCurtain)
    {
        this.stateMachine = stateMachine;
        this.sceneLoader = sceneLoader;
        this.loadingCurtain = loadingCurtain;
    }

    public void Enter(string sceneName)
    {
        loadingCurtain.Show();
        sceneLoader.Load(sceneName, onLoaded);
    }

    public void Exit()
    {
        loadingCurtain?.Hide();
    }

    private void onLoaded()
    {
        var initialPoint = GameObject.FindWithTag(InitialPointTag);
        GameObject ball = Instantiate(BallPath, at: initialPoint.transform.position);
        Instantiate(HudPath);

        //CameraFollow(ball);

        stateMachine.Enter<GameLoopState>();
    }

    private static GameObject Instantiate(string path)
    {
        var ballPrefab=Resources.Load<GameObject>(path);
        return Object.Instantiate(ballPrefab);
    }

    private static GameObject Instantiate(string path,Vector3 at)
    {
        var ballPrefab = Resources.Load<GameObject>(path);
        return Object.Instantiate(ballPrefab,at,Quaternion.identity);
    }
}
