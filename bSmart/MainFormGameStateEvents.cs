namespace BSmart
{
  using System.Windows.Forms;
  using BSmart.QuizMaster;
  using BSmart.StateMachine;

  public partial class MainForm : Form
  {
    void SubscribeForGameStateChanges(TheQuizMaster qm)
    {
      qm.StateChangeEventPublisher.StateChanged += ReceivedStateChangeEvent;
    }

    public void UnSubscribeFromGameStateChanges(TheQuizMaster qm)
    {
      qm.StateChangeEventPublisher.StateChanged -= ReceivedStateChangeEvent;
    }

    public void ReceivedStateChangeEvent(object sender, GameStateChangeEventArgs e)
    {
      if (e.CurrentState == GameStates.STOPPED)
        GameOver();
    }
  }
}
