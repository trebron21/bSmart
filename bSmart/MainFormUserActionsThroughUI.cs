namespace BSmart
{
  using System;
  using System.Windows.Forms;
  using System.Drawing;
  using System.Linq;
  using BSmart.QuizMaster;

  public partial class MainForm : Form
  {
    private void Start_Click(object sender, EventArgs e)
    {
      tmrDisplay.Enabled = true;
      btnStart.Enabled = false;
      btnStop.Enabled = true;
      btnAverage.Enabled = false;
      btnReset.Enabled = false;
      lblDisplay.Text = "The clock is ticking...";
      this.ActiveControl = this.txtYourSolution;

      m_quizMaster.StartGame();
      WriteExercise();
      SubscribeForGameStateChanges(m_quizMaster);
    }

    private void Stop_Click(object sender, EventArgs e)
    {
      tmrDisplay.Enabled = false;
      InitUIAndGame();
      lblDisplay.Text = "Start a new game by clicking on \"Start\"!";

      m_quizMaster.StopGame();
      UnSubscribeFromGameStateChanges(m_quizMaster);
    }

    private void TxtYourSolution_KeyDown(object sender, KeyEventArgs e)
    {
      if (!tmrDisplay.Enabled)
        return;

      if (e.KeyCode != Keys.Enter)
        return;

      if (txtYourSolution.Text == "")
      {
        pnlSuccessColor.BackColor = Color.FromName("red");
        lblPreviousSolution.Text = m_quizMaster.CurrentExercise.GetSmartSolutionAsString();

        m_quizMaster.IHaveNoClueSpinItPlease();
        lblSpun.Text = m_quizMaster.GiveMeTheNumOfSpunAnswersStr();
      }

      try
      {
        bool success = m_quizMaster.CheckMySolutionPlease(double.Parse(txtYourSolution.Text));

        if (success)
        {
          lblCorrect.Text = m_quizMaster.GiveMeTheNumOfCorrectAnswersStr();
          pnlSuccessColor.BackColor = Color.FromName("green");
        }
        else
        {
          pnlSuccessColor.BackColor = Color.FromName("red");
          lblIncorrect.Text = m_quizMaster.GiveMeTheNumOfIncorrectAnswersStr();
        }

        txtYourSolution.Text = "";
        lblPreviousSolution.Text = m_quizMaster.CurrentExercise.GetSmartSolutionAsString();
      }
      catch (Exception /*ex*/)
      {
        pnlSuccessColor.BackColor = Color.FromName("red");
        lblPreviousSolution.Text = m_quizMaster.CurrentExercise.GetSmartSolutionAsString();

        m_quizMaster.IHaveNoClueSpinItPlease();
        lblSpun.Text = m_quizMaster.GiveMeTheNumOfSpunAnswersStr();
      }

      WriteExercise();
    }

    /**
     * Calculates and shows the averages of the games played
     */
    private void BtnAverage_Click(object sender, EventArgs e)
    {
      if (m_quizMaster.GiveMeTheNumOfGamesPlayed() == 0)
      {
        memoTraceView.AppendText("After " + m_quizMaster.GiveMeTheNumOfGamesPlayedStr() + " game(s):\n");
        memoTraceView.AppendText("Avg - Right: 0\n");
        memoTraceView.AppendText("Avg - Wrong: 0\n");
        memoTraceView.AppendText("Avg - Disposed: 0\n");
        memoTraceView.AppendText("------------------------------------------\n");
        this.ActiveControl = this.btnStart;

        return;
      }

      // Average of good, bad and spun answers
      memoTraceView.AppendText("After " + m_quizMaster.GiveMeTheNumOfGamesPlayedStr() + " game(s):\n");
      double correctAverage = Math.Round(
        (m_quizMaster.OverallSumOfCorrectAnswers() / m_quizMaster.GiveMeTheNumOfGamesPlayed()),
        2,
        MidpointRounding.AwayFromZero);

      double incorrectAverage = Math.Round(
        (m_quizMaster.OverallSumOfIncorrectAnswers() / m_quizMaster.GiveMeTheNumOfGamesPlayed()),
        2,
        MidpointRounding.AwayFromZero);

      double spunAverage = Math.Round(
        (m_quizMaster.OverallSumOfSpunAnswers() / m_quizMaster.GiveMeTheNumOfGamesPlayed()),
        2,
        MidpointRounding.AwayFromZero);

      // Sum of all types of answers, and the sums separated by types
      double sumOfAnswers = correctAverage + incorrectAverage + spunAverage;

      double sumOfCorrect = Math.Round(correctAverage * m_quizMaster.GiveMeTheNumOfGamesPlayed(),
                                       MidpointRounding.AwayFromZero);

      double sumOfIncorrect = Math.Round(incorrectAverage * m_quizMaster.GiveMeTheNumOfGamesPlayed(),
                                         MidpointRounding.AwayFromZero);

      double sumOfSpun = Math.Round(spunAverage * m_quizMaster.GiveMeTheNumOfGamesPlayed(),
                                    MidpointRounding.AwayFromZero);

      // Percentage of each type
      double correctPercentage = Math.Round(correctAverage / sumOfAnswers * 100, 2, MidpointRounding.AwayFromZero);
      double incorrectPercentage = Math.Round(incorrectAverage / sumOfAnswers * 100, 2, MidpointRounding.AwayFromZero);
      double spunPercentage = Math.Round(spunAverage / sumOfAnswers * 100, 2, MidpointRounding.AwayFromZero);

      memoTraceView.AppendText("Avg - Right: " + correctAverage.ToString() + " / " +
                               sumOfCorrect + " / " + correctPercentage + '%' + '\n');

      memoTraceView.AppendText("Avg - Wrong: " + incorrectAverage.ToString() + " / " +
                               sumOfIncorrect + " / " + incorrectPercentage + '%' + '\n');

      memoTraceView.AppendText("Avg - Disposed: " + spunAverage.ToString() + " / " +
                               sumOfSpun + " / " + spunPercentage + '%' + '\n');

      memoTraceView.AppendText("------------------------------------------\n");

      this.ActiveControl = this.btnStart;
    }

    private void BtnReset_Click(object sender, EventArgs e)
    {
      m_quizMaster.ResetMyEntireGamePlease();
      memoTraceView.AppendText("The game has been reset.\n");
      memoTraceView.AppendText("------------------------------------------\n");
    }

    private void ComboDuration_SelectedIndexChanged(object sender, EventArgs e)
    {
      int idx = comboDuration.SelectedIndex;

      lblDuration.Text = QuizTimer.S_PossibleGameDurations.ElementAt(idx).ToString();
      progressBarTime.Value = progressBarTime.Maximum = QuizTimer.S_PossibleGameDurations.ElementAt(idx);

      m_quizMaster.GameDurationInSeconds = QuizTimer.S_PossibleGameDurations.ElementAt(idx);
    }
  }
}