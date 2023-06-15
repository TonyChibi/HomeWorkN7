int [,] GetMatrix(int N,int M){
    int [,] arr= new int[N,M];
    for(int i=0;i<arr.GetLength(0);i++){
        for(int j=0;j<arr.GetLength(1);j++){
            arr[i,j]= new Random().Next(0,10);
        }
    }
    return arr;
}
void ShowMatrix(int[,]matrix){
    for(int i=0;i<matrix.GetLength(0);i++){
        for(int j=0;j<matrix.GetLength(1);j++){
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
void TransMtx(int [,]mtx){
    for(int i=0; i<mtx.GetLength(0)/2;i++){
        for(int j=0;j<mtx.GetLength(1);j++){
            int n=mtx[i,j];
            mtx[i,j]=mtx[mtx.GetLength(0)-i-1,j];
            mtx[mtx.GetLength(0)-i-1,j]=n;
        }
    }
   
}

Console.Clear();
Console.WriteLine("insert teo integers for size of a matrix: ");
int []arr=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int [,]mtx=GetMatrix(arr[0],arr[1]);
ShowMatrix(mtx);

TransMtx(mtx);
Console.WriteLine("ahalai-mahalai");
ShowMatrix(mtx);

