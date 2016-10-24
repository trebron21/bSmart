namespace BSmart
{
  using System;
  using System.Diagnostics;
  using System.Drawing;
  using System.Linq;
  using System.Windows.Forms;
  using BSmart.QuizMaster;
    using System.Threading;
  using System.Threading.Tasks;

  public partial class MainForm : Form
  {
    private TheQuizMaster m_quizMaster = new TheQuizMaster();

    private readonly SynchronizationContext s_SynchronizationContext;

    public MainForm()
    {
      InitializeComponent();
      s_SynchronizationContext = SynchronizationContext.Current;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      comboDuration.DataSource = QuizTimer.S_PossibleGameDurations;
      comboDuration.SelectedItem = QuizTimer.S_PossibleGameDurations.ElementAt((int)GameDurations._60_);

      InitUIAndGame();

      Trace.Listeners.Add(new TextWriterTraceListener(System.IO.File.CreateText("Traces.txt")));
      Trace.AutoFlush = true;
    }

    public void InitUIAndGame()
    {
      m_quizMaster.ResetMyCurrentRunPlease();

      ThreadSafe(lblDisplay, "Text", "Let's have some fun!");
      ThreadSafe(lblCorrect, "Text", "0");
      ThreadSafe(lblExercise, "Text", "");
      ThreadSafe(lblPreviousSolution, "Text", "");
      ThreadSafe(btnStart, "Enabled", true);
      ThreadSafe(btnStop, "Enabled", false);
      ThreadSafe(btnAverage, "Enabled", true);
      ThreadSafe(btnReset, "Enabled", true);
      ThreadSafe(pnlSuccessColor, "BackColor", Color.FromName("silver"));
      ThreadSafe(lblIncorrect, "Text", "0");
      ThreadSafe(lblSpun, "Text", "0");
      ThreadSafe(lblPreviousSolution, "Text", "0");
      // It doesn't have to be set always, it is enough to modify it on comboelement changes
      //ThreadSafe(progressBarTime, "Maximum", comboDuration.SelectedValue);
      ThreadSafe(progressBarTime, "Value", comboDuration.SelectedValue);
      ThreadSafe(lblDuration, "Text", comboDuration.SelectedValue.ToString());
      ThreadSafe(this, "ActiveControl", this.btnStart);
    }

    public void WriteExercise()
    {
      lblExercise.Text = m_quizMaster.GiveMeAnExercisePlease();
      txtYourSolution.Text = "";
    }

    private void TmrDisplay_Tick(object sender, EventArgs e)
    {
      if (progressBarTime.Value > 0) progressBarTime.Value = progressBarTime.Value - 1;
      lblDuration.Text = (progressBarTime.Value - 1).ToString();
    }

    private void GameOver()
    {
      tmrDisplay.Stop();

      int sumOfAnswers = m_quizMaster.GiveMeTheNumOfCorrectAnswers() +
                         m_quizMaster.GiveMeTheNumOfIncorrectAnswers() +
                         m_quizMaster.GiveMeTheNumOfSpunAnswers();
      double correctPercentage = 0;
      double incorrectPercentage = 0;
      double spunPercentage = 0;

      // Percentages of this round
      if (sumOfAnswers != 0)
      {
        correctPercentage = Math.Round(
          (double)m_quizMaster.GiveMeTheNumOfCorrectAnswers() / sumOfAnswers * 100, 2, MidpointRounding.AwayFromZero);
        incorrectPercentage = Math.Round(
          (double)m_quizMaster.GiveMeTheNumOfIncorrectAnswers() / sumOfAnswers * 100, 2, MidpointRounding.AwayFromZero);
        spunPercentage = Math.Round(
          (double)m_quizMaster.GiveMeTheNumOfSpunAnswers() / sumOfAnswers * 100, 2, MidpointRounding.AwayFromZero);
      }

      MessageBox.Show("Congratulations!" + '\n' + "# of right answers: " +
        m_quizMaster.GiveMeTheNumOfCorrectAnswers() + " / " + correctPercentage + '%' + Environment.NewLine +
        "# of wrong answers: " + m_quizMaster.GiveMeTheNumOfIncorrectAnswers() + " / " +
        incorrectPercentage + '%' + Environment.NewLine +
        "# of disposed answers: " + m_quizMaster.GiveMeTheNumOfSpunAnswers() + " / " + spunPercentage + '%');

      memoTraceView.Invoke((MethodInvoker) delegate
      {
        memoTraceView.AppendText("Results of the " +
          m_quizMaster.GiveMeTheNumOfGamesPlayed() + ". game:" + Environment.NewLine);
        memoTraceView.AppendText("# of right answers: " +
          m_quizMaster.GiveMeTheNumOfCorrectAnswers() + " / " + correctPercentage + '%' + Environment.NewLine);
        memoTraceView.AppendText("# of wrong answers: " +
          m_quizMaster.GiveMeTheNumOfIncorrectAnswers() + " / " + incorrectPercentage + '%' + Environment.NewLine);
        memoTraceView.AppendText("# of disposed exercises: " +
          m_quizMaster.GiveMeTheNumOfSpunAnswers() + " / " + spunPercentage + '%' + Environment.NewLine);
        memoTraceView.AppendText("------------------------------------------" + Environment.NewLine);
        InitUIAndGame();
      });

      UnSubscribeFromGameStateChanges(m_quizMaster);
    }

    public /*static*/ void ThreadSafe<T>(Control control, string propName, T value)
    {
      //s_SynchronizationContext.Post(new SendOrPostCallback(o =>
      //{
      //  control.GetType().GetProperty(propName).SetValue(control, o);
      //}), value);

     control.Invoke((MethodInvoker)delegate
     {
       control.GetType().GetProperty(propName).SetValue(control, value);
     });
    }
  }
}
