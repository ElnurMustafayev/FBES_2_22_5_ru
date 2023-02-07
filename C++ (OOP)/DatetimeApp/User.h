#pragma once

struct User {
	string Name;
	string Surname;
	Datetime Birthdate;

	User(string name, string surname, Datetime birthdate)
	{
		this->Name = name;
		this->Surname = surname;
		this->Birthdate = birthdate;
	}

	int GetAge() {
		Datetime now = Datetime::Now();

		int years = now.GetYear() - this->Birthdate.GetYear();

		if (now.GetMonth() < this->Birthdate.GetMonth()) {
			years--;
		}
		else if (now.GetMonth() == this->Birthdate.GetMonth()) {
			if (now.GetDay() < this->Birthdate.GetDay()) {
				years--;
			}
		}

		return years;
	}
};