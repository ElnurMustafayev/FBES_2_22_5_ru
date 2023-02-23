#include <iostream>

using namespace std;

#include "HashSet.h"

int main()
{
    HashSet hashSet = HashSet();
    hashSet.Add(21);
    hashSet.Add(71);
    hashSet.Add(30);
    hashSet.Add(54);
    hashSet.Add(7);

    hashSet.Show();
}