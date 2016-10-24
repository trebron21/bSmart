namespace BSmart.Exercises
{
  using System;

  class Addition : Exercise
  {
    public Addition()
    {
      OperatorAsString = "+";
      InitAddition();
    }

    private void InitAddition()
    {
      Random random = new Random();
      m_leftOperand = 20 + random.Next(80);
      m_rightOperand = 20 + random.Next(80);
      m_smartSolution = m_leftOperand + m_rightOperand;
    }
  }
}
