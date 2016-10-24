namespace BSmart.StateMachine
{
  class GameIsNotRunning : IGameState
  {
    GameStateMachine gameStateMachine;

    public GameIsNotRunning(GameStateMachine gsm)
    {
      gameStateMachine = gsm;
    }

    public GameStates InternalState
    {
      get { return GameStates.STOPPED; }
      set { /* empty */ }
    }

    public void StartGame()
    {
      gameStateMachine.SetNewGameState(gameStateMachine.GameIsRunning);
    }

    public void StopGame()
    { /* empty */ }

    public void GenerateExercise()
    { /* empty */ }

    public void WaitForSolution()
    { /* empty */ }

    public void EvaluateSolution()
    { /* empty */ }
  }
}
