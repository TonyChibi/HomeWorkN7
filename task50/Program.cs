int [,] GetMatrix(){
    int [,] arr= new int[new Random().Next(3,10),new Random().Next(3,10)];
    for(int i=0;i<arr.GetLength(0);i++){
        for(int j=0;j<arr.GetLength(1);j++){
            arr[i,j]= new Random().Next(0,10);
        }
    }
    return arr;
}
void FindElement(int[,]matr,int i,int j){
    if(i>matr.GetLength(0)||j>matr.GetLength(1)){
        Console.WriteLine("Sorry, there is not such index");
    }
    else Console.WriteLine($"the element [{i},{j}] is {matr[i,j]} ");

}

Console.Clear();
Console.WriteLine("insert two numbers for index of element in matrix: ");
int []index=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int [,] matr= GetMatrix();
FindElement(matr,index[0],index[1]);