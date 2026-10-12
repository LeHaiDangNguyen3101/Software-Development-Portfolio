using System.Collections.Generic;

public class ScoreComparer : IComparer<ScoreEntry>
{
    public int Compare(ScoreEntry? x, ScoreEntry? y)
    {
        if (x == null && y == null)
            return 0;

        if (x == null)
            return -1;

        if (y == null)
            return 1;

        // First compare by Score
        int scoreComparison = x.Score.CompareTo(y.Score);

        if (scoreComparison != 0)
            return scoreComparison;

        // If scores are the same, compare by StageReached
        return x.StageReached.CompareTo(y.StageReached);
    }
}