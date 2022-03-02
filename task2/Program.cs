 int i = 200;
bool firstValue = true ;
Console.Write("Числа между 200 и 500, которые делятся на 17 : \n");
while (i < 500)

{
    
    if (i % 17 == 0 )
       
    {


        if (firstValue)
        {
            Console.Write(i);
            firstValue = false;


        }
       
        else 
        {
            
            Console.Write(" , {0}", i);
        }
       
    }
    i++;

}
