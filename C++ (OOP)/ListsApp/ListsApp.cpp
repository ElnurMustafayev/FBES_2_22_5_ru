#include <iostream>
#include <vector>
#include <list>

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
	ListNode<T>* tail = nullptr;
	int size = 0;

public:
	LinkedList() {}

	void Add(int index, T newItem) {
		if (index < 0 || index > this->size) {
			throw "Incorrect index";
		}

		if (index == 0) {
			//cout << "IF" << newItem << endl;
			if (this->head == nullptr) {
				this->head = new ListNode<T>(newItem);
				this->tail = this->head;
			}
			else {
				ListNode<T>* newNode = new ListNode<T>(newItem);
				newNode->next = head;
				head = newNode;
			}
			this->size++;
		}
		else if (index == this->size) {
			//cout << "ELIF" << newItem << endl;
			ListNode<T>* newNode = new ListNode<T>(newItem);
			this->tail->next = newNode;
			this->tail = newNode;
			this->size++;
		}
		else {
			ListNode<T>* current = this->head;

			for (int i = 0; i < index - 2; i++) {
				//cout << "ELSE" << newItem << endl;
				current = current->next;
			}

			ListNode<T>* newNode = new ListNode<T>(newItem);
			newNode->next = current->next;
			current->next = newNode;
			this->size++;
		}
	}

	void Remove(int index) {
		if (this->size == 0) {
			return;
		}

		if (index < 0 || index > this->size) {
			throw "Incorrect index";
		}

		if (index == 0) {
			if (this->size == 1) {
				delete head;
				this->head = nullptr;
				this->tail = nullptr;
			}
			else {
				ListNode<T>* temp = this->head;
				this->head = this->head->next;
				delete temp;
			}
			this->size--;
		}
		else if (index == this->size - 1) {
			ListNode<T>* cursor = this->head;

			for (int i = 0; i < index - 1; i++)
				cursor = cursor->next;

			delete tail;
			this->tail = cursor;
			this->tail->next = nullptr;
			this->size--;
		}
		else {
			ListNode<T>* cursor = this->head;

			for (int i = 0; i < index - 1; i++)
				cursor = cursor->next;

			ListNode<T>* toDelete = cursor->next;
			cursor->next = cursor->next->next;
			delete toDelete;
			this->size--;
		}
	}

	void Show() {
		ListNode<T>* current = this->head;

		for (int i = 0; current != nullptr; i++)
		{
			cout << i << ". " << current->value << endl;
			current = current->next;
		}

		cout << "\n\n";
	}

	T operator[] (int index) {
		ListNode<T>* current = this->head;

		for (int i = 0; i < index; i++)
			current = current->next;

		return current->value;
	}

	T operator()(int index) {
		ListNode<T>* current = this->head;

		for (int i = 0; i < index; i++)
			current = current->next;

		return current->value;
	}
};



int main()
{
	list<int> nums = list<int>();
	nums.push_back(11);
	nums.push_back(22);
	nums.push_back(33);
	nums.push_back(44);
	nums.push_back(55);

	for (auto item : nums)
		cout << item << endl;
	nums.reverse();
	for (auto item : nums)
		cout << item << endl;



	//try {
	//	LinkedList<int> list = LinkedList<int>();
	//	list.Add(0, 44);
	//	list.Add(0, 33);
	//	list.Add(0, 22);
	//	list.Add(0, 11);

	//	//list.Remove(2);
	//	//list.Remove(2);
	//	//list.Remove(0);

	//	cout << list(1) << endl;
	//	cout << list[10] << endl;
	//	//list.Show();
	//}
	//catch (const char* msg) {
	//	cout << msg << endl;
	//}
}