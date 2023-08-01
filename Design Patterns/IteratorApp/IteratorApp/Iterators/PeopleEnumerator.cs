using System.Collections;

namespace IteratorApp.Iterators;

public class PeopleEnumerator : IEnumerator<Person> {
    private readonly IEnumerable<Person> people;
    private int counter = -1;

    public Person Current => people.ElementAt(counter);

    object IEnumerator.Current => people.ElementAt(counter);

    public PeopleEnumerator(IEnumerable<Person> people) {
        this.people = people;
    }

    public void Dispose() {
        this.Reset();
    }

    public bool MoveNext() {
        if (++counter < this.people.Count())
            return true;

        this.Reset();
        return false;
    }

    public void Reset() {
        counter = -1;
    }
}