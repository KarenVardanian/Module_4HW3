using Module4Hw3.Entities;
using System;
using System.Collections.Generic;

public class Project
{
	public int Id { get; set; }
	public string Name { get; set; }
	public double Budget { get; set; }
	public DateTime StartedDate { get; set; }
	public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
	//public List<Employee> Projects { get; set; } = new List<Employee>();
}
