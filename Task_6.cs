Console.WriteLine("Введите целое число");
String Temp_num = Console.ReadLine();
float Temp_num_1 = float.Parse(Temp_num);
int desired_Num=Convert.ToInt32(Temp_num_1);
if(Temp_num_1!=desired_Num)
{
  Console.WriteLine("Вы ввели дробное чило");
}
else{
if (desired_Num% 2 ==0)
{
  Console.Write("Число "+Temp_num + " четное");
}
else
{
  Console.Write("Число "+Temp_num + " нечетное");
}
}
