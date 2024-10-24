﻿namespace Versionize.ConventionalCommits;

public sealed class ConventionalCommit
{
    public string? Sha { get; init; }

    public string? Scope { get; set; }

    public string? Type { get; set; }

    public string? Subject { get; set; }

    public List<ConventionalCommitNote> Notes { get; set; } = [];

    public List<ConventionalCommitIssue> Issues { get; set; } = [];

    public bool IsFeature => Type == "feat";
    public bool IsFix => Type == "fix";
    public bool IsBreakingChange => Notes.Any(note => "BREAKING CHANGE".Equals(note.Title));
}

public class ConventionalCommitNote
{
    public string? Title { get; init; }

    public string? Text { get; init; }
}

public class ConventionalCommitIssue
{
    public string? Token { get; init; }

    public string? Id { get; init; }
}
