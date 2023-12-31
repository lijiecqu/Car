using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public InputController inputController { get; private set; }

    private void Awake()
    {
        Instance = this;
        inputController = GetComponentInChildren<InputController>();
    }
}
