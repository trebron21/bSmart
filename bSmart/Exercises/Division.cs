namespace BSmart.Exercises
{
  using System;

  class Division : Exercise
  {
    public Division()
    {
      OperatorAsString = "/";
      InitDivision();
    }

    private void InitDivision()
    {
      double fractional = 1;
      m_smartSolution = 12.12;

      while (fractional != 0)
      {
        Random random = new Random();
        Random rand = new Random();
        m_rightOperand = random.Next(2, 10);
        m_leftOperand = rand.Next(m_rightOperand, 100);
        m_smartSolution = (double)m_leftOperand / (double)m_rightOperand;

        fractional = m_smartSolution - Math.Truncate(m_smartSolution);
      }
    }
  }
}
