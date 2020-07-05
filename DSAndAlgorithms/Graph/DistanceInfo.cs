namespace DSAndAlgorithms.Graph
{
    public class DistanceInfo
    {
        int _distance=-1;
        int _lastVertex=-1;

        public void SetDisance(int distance)
        {
            _distance = distance;
        }
        public int GetDistance()
        {
            return _distance;
        }
        public void SetLastVertex(int lastVertex)
        {
            _lastVertex = lastVertex;
        }
        public int GetLastVertex()
        {
            return _lastVertex;
        }
    }
}