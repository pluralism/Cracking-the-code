#include <iostream>
using namespace std;

void BoyerMoore(string pattern, string text) {
    int r[256];
    for(int &i : r)
        i = -1;

    // last occurrence of each character
    for(int i = 0; i < pattern.size(); i++)
        r[(int)pattern[i]] = i;

    auto m = static_cast<int>(pattern.length());
    auto n = static_cast<int>(text.length());

    // shift starts at index 0
    auto next = 0;
    for(int i = 0; i <= n - m; i++)
    {
        auto j = m - 1;
        while (j >= 0 && pattern[j] == text[next + j])
            j--;

        if(j >= 0)
            next += max(1, j - r[text[next + j]]);
        else
        {
            cout << "Found pattern at index " << next << endl;
            if(next + m < n)
                next += m - r[text[next + m]];
            else
                next += 1;
        }
    }
}

int main(int argc, char *argv[]) {
    return 0;
}
