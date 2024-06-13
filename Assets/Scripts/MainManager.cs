using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public Color TeamColor;
    private void Awake()
    {
        //singleton pattern
        if (Instance != null)
        {
            Destroy(Instance);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
