#include <iostream>
using namespace std;

int bitSwapCount(int a, int b)
{
    int count = 0;
    for(int c = a ^ b; c != 0; c >>= 1)
        count += c & 1;
    return count;
}

int swapBytes(int a) {
    return static_cast<int>((((a & 0xAAAAAAAA) >> 1) != 0u) || (((a & 0x55555555) << 1) != 0));
}

int main() {
    cout << bitSwapCount(4, 500) << endl;
    cout << swapBytes(5) << endl;
    return 0;
}
