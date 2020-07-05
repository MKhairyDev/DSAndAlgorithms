namespace DSAndAlgorithms
{
    public class Pixel
    {
        int _x;
        int _y;
        string _originalColor;
        public Pixel(int x,int y,string originalColor)
        {
            _x = x;
            _y = y;
            _originalColor = originalColor;
        }
        public void SetColor(string newColor)
        {
            _originalColor = newColor;
        }
        public string getColor()
        {
            return _originalColor;
        }
    }
}