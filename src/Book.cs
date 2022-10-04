



public Book(string name) 
{
  grades = new List<double>();
  Name = name; 
}


public void AddGrade(double grade) 
{
  if(grade <= 100 && grade >= 0) 
  {
    grades.Add(grade);
  }
  else
  {
    Console.WriteLine("Invalid value");
  }
}


public Statistics GetStatistics() 
{
  var result = new Statistics(); 
  result.Average = 0.0; 
  result.High = double.MinValue;
  result.Low = double.MaxValue; 

//for loop  while loop 
  // var index = 0;
  for(var index = 0; index < grades.Count; index++) 
  // while (index < grades.Count); 
  {
    result.Low = Math.Min(grades[index], result.Low); 
    result.High = Math.Max(grades[index], result.High); 
    result.Average += grades[index];
    index++; 
  };
    result.Average /= grades.Count;
    
    return result; 
}

private List<double> grades;