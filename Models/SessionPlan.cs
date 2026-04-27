namespace TesseracsTemplate.Models;

public sealed record SessionTask(string Title, string Status, string Owner);

public sealed record SessionPlan(string Name, string Goal, IReadOnlyList<SessionTask> Tasks)
{
    public static SessionPlan Sample() =>
        new(
            "Tesseracs template refresh",
            "Provide a practical C# starting point",
            new[]
            {
                new SessionTask("Add reusable classes", "done", "template"),
                new SessionTask("Improve run instructions", "done", "docs"),
                new SessionTask("Replace sample data", "next", "you"),
            }
        );
}
