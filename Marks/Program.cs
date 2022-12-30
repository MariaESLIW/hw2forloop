int[] marks = new int[10];

marks[0] = 9;
marks[1] = 7;
marks[2] = 8;
marks[3] = 9;
marks[4] = 5;
marks[5] = 9;
marks[6] = 10;
marks[7] = 3;
marks[8] = 10;
marks[9] = 7;

double averageMark = 0.0;

int maxMark = 0;
int minMark = 10;
int summaMarks = 0;

for(int i=0; i<10; i=i+1)
{
    if (marks[i]>maxMark)
    {
        maxMark = marks[i];
    }
    if (marks[i]<minMark)
    {
        minMark = marks[i];
    }
    summaMarks = summaMarks + marks[i];
}
averageMark = summaMarks / 10.0;
Console.WriteLine("average Mark: " + averageMark);
Console.WriteLine("min Mark: " + minMark);
Console.WriteLine("max Mark: " + maxMark);
