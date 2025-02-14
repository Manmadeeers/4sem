#include <iostream>

unsigned long long fibonacci(int n) {
    // Base cases
    if (n <= 0) return 0;
    if (n == 1) return 1;

    // Recursive case
    return fibonacci(n - 1) + fibonacci(n - 2);
}

int main() {
    int number_in_fibonacci_sequence = 45;
    clock_t timer1 = 0;
    clock_t timer2 = 0;
    timer1 = clock();
    unsigned long long result = fibonacci(number_in_fibonacci_sequence);
    timer2 = clock();
    std::cout << number_in_fibonacci_sequence << "th number in fibonacci sequence is" << result;
    std::cout << std::endl;
    std::cout << "Time taken: " << (double)(timer2 - timer1)/(double)CLOCKS_PER_SEC;
}