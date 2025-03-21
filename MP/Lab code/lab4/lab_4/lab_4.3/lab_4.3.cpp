#include <iostream>
#include <string>
#include <chrono>

using namespace std;
using namespace chrono;

// Рекурсивный метод
int lcsRecursive(const string& X, const string& Y, int m, int n) {
    if (m == 0 || n == 0)
        return 0;
    if (X[m - 1] == Y[n - 1])
        return 1 + lcsRecursive(X, Y, m - 1, n - 1);
    else
        return max(lcsRecursive(X, Y, m, n - 1), lcsRecursive(X, Y, m - 1, n));
}

// Метод динамического программирования
int lcsDP(const string& X, const string& Y) {
    int m = X.length(), n = Y.length();

    // Динамическое выделение памяти для массива dp
    int** dp = new int* [m + 1];
    for (int i = 0; i <= m; ++i) {
        dp[i] = new int[n + 1];
    }

    // Заполнение массива dp с использованием алгоритма LCS
    for (int i = 0; i <= m; i++) {
        for (int j = 0; j <= n; j++) {
            if (i == 0 || j == 0)
                dp[i][j] = 0;
            else if (X[i - 1] == Y[j - 1])
                dp[i][j] = dp[i - 1][j - 1] + 1;
            else
                dp[i][j] = max(dp[i - 1][j], dp[i][j - 1]);
        }
    }

    int result = dp[m][n]; // Сохранение результата

    // Освобождение памяти
    for (int i = 0; i <= m; ++i) {
        delete[] dp[i];
    }
    delete[] dp;

    return result; // Возврат результата
}
int main() {
    setlocale(LC_ALL, "Russian");
    string X = "BXWAFRE";
    string Y = "XCDUFR";

    // Сравнение рекурсивного метода
    auto startRecursive = high_resolution_clock::now();
    int lcsLengthRecursive = lcsRecursive(X, Y, X.length(), Y.length());
    auto endRecursive = high_resolution_clock::now();
    auto durationRecursive = duration_cast<microseconds>(endRecursive - startRecursive);

    // Сравнение метода динамического программирования
    auto startDP = high_resolution_clock::now();
    int lcsLengthDP = lcsDP(X, Y);
    auto endDP = high_resolution_clock::now();
    auto durationDP = duration_cast<microseconds>(endDP - startDP);

    // Вывод результатов
    cout << "Результат рекурсивного метода: " << lcsLengthRecursive << endl;
    cout << "Время выполнения рекурсивного метода: " << durationRecursive.count() << " mcs" << endl;

    cout << "Результат метода динамического программирования: " << lcsLengthDP << endl;
    cout << "Время выполнения метода динамического программирования: " << durationDP.count() << " mcs" << endl;

    return 0;
}
