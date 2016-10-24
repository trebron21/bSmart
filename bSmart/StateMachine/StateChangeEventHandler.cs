namespace BSmart.StateMachine
{
  using System;

  /**
   * Notifying the UI and other observers about gamestate updates
   */
  public class GameStateChangeEventArgs : EventArgs
    {
      public GameStateChangeEventArgs(GameStates newState)
      {
        this.CurrentState = newState;
      }

      public GameStates CurrentState { get; private set; }
    }

    public class StateChangeEventPublisher
    {
      public delegate void StateChangeEventHandler(object sender, GameStateChangeEventArgs e);

      public event StateChangeEventHandler StateChanged;

      public virtual void RaiseStateChangeEvent(GameStates newState)
      {
        GameStateChangeEventArgs stateChangeEventArgs = new GameStateChangeEventArgs(newState);

        StateChanged?.Invoke(this, stateChangeEventArgs);
      }
    }
}
