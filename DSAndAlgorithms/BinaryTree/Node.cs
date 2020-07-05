namespace DSAndAlgorithms
{
    public class Node<T>
    {
       public T value { get; }
        Node<T> _leftNode;
        Node<T> _rightNode;
        public Node(T nodeValue)
        {
            value = nodeValue;
            
        }
        public void AddChildren(Node<T> leftNode,Node<T> rightNode)
        {
            _leftNode = leftNode;
            _rightNode = rightNode;
        }
        public Node<T> GetLeft()
        {
            return _leftNode;
        }
        public Node<T> GetRight()
        {
            return _rightNode;
        }
    }
}