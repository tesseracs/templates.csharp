using System.Text;
using TesseracsTemplate.Models;

namespace TesseracsTemplate.Services;

public static class PlanFormatter
{
    public static string Render(SessionPlan plan)
    {
        var completed = plan.Tasks.Count(task => task.Status == "done");
        var builder = new StringBuilder();

        builder.AppendLine($"Project: {plan.Name}");
        builder.AppendLine($"Goal: {plan.Goal}");
        builder.AppendLine($"Progress: {completed}/{plan.Tasks.Count} tasks completed");
        builder.AppendLine("Open work:");

        foreach (var task in plan.Tasks.Where(task => task.Status != "done"))
        {
            builder.AppendLine($"- {task.Title} ({task.Owner})");
        }

        return builder.ToString().TrimEnd();
    }
}
