namespace CustomDoublyLinkedList
{
    public class Node<@int>
    {
        public @int Value {  get; set; }
        public Node<@int> Next { get; set; }
        public Node<@int> Previous { get; set; }

        public Node(@int value)
        {
            Value = value;
        }
    }
}
