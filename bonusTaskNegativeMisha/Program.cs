int [,] GetMatrix(int N,int M){
    int [,] arr= new int[N,M];
    for(int i=0;i<arr.GetLength(0);i++){
        for(int j=0;j<arr.GetLength(1);j++){
            arr[i,j]= new Random().Next(0,2);
        }
    }
    return arr;
}
void ShowMatrix(string[,]matrix){
    for(int i=0;i<matrix.GetLength(0);i++){
        for(int j=0;j<matrix.GetLength(1);j++){
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
string [,] MakePicture(int [,]matrix){
    string [,]mtx=new string[matrix.GetLength(0),matrix.GetLength(1)];
    for(int i=0;i<mtx.GetLength(0);i++){
        for(int j=0;j<mtx.GetLength(1);j++){
            if(matrix[i,j]==0){
                mtx[i,j]="W";
                }
            else mtx[i,j]="B";
        }
    }
    return mtx;
}

void CountExeptions(string[,]pic,string[,]neg){
    int count=0;
    for(int i=0;i<pic.GetLength(0);i++){
        for(int j=0;j<pic.GetLength(1);j++){
            if(pic[i,j]==neg[i,j])count++;
        }
    }
    Console.WriteLine($"the ammount of exeptions is {count}");
}


Console.Clear();
Console.WriteLine("insert two integers for matrix size: ");
int []size=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int [,]mtx=GetMatrix(size[0],size[1]);
string [,] pic=MakePicture(mtx);
int [,] other=GetMatrix(size[0],size[1]);
string[,]neg=MakePicture(other);
ShowMatrix(pic);
Console.WriteLine("Now we show something supposed to be a negative");
ShowMatrix(neg);
CountExeptions(pic,neg);    

