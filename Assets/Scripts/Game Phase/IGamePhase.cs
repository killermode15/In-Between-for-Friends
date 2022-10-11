using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGamePhase 
{
    void OnBegin();
    void OnExit();
}
