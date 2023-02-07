#pragma once

class Datetime {
	int year = 1;
	int month = 1;
	int day = 1;

public:
#pragma region ACCESSORS

#pragma region YEAR
	int GetYear() {
		return this->year;
	}
#pragma endregion

#pragma region MONTH
	void SetMonth(int month) {
		/*if (1 <= month && month <= 12)
			this->month = month;*/

		this->month = (1 <= month && month <= 12)
			? month
			: throw "Incorrect month value";
	}
	int GetMonth() {
		return this->month;
	}
#pragma endregion

#pragma region DAY
	void SetDay(int day) {
		bool isLeapYear = ((this->year % 4 == 0) && (this->year % 100 != 0));
		int februaryDaysCount = (isLeapYear ? 29 : 28);

		int monthLimits[12] = { 31, februaryDaysCount, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		int maxDays = monthLimits[this->month - 1];

		this->day = (1 <= day && day <= maxDays)
			? day
			: throw "Incorrect day value";
	}
	int GetDay() {
		return this->day;
	}
#pragma endregion

#pragma endregion

	Datetime(int year, int month, int day) : year(year) {
		this->SetMonth(month);
		this->SetDay(day);
	}
	Datetime() {}

	static Datetime Now() {
		time_t t = time(0);

		tm* now = localtime(&t);

		return Datetime(now->tm_year + 1900, now->tm_mon + 1, now->tm_mday);
	}

	void Show() {
		printf("%d.%d.%d\n", this->day, this->month, this->year);
	}
};