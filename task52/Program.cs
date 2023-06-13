 int [,] GetMatrix(int m,int n){
 int [,] arr= new int[m,n];
    for(int i=0;i<m;i++){
        for(int j=0;j<n;j++){
            arr[i,j]= new Random().Next(0,10);
        }
    }
    return arr;
}
void ShowMatrix (int[,]matrix){
    for(int i=0;i<matrix.GetLength(0);i++){
        for(int j=0;j<matrix.GetLength(1);j++){
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
double [] GetCollumnAverage(int[,]matr){
    double []arr=new double[matr.GetLength(1)];
    for(int i=0;i<matr.GetLength(1);i++){
        double avg=0;
        for(int j=0;j<matr.GetLength(0);j++)avg+=matr[j,i];
        arr[i]=Math.Round(avg/matr.GetLength(1),2);
    }
    return arr;
}

Console.Clear();
Console.WriteLine("insert two numbers for matrix size: ");
int []size=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int [,]matr=GetMatrix(size[0],size[1]);
ShowMatrix(matr);
Console.WriteLine($"the average of collumn is [{string.Join(";",GetCollumnAverage(matr))}]");