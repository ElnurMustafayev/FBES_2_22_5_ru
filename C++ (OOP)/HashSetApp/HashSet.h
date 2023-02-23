#pragma once

#include <iostream>
#include <vector>

using namespace std;


class HashSet {
	vector<vector<int>> table;

	int Hash(int num) {
		return num % 10;
	}

public:
	HashSet() {
		this->table = vector<vector<int>>(10);

		for (int i = 0; i < this->table.size(); i++) {
			this->table[i] = vector<int>();
		}
	}

	void Add(int newEl) {
		int hash = this->Hash(newEl);
		this->table[hash].push_back(newEl);
	}

	void Show() {
		for (int i = 0; i < this->table.size(); i++) {
			cout << i << ": ";
			vector<int> currentTableRow = this->table[i];

			for (int i = 0; i < currentTableRow.size(); i++) {
				cout << currentTableRow[i] << " ";
			}

			cout << endl;
		}
	}
};