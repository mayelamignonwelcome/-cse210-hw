public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override string GetStatus()
    {
        return _isComplete ? $"[X] {GetName()}" : $"[ ] {GetName()}";
    }

    public override string SaveString()
    {
        return $"Simple|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}
