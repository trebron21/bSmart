namespace BSmart.Exercises
{
  using System;

  class Multiplication : Exercise
  {
    public Multiplication()
    {
      OperatorAsString = "*";
      InitMultiplication();
    }

    private void InitMultiplication()
    {
      Random random = new Random();
      m_leftOperand = 2 + random.Next(18);
      m_rightOperand = 2 + random.Next(18);
      m_smartSolution = m_leftOperand * m_rightOperand;
    }
  }
}
