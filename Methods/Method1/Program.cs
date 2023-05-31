//Method 1
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(result < arg2) result = arg2;
    if(result < arg3) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 34;
int c1 = 89;

int a2 = 13;
int b2 = 404;
int c2 = 9;

int a3 = -203;
int b3 = 134;
int c3 = 8;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);