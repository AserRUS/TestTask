using ButchersGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum GameState
{
    Preparation,    
    Game,
    Finish
}
public class GameController : MonoBehaviour
{
    #region Singletone
    private static GameController _default;
    public static GameController Default { get => _default; }
    public GameController() => _default = this;
    #endregion

    public event UnityAction Finished;
    public event UnityAction Started;

    [SerializeField] private GameObject finishPanel;
    [SerializeField] private GameObject preparationPanel;

    private GameState _gameState = GameState.Preparation;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        if (_gameState != GameState.Preparation) return;
        _gameState = GameState.Game;
        Started?.Invoke();
        preparationPanel.SetActive(false);
    }

    public void Finish()
    {
        if (_gameState != GameState.Game) return;
        _gameState = GameState.Finish;
        finishPanel.SetActive(true);
        Finished?.Invoke();
    }

    public void PreparationGame()
    {
        if (_gameState != GameState.Finish) return;
        _gameState = GameState.Preparation;
        finishPanel.SetActive(false);
        preparationPanel.SetActive(true);
    }
}
