namespace BSmart.Exercises
{
  using System;

  public class Exercise
  {
    protected Int32 m_leftOperand = 0;
    protected Int32 m_rightOperand = 0;
    protected Double m_smartSolution = 12121212.12121212;

    public String OperatorAsString = "";

    public String GetLeftOperandAsString()
    {
      return m_leftOperand.ToString();
    }

    public String GetRightOperandAsString()
    {
      return m_rightOperand.ToString();
    }

    public String GetSmartSolutionAsString()
    {
      return m_smartSolution.ToString();
    }

    public double GetSmartSolution()
    {
      return m_smartSolution;
    }
  }
}
