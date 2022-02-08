using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPanttern<T> : MonoBehaviour where T : SingletonPanttern<T>
{
    public static T Instance;
    private void Awake()
    {
        Instance = (T)this;
    }
}
