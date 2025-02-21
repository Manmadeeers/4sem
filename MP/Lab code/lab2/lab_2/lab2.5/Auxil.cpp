#include <iostream>
#include <random>

namespace auxil {
	void start() {
		srand((unsigned)time(NULL));
	}

	double dget(double min, double max) {
		return ((double)rand() / (double)RAND_MAX) * (max - min) + min;
	}

	int iget(int min, int max) {

		return (int)dget((double)min, (double)max);
	};

}