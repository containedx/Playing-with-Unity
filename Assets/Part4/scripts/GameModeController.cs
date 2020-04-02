using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameModeController : MonoBehaviour
{
    public Camera camera; 
    public BaseGameMode gameMode;
    public PlayerInfo playerInfo;

    public BaseGameMode modetoChange; 

    private void Start()
    {
        gameMode.Init(this); 
    }

    [ContextMenu("Changing Mode")]
    public void ChangeMode()
    {
        gameMode?.Deinit(this);
        gameMode = modetoChange;
        modetoChange?.Init(this);              
    }

    private void Update()
    {
        camera.backgroundColor = Color.Lerp(camera.backgroundColor, gameMode.BackgroundColor, Time.deltaTime * gameMode.TransitionSpeed);
        Time.timeScale = Mathf.Lerp(Time.timeScale, gameMode.TimeScale, Time.deltaTime * gameMode.TransitionSpeed); 
    }


}
