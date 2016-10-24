namespace BSmart.StateMachine
{
  class GameIsRunning : IGameState
  {
    GameStateMachine gameStateMachine;

    public GameIsRunning(GameStateMachine gsm)
    {
        gameStateMachine = gsm;
    }

    public GameStates InternalState
    {
      get { return GameStates.STARTED; }
      set { /* empty */ }
    }

    public void StartGame()
    { /* empty */ }

    public void StopGame()
    {
      gameStateMachine.SetNewGameState(gameStateMachine.GameIsNotRunning);
    }

    public void GenerateExercise()
    {
      gameStateMachine.SetNewGameState(gameStateMachine.GeneratingExercise);
    }

    public void WaitForSolution()
    { /* empty */ }

    public void EvaluateSolution()
    { /* empty */ }
  }
}
