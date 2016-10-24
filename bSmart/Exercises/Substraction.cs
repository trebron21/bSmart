namespace BSmart.Exercises
{
  using System;

  class Substraction : Exercise
  {
    public Substraction()
    {
      OperatorAsString = "-";
      InitSubstraction();
    }

    private void InitSubstraction()
    {
      Random random = new Random();
      m_leftOperand = 20 + random.Next(80);
      m_rightOperand = 20 + random.Next(80);
      m_smartSolution = m_leftOperand - m_rightOperand;
    }
  }
}
