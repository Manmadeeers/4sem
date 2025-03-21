#include <iostream>
#include <vector>
#include <time.h>
#include <chrono>
//#include <string>
//#include "string.h"
using namespace std;


const string string1 = "Раб";
const string string2 = "Барка";
const int length1 = 3;
const int length2 = 5;

int levensteinDistanceDP(const string& str1, const string& str2, int len1, int len2) {
	vector<vector<int>>dp(len1 + 1, vector<int>(len2 + 1, 0));

	for (int i = 1; i <= len1; i++) {
		for (int j = 1; j <= len2; j++) {
			if (i == 0) {
				dp[i][j] = j;
			}
			else if (str1[i - 1] == str2[j - 1]) {
				dp[i][j] = dp[i - 1][j - 1];
			}
			else {
				dp[i][j] = 1 + min(min(dp[i][j - 1], dp[i - 1][j]), dp[i - 1][j - 1]);
			}
		}
	}

	return dp[len1][len2];
}

int levensteinDistanceRecursive(const string& str1, const string& str2, int len1, int len2) {
	if (len1 == 0) {
		return len2;
	}
	if (len2 == 0) {
		return len1;
	}
	if (str1[len1 - 1] == str2[len2 - 1]) {
		return levensteinDistanceRecursive(str1, str2, len1 - 1, len2 - 1);
	}

	return 1 + min(min(levensteinDistanceRecursive(str1, str2, len1, len2 - 1), levensteinDistanceRecursive(str1, str2, len1 - 1, len2)),levensteinDistanceRecursive(str1, str2, len1 - 1, len2 - 1));
}


void main() {

	auto start1 = chrono::high_resolution_clock::now();
	cout << "Levensein Distance Diamic Programming:" << levensteinDistanceDP(string1, string2, length1, length2) << endl;
	auto end1 = chrono::high_resolution_clock::now();
	cout << "Time taken: " << chrono::duration_cast<chrono::milliseconds>(end1-start1).count() << endl;


	auto start2 = chrono::high_resolution_clock::now();
	cout << "Levenstein Distance Recursive: " << levensteinDistanceRecursive(string1, string2, length1, length2);
	auto end2 = chrono::high_resolution_clock::now();
	cout << "Time taken: " << chrono::duration_cast<chrono::milliseconds>(end2 - start2).count() << endl;
}

