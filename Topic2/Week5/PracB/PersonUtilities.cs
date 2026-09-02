public static class PersonUtilities
{
    public static LinkedList<Person> ToLinkedList(List<Person> people)
    {
        LinkedList<Person> linkedPeople = new LinkedList<Person>();

        foreach (Person person in people)
        {
            linkedPeople.AddLast(person);
        }

        return linkedPeople;
    }

    public static string PrintPeople(LinkedList<Person> people)
    {
        string result = "";

        foreach (Person person in people)
        {
            result += $"{person.FullName} - Age: {person.Age}\n";
        }

        return result;
    }
        public static LinkedList<Person> SortPeople(LinkedList<Person> people)
    {
        LinkedList<Person> sortedPeople = new LinkedList<Person>();

        while (people.Count > 0)
        {
            LinkedListNode<Person>? youngestNode = people.First;

            LinkedListNode<Person>? current = people.First;

            while (current != null)
            {
                if (youngestNode != null &&
                    current.Value.Age < youngestNode.Value.Age)
                {
                    youngestNode = current;
                }

                current = current.Next;
            }

            if (youngestNode != null)
            {
                sortedPeople.AddLast(youngestNode.Value);
                people.Remove(youngestNode);
            }
        }

        return sortedPeople;
    }
}
