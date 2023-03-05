#pragma once

#include<iostream>
using namespace std;

class Task {
public:
	string Title;
	string Description;

	string CreatorName;
	
	Task(string creatorName) : CreatorName(creatorName) {}

	/*
	static Task CreateTask(string creatorName) {
		Task newTask = Task(creatorName);

		cout << "Title: ", cin >> newTask.Title;
		cout << "Description: ", cin >> newTask.Description;

		return newTask;
	}
	*/

	virtual void InitTask() {
		cout << "Title: ", cin >> this->Title;
		cout << "Description: ", cin >> this->Description;
	}

	virtual void Show() {
		cout << "Title: " << this->Title << endl;
		cout << "Description: " << this->Description << "\n\n";
		cout << "Creator: " << this->CreatorName << endl;
	}
};


enum TASK_STATUS {
	todo,
	doing,
	done,
};

class TaskWithStatus : public Task {
public:
	TASK_STATUS Status = TASK_STATUS::todo;

	TaskWithStatus(string creatorName) : Task(creatorName) {}

	void InitTask() override {
		cout << "Title: ", cin >> this->Title;
		cout << "Description: ", cin >> this->Description;

		cout << endl << "Select Status: " << endl;
		cout << "1. todo" << endl
			<< "2. doing" << endl
			<< "3. done" << "\n\n";

		int select;
		cin >> select;
		this->Status = (1 <= select && select <= 3)
			? (TASK_STATUS)(select - 1)
			: TASK_STATUS::todo;
	}

	void Show() override {
		cout << "Title: " << this->Title << endl;
		cout << "Description: " << this->Description << endl;
		cout << "Status: " << this->Status << "\n\n";
		cout << "Creator: " << this->CreatorName << endl;
	}
};