#include <iostream>
using namespace std;

int bitSwapCount(int a, int b)
{
    int count = 0;
    for(int c = a ^ b; c != 0; c >>= 1)
        count += c & 1;
    return count;
}

int main() {
    cout << bitSwapCount(4, 500) << endl;
    return 0;
}
