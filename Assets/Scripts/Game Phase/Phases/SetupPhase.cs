using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Setup the parameters of the game
/// 1. Number of players (to be determined whether setup in lobby or here) 
/// 2. Number of rounds
/// 3. Minimum bet for pot
/// </summary>

public class RoundData
{
    private int _numberOfRounds;
    private int _numberOfPlayers;
    private int _minAnte; //minimum bet for each player
    private int _pot;

    public int NumberOfRounds { get { return _numberOfRounds; } set { _numberOfRounds = value; }}
    public int NumberOfPlayers { get { return _numberOfPlayers; } set { _numberOfPlayers = value; }}
    public int MinAnte { get { return _minAnte; } set { _minAnte = value; }}
    public int PotSize { get { return _pot; } set { _pot = value; }}
}

public class SetupPhase : MonoBehaviour, IGamePhase
{


    public void OnBegin()
    {
        throw new System.NotImplementedException();
    }

    public void OnExit()
    {
        throw new System.NotImplementedException();
    }
}
