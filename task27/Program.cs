Console.WriteLine("enter the digit: ");
int num = int.Parse(Console.ReadLine());

string numS = num.ToString();

int length = numS.Length;
int sum = 0;
int sumNum(string numS, int length){
    for (int i = 0; i < length; i++){
        sum += int.Parse(numS[i].ToString());
    }
    return sum;
}
int res = sumNum(numS, length);
Console.WriteLine(res);