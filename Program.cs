﻿// Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//bool x = true;
//bool y = true;
//if (!( x || y))
  //Console.WriteLine( "не x && не y" );
//else
  //Console.WriteLine("не истинно");
  // ОТВЕТ: не истинно

bool x = false;
bool y = false;
if (!( x || y))
    Console.WriteLine( "не x && не y = утверждение истинно" );
else
    Console.WriteLine("не истинно");

//bool x = true;
//bool y = false;
//if (!( x || y))
  //  Console.WriteLine( "не x && не y = утверждение истинно" );
//else
  //  Console.WriteLine("не истинно");
// ОТВЕТ: не истинно

//bool x = false;
//bool y = true;
//if (!( x || y))
  //  Console.WriteLine( "не x && не y = утверждение истинно" );
//else
  //  Console.WriteLine("не истинно");
// ОТВЕТ: не истинно.