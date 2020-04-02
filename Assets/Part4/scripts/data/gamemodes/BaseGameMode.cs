using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameMode", menuName = "Modes/GameMode", order = 0)]
public class BaseGameMode : ScriptableObject
{
    [SerializeField]
    private float timeScale;
    public float TimeScale => timeScale;

    [SerializeField]
    private Color backgroundColor;
    public Color BackgroundColor => backgroundColor;

    [SerializeField]
    private float transitionSpeed;
    public float TransitionSpeed => transitionSpeed; 

    public virtual void Init(GameModeController controller)
    {

    }

    public virtual void Deinit( GameModeController controller)
    {

    }
}
