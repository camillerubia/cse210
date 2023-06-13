using System;

// the parent class showing the "virtual" keyword included
public class Employee
{
  private float salary = 100f;

  public virtual float CalculatePay()
  {
    return salary;
  }
}