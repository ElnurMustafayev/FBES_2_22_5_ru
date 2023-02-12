#include <iostream>
#include <vector>

using namespace std;

template<typename T>
struct ListNode {
	ListNode<T>* next = nullptr;
	T value;

	ListNode(T value) : value(value) {}
	ListNode(T value, ListNode<T>* next) : value(value), next(next) {}
};

template<typename T>
class LinkedList {
	ListNode<T>* head = nullptr;

public:
	LinkedList() {}

	void Add(T newItem) {
		if (this->head == nullptr) {
			this->head = new ListNode<T>(newItem);
		}

		else {
			ListNode<T>* current = this->head;

			while (current->next != nullptr) {
				current = current->next;
			}

			current->next = new ListNode<T>(newItem);
		}
	}

	void Show() {
		ListNode<T>* current = this->head;

		for (int i = 1; current != nullptr; i++)
		{
			cout << i << ". " << current->value << endl;
			current = current->next;
		}
	}

	friend ostream& operator<<(ostream& out, const LinkedList<T> list);
};

ostream& operator<<(ostream& out, const LinkedList<int> list) {
	ListNode<int>* current = list.head;

	for (int i = 1; current != nullptr; i++)
	{
		out << i << ". " << current->value << endl;
		current = current->next;
	}

	return out;
}

int main()
{
	LinkedList<int> list = LinkedList<int>();
	list.Add(11);
	list.Add(33);
	list.Add(22);
	list.Add(44);
	list.Add(55);

	list.Show();
	//cout << list << endl;
}