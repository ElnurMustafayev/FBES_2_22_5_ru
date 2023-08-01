using IteratorApp.Iterators;
using System.Collections;

namespace IteratorApp;

public class House : IEnumerable<Person> {
    private List<Person> People = new List<Person>();
    private IEnumerator<Person> PeopleEnumerator;

    public House() {
        this.PeopleEnumerator = new PeopleEnumerator(People);
    }

    public House(IEnumerator<Person> iterator) {
        this.PeopleEnumerator = iterator;
    }

    public void Add(Person person) {
        this.People.Add(person);
    }

    public IEnumerator<Person> GetEnumerator() => PeopleEnumerator;

    IEnumerator IEnumerable.GetEnumerator() => PeopleEnumerator;
}