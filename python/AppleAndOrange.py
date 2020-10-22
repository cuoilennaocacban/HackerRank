# https://www.hackerrank.com/challenges/apple-and-orange/problem

# sample input
# 7 11
# 5 15
# 3 2
# -2 2 1
# 5 -6

# sample output
# 1
# 1

#!/bin/python3

import math
import os
import random
import re
import sys

def countLanded(s, t, root, fruits):
    fruit_landed = 0

    for dis in fruits:
        landed = root + dis
        if s <= landed and landed <= t:
            fruit_landed = fruit_landed + 1

    return fruit_landed

# Complete the countApplesAndOranges function below.
def countApplesAndOranges(s, t, a, b, apples, oranges):
    apples_landed = countLanded(s, t, a, apples)
    oranges_landed = countLanded(s, t, b, oranges)

    print(apples_landed)
    print(oranges_landed)

if __name__ == '__main__':
    st = input().split()
    s = int(st[0])
    t = int(st[1])
    ab = input().split()
    a = int(ab[0])
    b = int(ab[1])
    mn = input().split()
    m = int(mn[0])
    n = int(mn[1])
    apples = list(map(int, input().rstrip().split()))
    oranges = list(map(int, input().rstrip().split()))
    countApplesAndOranges(s, t, a, b, apples, oranges)
