namespace BSmart.StateMachine
{
  class GeneratingExercise : IGameState
  {
    GameStateMachine gameStateMachine;

    public GeneratingExercise(GameStateMachine gsm)
    {
      gameStateMachine = gsm;
    }

    public GameStates InternalState
    {
      get { return GameStates.EVALUATING_SOLUTION; }
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
    {
      gameStateMachine.SetNewGameState(gameStateMachine.WaitingForSolution);
    }

    public void EvaluateSolution()
    { /* empty */ }
  }
}
