#pragma once

struct Page {
	int index;
	long long textLength;

	Page(int index, long long textLength) :
		index(index),
		textLength(textLength) {}
};

class Book {
public:
	string name;
	vector<Page> pages = vector<Page>();

	void Show() {
		cout << "Name: " << this->name << endl;

		for (auto page : this->pages) {
			cout << page.index << ": " << page.textLength << endl;
		}
	}
};