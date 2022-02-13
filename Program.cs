// Задача 22:  Найти расстояние между точками в пространстве 2D/3D

// 2D
//int numberX = new Random().Next(-50,50);
//int numberY = new Random().Next(-50,0);
//Console.WriteLine("координаты точки А: х = "+numberX+", y = "+numberY);
//int numberX2 = new Random().Next(-50,50);
//int numberY2 = new Random().Next(-50,0);
//Console.WriteLine("координаты точки B: х = "+numberX2+", y = "+numberY2);
//int result = (numberX-numberX2)*(numberX-numberX2)+(numberY-numberY2)*(numberY-numberY2)/(numberX-numberX2)*(numberX-numberX2)+(numberY-numberY2)*(numberY-numberY2);
//Console.WriteLine("Расстояние между точками А и В "+result);

// 3 D
int numberX = new Random().Next(-50,50);
int numberY = new Random().Next(-50,50);
int numberZ= new Random().Next(-50,50);
Console.WriteLine("координаты точки А: х = "+numberX+", y = "+numberY+", z = "+numberZ);
int numberX2 = new Random().Next(-50,50);
int numberY2 = new Random().Next(-50,0);
int numberZ2= new Random().Next(-50,50);
Console.WriteLine("координаты точки B: х = "+numberX2+", y = "+numberY2+", z = "+numberZ2);
int result = (numberX-numberX2)*(numberX-numberX2)+(numberY-numberY2)*(numberY-numberY2)+(numberZ-numberZ2)*(numberZ-numberZ2)/
(numberX-numberX2)*(numberX-numberX2)+(numberY-numberY2)*(numberY-numberY2)+(numberZ-numberZ2)*(numberZ-numberZ2);
Console.WriteLine("Расстояние между точками А и В "+result);