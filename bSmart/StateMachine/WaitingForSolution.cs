namespace BSmart.StateMachine
{
  class WaitingForSolution : IGameState
  {
    GameStateMachine gameStateMachine;

    public WaitingForSolution(GameStateMachine gsm)
    {
      gameStateMachine = gsm;
    }

    public GameStates InternalState
    {
      get { return GameStates.WAITING_FOR_SOLUTION; }
      set { /* empty */ }
    }

    public void StartGame()
    { /* empty */ }

    public void StopGame()
    {
      gameStateMachine.SetNewGameState(gameStateMachine.GameIsNotRunning);
    }

    public void GenerateExercise()
    { /* empty */ }

    public void WaitForSolution()
    { /* empty */ }

    public void EvaluateSolution()
    {
      gameStateMachine.SetNewGameState(gameStateMachine.EvaluatingSolution);
    }
  }
}
