>
> # Drawer
>
## 

- ### Unda ishlatildi
    - Switch(case) method
    - ToLower method
    - DrawerTriangle
    - DrawerSquare

### Input
```bash
Console.WriteLine("Welcome Drawer\nPlease choose you want");
Console.WriteLine("1 => Triangle\n2 => Square");
int numberChoose = Convert.ToInt32(Console.ReadLine());
```
### switch
```bash
switch(numberChoose){
    case 1:DrawerTriangle();
        break;
    case 2: DrawerSquare();
        break;
    
}
```
### MethodTriangle
Bunda dastur foydalanuvchidan **Uchburchak** balandligini qiymatini butun son (___int___) da so'raydi
```bash
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
```
### MethodSquare
Bunda dastur foydalanuvchidan 
