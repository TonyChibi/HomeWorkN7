double [,] GetMatrix(int m,int n){
    double [,] arr= new double[m,n];
    for(int i=0;i<m;i++){
        for(int j=0;j<n;j++){
            arr[i,j]= Math.Round(new Random().NextDouble()*20-10,2);//(-10;10)
        }
    }
    return arr;
}
void ShowMatrix(double[,]matrix){
    for(int i=0;i<matrix.GetLength(0);i++){
        for(int j=0;j<matrix.GetLength(1);j++){
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.WriteLine("insert two numbers for matrix size: ");
int []size=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
double [,]matr=GetMatrix(size[0],size[1]);
ShowMatrix(matr);
