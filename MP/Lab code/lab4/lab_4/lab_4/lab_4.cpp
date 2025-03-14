#include <iostream>
#include <string>
#include <ctime>
using namespace std;

int main(void)
{
    srand(time(NULL));
    string str;
    int l;
    cout << "Enter the string length: "; cin >> l;
    for (int i = 0; i < l; i++)
    {
        str += rand() % ('z' - 'a' + 1) + 'a';
    }
    cout << str << endl;
    system("pause");
}
