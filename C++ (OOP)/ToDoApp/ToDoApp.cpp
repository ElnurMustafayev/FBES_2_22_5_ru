#include <iostream>
#include <vector>
#include <map>
#include <conio.h>
#include "Tasks.h"
#include "Users.h"

using namespace std;

map<string, User> Users = map<string, User>();
vector<Task*> Tasks = vector<Task*>();
User loginedUser = User();

int main()
{
	auto user1 = User();
	user1.nickname = "Jafar";
	user1.name = "Jafar";
	user1.surname = "Sadiq";
	user1.password = "Aboba";

	Users[user1.nickname] = user1;

	auto user2 = User();
	user2.nickname = "ChessQuru";
	user2.name = "Abulqasim";
	user2.surname = "Nazarov";
	user2.password = "Kek";

	Users[user2.nickname] = user2;

	bool isLogined = false;

	while (!isLogined) {
		system("cls");
		cout << "1. Login\n"
			//<< "2. Registration\n"
			<< "3. Exit\n\n";

		int choise;
		cout << "Input choise: ", cin >> choise;
		switch (choise) {
		case 1:
		{
			string login;
			cout << "Login: ", cin >> login;

			string password;
			cout << "Password: ", cin >> password;

			User foundUser = Users[login];

			if (password.length() > 0 && foundUser.password == password) {
				isLogined = true;
				loginedUser = foundUser;
			}

			break;
		}
		//case 2:
		//	break;
		case 3:
			exit(0);
			break;
		}
	}

	while (true) {
		system("cls");
		cout << "1. Add Task\n"
			<< "2. Show My Tasks\n"
			<< "3. Exit\n\n";

		int choise;
		cout << "Input choise: ", cin >> choise;

		switch (choise) {
		// ADD NEW TASK
		case 1: {
			cout << "1. Task" << endl
				<< "2. TaskWithStatus" << "\n\n";

			const int minSelect = 1, maxSelect = 2;

			int select;
			cin >> select;
			if (minSelect > select || select > maxSelect) {
				select = minSelect;
			}

			Task* task = nullptr;

			switch (select)
			{
			default:
			case 1:
				task = new Task(loginedUser.name);
				break;
			case 2:
				task = new TaskWithStatus(loginedUser.name);
				break;
			}

			task->InitTask();

			Tasks.push_back(task);

			_getch();
			break;
		}
		case 2: 
			for (auto task : Tasks) {
				if (task->CreatorName == loginedUser.name) {
					task->Show();
				}
				cout << "\n- - - - - - - - -\n\n";
			}
			_getch();
			break;
		case 3:
			system("cls");
			cout << "Goodbye!";
			exit(0);
			break;
		}
	}
}