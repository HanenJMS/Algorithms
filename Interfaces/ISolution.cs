namespace Algorithms.Interfaces
{
    internal interface ISolution
    {
        void ToggleMemo(bool IsMemo);
        object Run(object num);
        string TimeComplexity();
        string SpaceComplexity();
        string Instructions();
    }
}
