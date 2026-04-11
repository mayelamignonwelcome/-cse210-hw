public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonus;
    private int _timesCompleted;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int timesCompleted = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _targetCount)
            return GetPoints() + _bonus;
        return GetPoints();
    }

    public override string GetStatus()
    {
        string mark = _timesCompleted >= _targetCount ? "[X]" : "[ ]";
        return $"{mark} {GetName()} Completed {_timesCompleted}/{_targetCount} times";
    }

    public override string SaveString()
    {
        return $"Checklist|{GetName()}|{GetDescription()}|{GetPoints()}|{_targetCount}|{_bonus}|{_timesCompleted}";
    }
}
