namespace BSmart.StateMachine
{
  using System;
  using System.Diagnostics;

  public class GameStateMachine
  {
    /**
     * Internal gamestates
     */
    IGameState m_gameIsRunning;
    IGameState m_gameIsNotRunning;
    IGameState m_generatingExercise;
    IGameState m_waitingForSolution;
    IGameState m_evaluatingSolution;

    /**
     * It holds the current gamestate
     */
    public IGameState GameState;

    private StateChangeEventPublisher m_stateChangeEventPublisher = new StateChangeEventPublisher();

    public GameStateMachine()
    {
      m_gameIsNotRunning = new StateMachine.GameIsNotRunning(this);
      m_gameIsRunning = new StateMachine.GameIsRunning(this);
      m_generatingExercise = new StateMachine.GeneratingExercise(this);
      m_waitingForSolution = new StateMachine.WaitingForSolution(this);
      m_evaluatingSolution = new StateMachine.EvaluatingSolution(this);

      GameState = GameIsNotRunning;
    }

    /**
     * Getters / public fields
     */
    public IGameState GameIsRunning
    {
      get { return m_gameIsRunning; }
      private set { /* empty */ }
    }

    public IGameState GameIsNotRunning
    {
      get { return m_gameIsNotRunning; }
      private set { /* empty */ }
    }

    public IGameState GeneratingExercise
    {
      get { return m_generatingExercise; }
      private set { /* empty */ }
    }

    public IGameState WaitingForSolution
    {
      get { return m_waitingForSolution; }
      private set { /* empty */ }
    }

    public IGameState EvaluatingSolution
    {
      get { return m_evaluatingSolution; }
      private set { /* empty */ }
    }

    public StateChangeEventPublisher StateChangeEventPublisher
    {
      get { return m_stateChangeEventPublisher; }
      private set { /* empty */ }
    }

    public virtual void StartGame()
    {
      Trace.WriteLine(DateTime.UtcNow.ToString() + ": GameStateMachine.StartGame was called.");
      GameState.StartGame();
    }

    public virtual void StopGame()
    {
      Trace.WriteLine(DateTime.UtcNow.ToString() + ": GameStateMachine.StopGame was called.");
      GameState.StopGame();
    }

    public virtual void GenerateExercise()
    {
      Trace.WriteLine(DateTime.UtcNow.ToString() + ": GameStateMachine.GenerateExercise was called.");
      GameState.GenerateExercise();
    }

    public virtual void WaitForSolution()
    {
      Trace.WriteLine(DateTime.UtcNow.ToString() + ": GameStateMachine.WaitForSolution was called.");
      GameState.WaitForSolution();
    }

    public virtual void EvaluateSolution()
    {
      Trace.WriteLine(DateTime.UtcNow.ToString() + ": GameStateMachine.EvaluateSolution was called.");
      GameState.EvaluateSolution();
    }

    public void SetNewGameState(IGameState newState)
    {
      GameState = newState;

      // Notifying the observers about the statechange
      m_stateChangeEventPublisher.RaiseStateChangeEvent(newState.InternalState);
    }
  }
}

