int[,] GetMatrix(int m,int n){
    int [,] arr= new int[m,n];
    int k=0;
    int i=0;
    int j=0;
    int f=i;
    while (k<m*n){
        if(i==n){
            i--;
            while(arr[j,i]!=0){
                
                j++;
            }
        }
        while(i<n){
            f=i;
            while(j<m){
                arr[j,f]=k;
                    k++;
                if(f-1<0)break;
                f--;
                j++;
            }
            j=0;
            i++;
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
Console.Clear();
Console.WriteLine("insert two numbers for matrix size: ");
int []size=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int [,]matr=GetMatrix(size[0],size[1]);
ShowMatrix(matr);
