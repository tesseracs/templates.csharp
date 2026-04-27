using TesseracsTemplate.Models;
using TesseracsTemplate.Services;

var plan = SessionPlan.Sample();
Console.WriteLine(PlanFormatter.Render(plan));
