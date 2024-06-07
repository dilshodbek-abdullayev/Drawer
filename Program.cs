using System;
bool isSuccess = true;

while(isSuccess){

Console.WriteLine("Welcome Drawer\nPlease choose you want");
Console.WriteLine("1 => Triangle\n2 => Square");
int numberChoose = Convert.ToInt32(Console.ReadLine());
switch(numberChoose){
    case 1:DrawerTriangle();
        break;
    case 2: DrawerSquare();
        break;
    
}
Console.WriteLine(" Do you want to continue? Yes (y) / No (n)");
string text = Console.ReadLine().ToLower();
if(text == "Yes" || text == "y"){
    isSuccess = true;
}
else{
    isSuccess = false;
}
}
static void DrawerTriangle()
{
    Console.WriteLine("Enter the height of the triangle: ");
    int height = Convert.ToInt32(Console.ReadLine());

    for(int i = 1;i<=height;i++){

        for(int j = 1; j<= height - i; j++){
            Console.Write(" ");
        }

        for(int k = 1;k<= (2*i-1); k++){
            Console.Write("*");
        }
        Console.WriteLine("");
    }
}
static void DrawerSquare(){
    
    Console.Write("Enter the side length of the square: ");
    int Length = Convert.ToInt32(Console.ReadLine());
    
    for(int i = 0; i< Length;i++){
        for(int j = 0; j< Length; j++){
            // ushbu qism chekkalarini * bilan chiqarish uchun
            if(i == 0 || i == Length-1 || j == 0 || j == Length-1){
                Console.Write("* ");
            }
            // ushbu qism o'rtalarini bo'sh holda chiqarish uchun
            else{
                Console.Write(" ");
            }
        }
        Console.WriteLine("");
    }
}


