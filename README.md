# Tesseracs - C# Template

A practical .NET console starter for [Tesseracs](https://github.com/tesseracs) chat sessions.

Clone URL: `https://github.com/tesseracs/templates.csharp`

## What this template shows

- A small domain model plus a formatter service.
- Top-level statements kept thin in `Program.cs`.
- A single-project setup that stays easy to run with the .NET SDK.

## Layout

- `Program.cs` - entry point.
- `Models/SessionPlan.cs` - sample data model.
- `Services/PlanFormatter.cs` - output formatting logic.
- `run.sh` - restores and runs the project.

## Run

```sh
./run.sh
```

Or directly:

```sh
dotnet run --project tesseracs-template.csproj
```

## Suggested next edits

- Replace the sample tasks with real work items or config.
- Add more services as the app starts reading files or calling APIs.
- Introduce tests when formatting or business rules grow.
